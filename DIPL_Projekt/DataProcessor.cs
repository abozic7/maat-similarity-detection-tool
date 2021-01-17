using Antlr.Runtime;
using DIPL_Projekt.Algorithms;
using DIPL_Projekt.BaseLib.Controllers;
using DIPL_Projekt.Controllers.Controllers;
using DIPL_Projekt.LexicalAnalyzers;
using DIPL_Projekt.Model.Models;
using DIPL_Projekt.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DIPL_Projekt
{
    /// <summary>
    /// Class used for processing data in steps of preprocessing and comparing files.
    /// </summary>
    public class DataProcessor
    {
        private static IFileEntryController _fileEntryController;
        private static ITaskController _taskController;
        private static IComparisonResultController _comparisonResultController;
        private static int noOfLineComments;
        private static int noOfBlockComments;

        public DataProcessor(IFileEntryController fileEntryController, ITaskController taskController, IComparisonResultController comparisonResultController)
        {
            _fileEntryController = fileEntryController;
            _taskController = taskController;
            _comparisonResultController = comparisonResultController;
        }

        /// <summary>
        /// Checks if comparison of files for a given task is needed. Used to optimize file comparison.
        /// </summary>
        /// <param name="taskId">The id of the given task.</param>
        /// <returns>True if a comparison is needed, false if a comparison is not needed.</returns>
        private bool FileComparisonNeeded(int taskId)
        {
            var files = _fileEntryController.GetFilesByTask(taskId);
            Dictionary<string, List<Tuple>> fileInfo = new Dictionary<string, List<Tuple>>();
            Dictionary<string, int> fileExtenstionCounter = new Dictionary<string, int>();

            foreach (var file in files)
            {
                if (fileExtenstionCounter.ContainsKey(file.FileExtension))
                {
                    fileExtenstionCounter[file.FileExtension]++;
                }
                else
                {
                    fileExtenstionCounter.Add(file.FileExtension, 1);
                }

                AddFileInfoForExtension(file, fileInfo);
            }

            int noOfNeededComparisons = CountNoOfNeededComparisons(fileInfo, fileExtenstionCounter);
            return !(_comparisonResultController.GetComparisonResultsByTask(taskId).Count == noOfNeededComparisons);
        }


        /// <summary>
        /// Adds file authors and the number of files they wrote for each extension.
        /// Used as a helper method in checking if file comparison is needed.
        /// </summary>
        /// <param name="file">A file that is used to collect file author and raise counter.</param>
        /// <param name="fileInfo">A collection which contains file authors and their file counter.</param>
        private void AddFileInfoForExtension(FileEntry file, Dictionary<string, List<Tuple>> fileInfo)
        {
            if (fileInfo.ContainsKey(file.FileExtension))
            {
                var tuples = fileInfo[file.FileExtension]
                    .Where(t => t.Distinctor.Equals(file.FileAuthor))
                    .ToList();

                if (tuples.Count == 0)
                {
                    fileInfo[file.FileExtension].Add(
                        new Tuple()
                        {
                            Distinctor = file.FileAuthor,
                            Counter = 1
                        });
                }
                else
                {
                    fileInfo[file.FileExtension]
                        .Where(t => t.Distinctor.Equals(file.FileAuthor))
                        .First()
                        .Counter++;
                }
            }
            else
            {
                fileInfo.Add(file.FileExtension,
                    new List<Tuple>()
                    {
                            new Tuple()
                            {
                                Distinctor = file.FileAuthor,
                                Counter = 1
                            }
                    });
            }
        }

        /// <summary>
        /// Determines the number of needed comparisons.
        /// </summary>
        /// <param name="fileInfo">A collection which contains file authors and their file counter.</param>
        /// <param name="fileExtenstionCounter">A collection which contains a file counter for each extension.</param>
        /// <returns>A number of needed comparisons.</returns>
        private int CountNoOfNeededComparisons(Dictionary<string, List<Tuple>> fileInfo, Dictionary<string, int> fileExtenstionCounter)
        {
            int noOfNeededComparisons = 0;
            int extensionCounter;
            foreach (var key in fileInfo.Keys)
            {
                extensionCounter = fileExtenstionCounter[key];
                foreach (var tuple in fileInfo[key])
                {
                    extensionCounter -= tuple.Counter;
                    noOfNeededComparisons += tuple.Counter * extensionCounter;
                }
            }

            return noOfNeededComparisons;
        }

        /// <summary>
        /// Compares files of a given task.
        /// </summary>
        /// <param name="task">A task whose files need to be compared.</param>
        /// <returns>A collection of comparison results.</returns>
        public List<ComparisonResult> CompareFiles(Model.Models.Task task)
        {
            var files = _fileEntryController.GetFilesByTask(task.Id);
            List<ComparisonResult> results = new List<ComparisonResult>();
            var previousResults = _comparisonResultController.GetComparisonResultsByTask(task.Id);

            if (!FileComparisonNeeded(task.Id))
            {
                return previousResults.OrderByDescending(r => r.Similarity).ToList();
            }

            for (int i = 0; i < files.Count; i++)
            {
                for (int j = i + 1; j < files.Count; j++)
                {
                    var foundPrevResult = previousResults.Where(r => (r.File1Id == files[i].Id && r.File2Id == files[j].Id) || (r.File1Id == files[j].Id && r.File2Id == files[i].Id)).ToList();
                    if (foundPrevResult.Count != 0)
                    {
                        foreach (var res in foundPrevResult)
                        {
                            results.Add(res);
                        }
                        continue;
                    }
                    if (files[i].FileAuthor.Equals(files[j].FileAuthor))
                    {
                        continue;
                    }
                    if (!files[i].FileExtension.Equals(files[j].FileExtension))
                    {
                        continue;
                    }

                    double hashSimilarity, winnowSimilarity, propertiesSimilarity, similarity;
                    DetermineAllSimilarities(task, files[i], files[j], out hashSimilarity, out winnowSimilarity, out propertiesSimilarity, out similarity);

                    ComparisonResult comparisonResult = new ComparisonResult()
                    {
                        Jmbag1 = files[i].FileAuthor,
                        Jmbag2 = files[j].FileAuthor,
                        TaskId = task.Id,
                        File1Id = files[i].Id,
                        File2Id = files[j].Id,
                        Similarity = similarity * 100,
                        PropertiesSimilarity = propertiesSimilarity * 100,
                        CheckSumSimilarity = hashSimilarity * 100,
                        WinnowingSimilarity = winnowSimilarity * 100
                    };
                    _comparisonResultController.AddComparisonResult(comparisonResult);
                    results.Add(comparisonResult);
                }
            }
            return results.OrderByDescending(r => r.Similarity).ToList();
        }

        /// <summary>
        /// Compares two files and determines the values of similarities for each algorithm used to compare files.
        /// </summary>
        /// <param name="task">The task which contains the two files being compared.</param>
        /// <param name="file1">The first file that is being compared.</param>
        /// <param name="file2">The second file that is being compared.</param>
        /// <param name="hashSim">Calculated similarity of two files using the CheckSum algorithm.</param>
        /// <param name="winnowSim">Calculated similarity of two files using the Winnow algorithm.</param>
        /// <param name="propertiesSim">Calculated similarity of two files using the file properties comparison algorithm.</param>
        /// <param name="totalSim">Value of the total similarity considering the calculated similarities 
        /// from all of the algorithms being used.</param>
        private void DetermineAllSimilarities(Model.Models.Task task, FileEntry file1, FileEntry file2, 
            out double hashSim, out double winnowSim, out double propertiesSim, out double totalSim)
        {
            hashSim = CompareHashValues(file1.FileCheckSumAfterPreprocessing, file2.FileCheckSumAfterPreprocessing);

            if (hashSim == 0)
            {
                winnowSim = CompareFilesWithWinnow(file1.FileContentAfterLexAnalysis, file2.FileContentAfterLexAnalysis, task);
                propertiesSim = CompareFileProperties(file1, file2);
                totalSim = CalculateSimilarity(winnowSim, propertiesSim, task);
            }
            else
            {
                winnowSim = 0;
                propertiesSim = 0;
                totalSim = 1;
            }
        }

        /// <summary>
        /// Calculates the total similarity using the similarities of files from Winnowing and file property comparison algorithm.
        /// </summary>
        /// <param name="winnowSim">The similarity of two files using the Winnow algorithm.</param>
        /// <param name="propSim">The similarity of two files using the file properties comparison algorithm.</param>
        /// <param name="task">The task which contains the two files being compared.</param>
        /// <returns>The total similarity of two files.</returns>
        private double CalculateSimilarity(double winnowSim, double propSim, Model.Models.Task task)
        {
            double algParamsSum = task.Pproperties + task.Pwinnowing;
            double propCoeff = (double)task.Pproperties / algParamsSum;
            double winnowCoeff = (double)task.Pwinnowing / algParamsSum;

            double result = propCoeff * propSim + winnowCoeff * winnowSim;
            return result;
        }

        /// <summary>
        /// Compares two files using Winnow algorithm.
        /// </summary>
        /// <param name="input1">The content of the first file.</param>
        /// <param name="input2">The content of the second file.</param>
        /// <param name="task">The task which contains the two files being compared.</param>
        /// <returns>The Winnow similarity of two files.</returns>
        private double CompareFilesWithWinnow(string input1, string input2, Model.Models.Task task)
        {
            return WinnowAlgorithm.Compare(input1, input2, task.KgramLength, task.WindowSize);
        }

        /// <summary>
        /// Compares two files using CheckSum algorithm.
        /// </summary>
        /// <param name="hash1">The hash value of the first file.</param>
        /// <param name="hash2">The hash value of the second file.</param>
        /// <returns>The CheckSum similarity of two files.</returns>
        private double CompareHashValues(string hash1, string hash2)
        {
            return hash1.Equals(hash2) ? 1 : 0;
        }

        /// <summary>
        /// Compares two files using file properties comparison algorithm.
        /// </summary>
        /// <param name="file1">The first file being compared.</param>
        /// <param name="file2">The second file being compared.</param>
        /// <returns>The file properties similarity.</returns>
        private double CompareFileProperties(FileEntry file1, FileEntry file2)
        {
            int noOfProperties = 5;
            int noOfEqualProperties = 0;
            if (file1.FileSize == file2.FileSize) noOfEqualProperties++;
            if (file1.FileNoOfLines == file2.FileNoOfLines) noOfEqualProperties++;
            if (file1.FileNoOfEmptyLines == file2.FileNoOfEmptyLines) noOfEqualProperties++;
            if (file1.FileNoOfLineComments == file2.FileNoOfLineComments) noOfEqualProperties++;
            if (file1.FileNoOfBlockComments == file2.FileNoOfBlockComments) noOfEqualProperties++;

            return (double)noOfEqualProperties / noOfProperties;
        }

        /// <summary>
        /// Deletes all directories and files created during preprocessing if they already exist.
        /// </summary>
        /// <param name="zipPath">The path where the .zip archive containing student directories is located.</param>
        public void DeleteIfPreviouslyExtracted(string zipPath)
        {
            string zipDir = Path.GetDirectoryName(zipPath);
            string fileName = Path.GetFileNameWithoutExtension(zipPath);
            string path = zipDir + "\\" + fileName;

            if (Directory.Exists(path + "_extracted"))
            {
                Directory.Delete(path + "_extracted", true);
            }

            if (Directory.Exists(path + "_extracted_rfa"))
            {
                Directory.Delete(path + "_extracted_rfa", true);
            }

            if (Directory.Exists(path + "_corrected"))
            {
                Directory.Delete(path + "_corrected", true);
            }

            if (File.Exists(path + "_IncorrectFilesReport.txt"))
            {
                File.Delete(path + "_IncorrectFilesReport.txt");
            }

            if (File.Exists(path + "_rfa.zip"))
            {
                File.Delete(path + "_rfa.zip");
            }
        }

        /// <summary>
        /// Runs final preparations for analysis of files. Removes all new line characters and multiple whitespace characters.
        /// </summary>
        /// <param name="input">File content.</param>
        /// <returns>Clean file content.</returns>
        private string PrepareInputForAnalysis(string input)
        {
            string result;
            MatchEvaluator newLineMatchEvaluator = new MatchEvaluator(NewLineRemover);
            result = Regex.Replace(input, "\n", newLineMatchEvaluator, RegexOptions.Singleline);

            Regex regex = new Regex("[ ]{2,}", RegexOptions.None);
            result = regex.Replace(result, " ");
            result = result.Trim();

            return result;
        }

        /// <summary>
        /// Calculates hash of the file content.
        /// </summary>
        /// <param name="input">The file content.</param>
        /// <returns>Hash of the file content.</returns>
        private string CalculateHash(string input)
        {
            HashAlgorithm algorithm = SHA256.Create();
            StringBuilder hash = new StringBuilder();
            byte[] fileBytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            foreach (var fb in fileBytes)
            {
                hash.Append(fb.ToString("X2"));
            }

            return hash.ToString();
        }

        /// <summary>
        /// Removes all the unnecessary characters in files with the correct extensions.
        /// </summary>
        /// <param name="correctFiles">A collection containing file names with the correct extensions.</param>
        /// <param name="clearedFilesPath">The path where the files with the correct extensions are located.</param>
        /// <param name="taskFiles">A collection containing files of a given task.</param>
        /// <param name="task">The task for which the files were loaded.</param>
        /// <param name="author">The author of the correct files that are being processed.</param>
        public void ProcessCorrectFiles(List<string> correctFiles, string clearedFilesPath, List<FileEntry> taskFiles, Model.Models.Task task, string author)
        {
            foreach (var cf in correctFiles)
            {
                string path = clearedFilesPath + Path.GetFileName(cf);
                try
                {
                    File.Copy(cf, path);
                }
                catch (Exception ex)
                {
                    File.Copy(cf, path + "(1)");
                }

                string fileContent = File.ReadAllText(path);
                string hashBeforePreprocessing = CalculateHash(fileContent);
                long fileSize = new System.IO.FileInfo(path).Length;
                int noOfLines = File.ReadLines(cf).Count();
                string fileExtension = DetermineFileExtension(Path.GetExtension(Path.GetFileName(cf)));

                int noOfEmptyLines = Regex.Matches(fileContent, "\n\n").Count
                + Regex.Matches(fileContent, "\r\r").Count
                + Regex.Matches(fileContent, "\r\n\r\n").Count;

                noOfLineComments = 0;
                noOfBlockComments = 0;
                fileContent = RemoveComments(path, fileContent);
                fileContent = RemoveUnnecessaryCharsFromFile(fileContent);

                ILexicalAnalyzer lexAnalyzer = LexerFactory.GetLexicalAnalyzer(fileExtension);
                string fileContentAfterLexer = lexAnalyzer.Tokenize(fileContent);
                fileContent = PrepareInputForAnalysis(fileContent);
                fileContentAfterLexer = PrepareInputForAnalysis(fileContentAfterLexer);
                string hashAfterPreprocessing = CalculateHash(fileContent);

                taskFiles.Add(new FileEntry()
                {
                    FileName = Path.GetFileName(cf),
                    FileAuthor = author,
                    FileCheckSumBeforePreprocessing = hashBeforePreprocessing,
                    FileCheckSumAfterPreprocessing = hashAfterPreprocessing,
                    FileSize = fileSize,
                    FileNoOfLines = noOfLines,
                    FileNoOfEmptyLines = noOfEmptyLines,
                    FileNoOfLineComments = noOfLineComments,
                    FileNoOfBlockComments = noOfBlockComments,
                    FileContent = fileContent,
                    FileContentAfterLexAnalysis = fileContentAfterLexer,
                    FileExtension = fileExtension,
                    TaskId = task.Id
                });
            }
        }

        /// <summary>
        /// Generalizes the file extension based on that extension.
        /// Used primarily because of C++ and Python files since these files can have different extensions.
        /// </summary>
        /// <param name="extension">The extension of the file.</param>
        /// <returns>Generalized extension of the file.</returns>
        private string DetermineFileExtension(string extension)
        {
            List<string> cppExtensions = File.ReadAllLines(@"Resources\\cpp_extensions.txt").ToList();
            List<string> pyExtenions = File.ReadAllLines(@"Resources\\py_extensions.txt").ToList();

            if (cppExtensions.Contains(extension))
            {
                return ".cpp";
            }
            else if (pyExtenions.Contains(extension))
            {
                return ".py";
            }
            else
            {
                return extension;
            }
        }

        /// <summary>
        /// Creates a zip archive from corrected student archives.
        /// </summary>
        /// <param name="path">The path where the corrected files are located.</param>
        /// <param name="zipName">The name of the corrected zip archive which will be created.</param>
        public void CreateCorrectedZip(string path, string zipName)
        {
            string rootDirectory = Directory.GetParent(path).ToString();
            List<string> studentDirectories = Directory.GetDirectories(path).ToList();
            string destinationDirectory = rootDirectory + "\\" + zipName + "_corrected";

            foreach (var dir in studentDirectories)
            {
                string studentFolderName = new DirectoryInfo(dir).Name;
                string studentZipPath = destinationDirectory + "\\" + studentFolderName;
                Directory.CreateDirectory(studentZipPath);
                ZipFile.CreateFromDirectory(path + "\\" + studentFolderName, 
                    studentZipPath + "\\" + zipName + "_" + studentFolderName + ".zip");
            }

            ZipFile.CreateFromDirectory(destinationDirectory, rootDirectory + "\\" + zipName + "_rfa.zip");
        }

        /// <summary>
        /// Removes the unnecessary characters from the file content (multiple line breaks, tabs, multiple whitespaces).
        /// </summary>
        /// <param name="fileContent">The file content which is being cleared of the unnecessary characters.</param>
        /// <returns>The cleaned file content.</returns>
        private string RemoveUnnecessaryCharsFromFile(string fileContent)
        {
            fileContent = RemoveLineBreaks(fileContent);
            fileContent = RemoveTabs(fileContent);
            fileContent = RemoveMultipleWhitespaces(fileContent);
            fileContent = fileContent.Trim();

            return fileContent;
        }

        /// <summary>
        /// Removes comments from the file content.
        /// </summary>
        /// <param name="path">The path of the file for which the comments are being removed.</param>
        /// <param name="fileContent">The content of the file from which the comments are being removed.</param>
        /// <returns>The file content without the comments.</returns>
        private string RemoveComments(string path, string fileContent)
        {
            string extension = Path.GetExtension(path);

            List<string> commentExtensionRegexList = File.ReadAllLines(@"Resources\\comment_regex.txt").ToList();
            string commentRegex = commentExtensionRegexList
                .Where(l => l.StartsWith(extension))
                .FirstOrDefault()
                .Split('-')[1]
                .Trim();

            MatchEvaluator commentMatchEvaluator = new MatchEvaluator(CommentRemover);
            fileContent = Regex.Replace(fileContent, commentRegex, commentMatchEvaluator, RegexOptions.Multiline);
            return fileContent;
        }

        /// <summary>
        /// Removes multiple line breaks from the file content.
        /// </summary>
        /// <param name="fileContent">The content of the file from which the multiple line breaks are being removed.</param>
        /// <returns>The file content without the multiple line breaks.</returns>
        private string RemoveLineBreaks(string fileContent)
        {
            MatchEvaluator lineBreakMatchEvaluator = new MatchEvaluator(LineBreakRemover);
            fileContent = Regex.Replace(fileContent, @"[\r\n|\n|\r]+", lineBreakMatchEvaluator, RegexOptions.Singleline);
            return fileContent;
        }

        /// <summary>
        /// Removes tabs from the file content.
        /// </summary>
        /// <param name="fileContent">The content of the file from which the tabs are being removed.</param>
        /// <returns>The file content without the tabs.</returns>
        private string RemoveTabs(string fileContent)
        {
            MatchEvaluator tabMatchEvaluator = new MatchEvaluator(TabRemover);
            fileContent = Regex.Replace(fileContent, "\t", tabMatchEvaluator, RegexOptions.Singleline);
            return fileContent;
        }

        /// <summary>
        /// Removes multiple whitespaces from the file content.
        /// </summary>
        /// <param name="fileContent">The content of the file from which the multiple whitespaces are being removed.</param>
        /// <returns>The file content without the multiple whitespaces.</returns>
        private string RemoveMultipleWhitespaces(string fileContent)
        {
            Regex regex = new Regex("[ ]{2,}", RegexOptions.None);
            fileContent = regex.Replace(fileContent, "");
            return fileContent;
        }

        /// <summary>
        /// Regex matcher which removes comments.
        /// </summary>
        /// <param name="match">Matched substring of the file content.</param>
        /// <returns>The string that is used to replace the matched substring.</returns>
        private static string CommentRemover(Match match)
        {
            if (match.Value.StartsWith("//") || match.Value.StartsWith("#")) noOfLineComments++;
            if (match.Value.StartsWith("\"\"\"") || match.Value.StartsWith("/*")) noOfBlockComments++;
            return "";
        }

        /// <summary>
        /// Regex matcher which removes multiple line breaks.
        /// </summary>
        /// <param name="match">Matched substring of the file content.</param>
        /// <returns>The string that is used to replace the matched substring.</returns>
        private static string LineBreakRemover(Match match)
        {
            return "\n";
        }

        /// <summary>
        /// Regex matcher which removes tabs.
        /// </summary>
        /// <param name="match">Matched substring of the file content.</param>
        /// <returns>The string that is used to replace the matched substring.</returns>
        private static string TabRemover(Match match)
        {
            return "";
        }

        /// <summary>
        /// Regex matcher which removes new line characters.
        /// </summary>
        /// <param name="match">Matched substring of the file content.</param>
        /// <returns>The string that is used to replace the matched substring.</returns>
        private static string NewLineRemover(Match match)
        {
            return "";
        }

        /// <summary>
        /// Searches the directory recursively and determines correct files, incorrect files and subdirectories.
        /// </summary>
        /// <param name="rootDirectory">The root directory from which the recursive search starts.</param>
        /// <param name="allowedFileExtensions">A collection containing allowed file extensions.</param>
        /// <param name="ignoredFileExtensions">A collection containing ignored file extensions.</param>
        /// <param name="correctFiles">A collection containing file names with correct extensions.</param>
        /// <param name="incorrectFiles">A collection containing file names with incorrect extensions.</param>
        /// <param name="subdirectories">A collection containing subdirectory names.</param>
        public void DirectoryTreeSearch(string rootDirectory, List<string> allowedFileExtensions,
            List<string> ignoredFileExtensions, out List<string> correctFiles,
            out List<string> incorrectFiles, out List<string> subdirectories)
        {
            List<string> subdirs = Directory.GetDirectories(rootDirectory).ToList();
            List<string> files = Directory.GetFiles(rootDirectory, "*.*").ToList();
            correctFiles = new List<string>();
            incorrectFiles = new List<string>();
            subdirectories = new List<string>();

            if (subdirs.Count == 0)
            {
                foreach (var file in files)
                {
                    if (allowedFileExtensions.Contains(Path.GetExtension(file)))
                    {
                        correctFiles.Add(file);
                    }
                    else if (ignoredFileExtensions.Contains(Path.GetExtension(file)))
                    {
                        continue;
                    }
                    else
                    {
                        incorrectFiles.Add(file);
                    }
                }
                return;
            }

            foreach (var subdir in subdirs)
            {
                DirectoryTreeSearch(subdir, allowedFileExtensions, ignoredFileExtensions, 
                    out List<string> correctSubFiles, out List<string> incorrectSubFiles, out List<string> subSubdirectories);
                foreach (var file in correctSubFiles)
                {
                    correctFiles.Add(file);
                }
                foreach (var file in incorrectSubFiles)
                {
                    incorrectFiles.Add(file);
                }
                foreach (var dir in subSubdirectories)
                {
                    subdirectories.Add(dir);
                }
            }

            foreach (var file in files)
            {
                if (allowedFileExtensions.Contains(Path.GetExtension(file)))
                {
                    correctFiles.Add(file);
                }
                else
                {
                    incorrectFiles.Add(file);
                }
            }

            foreach (var dir in subdirs)
            {
                subdirectories.Add(dir);
            }

            return;
        }

        /// <summary>
        /// Extracts an archive with WinRAR.
        /// </summary>
        /// <param name="source">Path of the source archive.</param>
        /// <param name="destination">Path where the archive is being extracted.</param>
        public void ExtractWithWinRAR(string source, string destination)
        {
            Process p = new Process();
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.EnableRaisingEvents = false;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = File.ReadAllText(@"Resources\\path_to_extractor.txt");
            p.StartInfo.Arguments = string.Format(@"x -o+ ""{0}"" *.* ""{1}\""", source, destination);
            p.Start();
            p.WaitForExit();
        }

        /// <summary>
        /// Prepares the data for the Excel report.
        /// </summary>
        /// <param name="comparisonResults">A collection containing comparison results for the given task.</param>
        /// <param name="taskFiles">A collection containing files for the given task.</param>
        /// <returns>A 2-dimensional array containing the details of comparison results ready to be written to the Excel report.</returns>
        public string[,] PrepareResultsForExcel(List<ComparisonResult> comparisonResults, List<FileEntry> taskFiles)
        {
            var result = new string[comparisonResults.Count + 1, 8];

            result[0, 0] = "JMBAG1";
            result[0, 1] = "Datoteka1";
            result[0, 2] = "JMBAG2";
            result[0, 3] = "Datoteka2";
            result[0, 4] = "Ukupna sličnost";
            result[0, 5] = "Winnow sličnost";
            result[0, 6] = "Sličnost sažetaka";
            result[0, 7] = "Sličnost karakteristika";

            for (int i = 0; i < comparisonResults.Count; i++)
            {
                result[i + 1, 0] = comparisonResults[i].Jmbag1;
                result[i + 1, 1] = taskFiles.Where(f => f.Id == comparisonResults[i].File1Id).First().FileName;
                result[i + 1, 2] = comparisonResults[i].Jmbag2;
                result[i + 1, 3] = taskFiles.Where(f => f.Id == comparisonResults[i].File2Id).First().FileName;
                result[i + 1, 4] = String.Format("{0:0.00}", comparisonResults[i].Similarity) + "%";
                result[i + 1, 5] = String.Format("{0:0.00}", comparisonResults[i].WinnowingSimilarity) + "%";
                result[i + 1, 6] = String.Format("{0:0.00}", comparisonResults[i].CheckSumSimilarity) + "%";
                result[i + 1, 7] = String.Format("{0:0.00}", comparisonResults[i].PropertiesSimilarity) + "%";
            }

            return result;
        }
    }
}
