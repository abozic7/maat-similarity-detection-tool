using DIPL_Projekt.Controllers.Controllers;
using DIPL_Projekt.DAL;
using DIPL_Projekt.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DIPL_Projekt
{
    public partial class frmMainWindow : Form
    {
        private int similarityThreshold = 0;
        private int resultsPerPage = 50;
        private int page = 1;

        private readonly int kDefault = 3;
        private readonly int wDefault = 6;
        private readonly int winnowCoeffDefault = 1;
        private readonly int filePropsCoeffDefault = 1;
        private readonly bool checkSumDefault = true;

        TaskController _taskController;
        FileEntryController _fileEntryController;
        ComparisonResultController _comparisonResultController;
        DataProcessor _dataProcessor;
      
        List<ComparisonResult> comparisonResults = new List<ComparisonResult>();
        List<ComparisonResult> filteredResults = new List<ComparisonResult>();
        List<FileEntry> taskFiles = new List<FileEntry>();
        List<Task> tasks = new List<Task>();

        public frmMainWindow()
        {
            InitializeComponent();
            InitializeDataHandlers();
            AddCustomEventHandlers();
            InitializeHomeScreenComponents();
        }

        /// <summary>
        /// Initializes <see cref="DataProcessor"/> object and controllers.
        /// </summary>
        private void InitializeDataHandlers()
        {
            _taskController = new TaskController();
            _fileEntryController = new FileEntryController();
            _comparisonResultController = new ComparisonResultController();
            _dataProcessor = new DataProcessor(_fileEntryController, _taskController, _comparisonResultController);
        }

        /// <summary>
        /// Adds custom event handlers that should execute on cell click.
        /// </summary>
        private void AddCustomEventHandlers()
        {
            taskListGrid.CellClick += new DataGridViewCellEventHandler(TaskListGrid_CellClick);
            addFilesFileListGridView.CellClick += new DataGridViewCellEventHandler(AddFilesFileListGridView_CellClick);
            taskDetailsScanResultsGridView.CellClick += new DataGridViewCellEventHandler(TaskDetailsScanResultsGridView_CellClick);
        }

        /// <summary>
        /// Initializes a status strip, a threshold and a task list on the home screen.
        /// </summary>
        private void InitializeHomeScreenComponents()
        {
            tasks = _taskController
                .GetTasks()
                .OrderByDescending(t => t.TaskCreatedOn)
                .ToList();

            taskListStatusStripNoOfTasks.Text = taskListStatusStripNoOfTasks.Text.Split(':')[0].Trim() + ": " + tasks.Count;
            taskDetailsThresholdTxtBox.Text = similarityThreshold.ToString();
            ShowCurrentTasksPage();
        }

        /// <summary>
        /// Sets elements for Task Creation screen.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskListNewTaskBtn_Click(object sender, EventArgs e)
        {
            createTaskNameTxtBox.Text = "";
            createTaskDescTxtBox.Text = "";
            createTaskCourseTxtBox.Text = "";
            createTaskPanel.Visible = true;
        }

        /// <summary>
        /// Returns the user from comparison results list back to the task list (home screen).
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskDetailsReturnToTaskListBtn_Click(object sender, EventArgs e)
        {
            resultsPerPage = 50;
            taskListResultsPerPageComboBox.Text = resultsPerPage.ToString();
            page = 1;
            ShowCurrentTasksPage();
            taskDetailsPanel.Visible = false;
            taskDetailsStatusStripTaskName.Text = taskDetailsStatusStripTaskName.Text.Split(':')[0].Trim() + ":";
            taskDetailsStatusStripNoOfResults.Text = taskDetailsStatusStripNoOfResults.Text.Split(':')[0].Trim() + ":";
        }

        /// <summary>
        /// Handles cell clicks in the task list (table).
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = taskListGrid.Rows[e.RowIndex];
                Task task = _taskController
                    .GetTasks()
                    .Where(t => t.TaskName.Equals(row.Cells["TaskListTaskName"].Value.ToString()))
                    .FirstOrDefault();

                if (senderGrid.Columns[e.ColumnIndex].Name.Equals("TaskListTaskAddFile"))
                {
                    InitializeAddFilesScreen(task);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("TaskListAlgorithmParameters"))
                {
                    InitializeAlgorithmParametersAdjustmentScreen(task);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("TaskListTaskResults"))
                {
                    InitializeResultsScreen(task);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("TaskListDeleteTask"))
                {
                    DeleteTask(task, row);
                }
            }
        }

        /// <summary>
        /// Sets elements on the Add Files screen.
        /// </summary>
        /// <param name="task">The task for which the user will load files.</param>
        private void InitializeAddFilesScreen(Task task)
        {
            addFilesFileListGridView.Rows.Clear();
            addFilesStatusStripTaskName.Text = addFilesStatusStripTaskName.Text.Split(':')[0].Trim() + ": " + task.TaskName;
            taskFiles = _fileEntryController.GetFilesByTask(task.Id);
            addFilesStatusStripNoOfFiles.Text = addFilesStatusStripNoOfFiles.Text.Split(':')[0].Trim() + ": " + taskFiles.Count;
            resultsPerPage = 50;
            addFilesResultsPerPageComboBox.Text = resultsPerPage.ToString();
            ShowCurrentFilesPage();
            addFilesPanel.Visible = true;
        }

        /// <summary>
        /// Sets elements on the Algorithm Parameters Adjustment screen.
        /// </summary>
        /// <param name="task">The task for which the user will set algorithm parameters.</param>
        private void InitializeAlgorithmParametersAdjustmentScreen(Task task)
        {
            algorithmParameterAdjustmentTaskName.Text = algorithmParameterAdjustmentTaskName.Text.Split(':')[0].Trim() 
                + ": " + task.TaskName;
            algorithmParameterAdjustmentKGramLengthTxtBox.Text = task.KgramLength.ToString();
            algorithmParameterAdjustmentWindowSizeTxtBox.Text = task.WindowSize.ToString();
            algorithmParameterAdjustmentWinnowingComboBox.Text = task.Pwinnowing.ToString();
            algorithmParameterAdjustmentCheckSumCheckBox.Checked = task.CompareHashValues;
            algorithmParameterAdjustmentPropertiesComboBox.Text = task.Pproperties.ToString();
            algorithmParameterAdjustmentPanel.Visible = true;
        }

        /// <summary>
        /// Sets elements on the Algorithm Parameters Adjustment screen.
        /// </summary>
        /// <param name="task">The task for which the user will set algorithm parameters.</param>
        private void InitializeResultsScreen(Task task)
        {
            taskDetailsStatusStripTaskName.Text += " " + task.TaskName;
            page = 1;
            similarityThreshold = 0;
            taskDetailsThresholdTxtBox.Text = similarityThreshold.ToString();
            comparisonResults = _dataProcessor.CompareFiles(task);
            filteredResults = comparisonResults
                .Where(r => r.Similarity >= similarityThreshold)
                .ToList();

            resultsPerPage = 50;
            taskDetailsResultsPerPageComboBox.Text = resultsPerPage.ToString();
            ShowCurrentResultsPage();
            taskDetailsPanel.Visible = true;
        }

        /// <summary>
        /// Deletes a task in a given row.
        /// </summary>
        /// <param name="task">The task to be deleted.</param>
        /// <param name="row">The row where the task to be deleted is located.</param>
        private void DeleteTask(Task task, DataGridViewRow row)
        {
            _taskController.DeleteTask(task.Id);
            taskListGrid.Rows.Remove(row);
            task = tasks
                .Where(t => t.Id == task.Id)
                .ToList()
                .First();

            tasks.Remove(task);
            taskListStatusStripNoOfTasks.Text = taskListStatusStripNoOfTasks.Text.Split(':')[0].Trim() + ": " + tasks.Count;
            ShowCurrentTasksPage();
        }

        /// <summary>
        /// Creates a task based on set values and returns the user to the home screen.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void CreateTaskCreateTaskBtn_Click(object sender, EventArgs e)
        {
            if (tasks.Where(t => t.TaskName.Equals(createTaskNameTxtBox.Text)).ToList().Count == 0)
            {
                Task task = new Task()
                {
                    TaskName = createTaskNameTxtBox.Text,
                    TaskDesc = createTaskDescTxtBox.Text,
                    TaskCourse = createTaskCourseTxtBox.Text,
                    TaskCreatedOn = DateTime.Now,
                    WindowSize = 6,
                    KgramLength = 3,
                    Pproperties = 1,
                    Pwinnowing = 1,
                    CompareHashValues = false
                };
                _taskController.AddTask(task);
                tasks.Add(task);
                tasks = tasks.OrderByDescending(t => t.TaskCreatedOn).ToList();
                page = 1;
                taskListStatusStripNoOfTasks.Text = taskListStatusStripNoOfTasks.Text.Split(':')[0].Trim() + ": " + tasks.Count;
                ShowCurrentTasksPage();
                createTaskPanel.Visible = false;
            }
            else
            {
                MessageBox.Show($"Zadatak s nazivom {createTaskNameTxtBox.Text} već postoji. Odaberite drugi naziv zadatka.", 
                    "Poruka sustava Maat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cancels the task creation and returns the user to the home screen.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void CreateTaskCancelBtn_Click(object sender, EventArgs e)
        {
            createTaskPanel.Visible = false;
        }

        /// <summary>
        /// Saves the changed values of algorithm parameters and returns the user to the home screen.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AlgorithmParameterAdjustmentSaveBtn_Click(object sender, EventArgs e)
        {
            var tasks = _taskController.GetTasks();
            string taskName = algorithmParameterAdjustmentTaskName.Text
                .Split(':')[1]
                .Trim();
            Task task = tasks
                .Where(t => t.TaskName.Equals(taskName))
                .FirstOrDefault();

            int kgramLength = Int32.Parse(algorithmParameterAdjustmentKGramLengthTxtBox.Text);
            int windowSize = Int32.Parse(algorithmParameterAdjustmentWindowSizeTxtBox.Text);
            int pWinnow = Int32.Parse(algorithmParameterAdjustmentWinnowingComboBox.Text);
            int pProps = Int32.Parse(algorithmParameterAdjustmentPropertiesComboBox.Text);
            bool checkSumChecked = algorithmParameterAdjustmentCheckSumCheckBox.Checked;

            SetAlgorithmParameters(kgramLength, windowSize, out int k, out int w);
            SetAlgorithmCoeffs(pWinnow, pProps, checkSumChecked, out int winnowCoeff, out int propsCoeff, out bool checkSum);

            task.KgramLength = k;
            task.WindowSize = w;
            task.Pwinnowing = winnowCoeff;
            task.CompareHashValues = checkSum;
            task.Pproperties = propsCoeff;

            _taskController.UpdateTask(task);

            algorithmParameterAdjustmentPanel.Visible = false;
        }

        /// <summary>
        /// Corrects algorithm parameters if needed.
        /// </summary>
        /// <param name="kgramLength">User-adjusted k-gram length.</param>
        /// <param name="windowSize">User-adjusted window size.</param>
        /// <param name="k">Corrected k-gram length.</param>
        /// <param name="w">Corrected window size.</param>
        private void SetAlgorithmParameters(int kgramLength, int windowSize, out int k, out int w)
        {
            k = (kgramLength > 0) ? kgramLength : kDefault;
            w = (windowSize > 0) ? windowSize : wDefault;
        }

        /// <summary>
        /// Corrects algorithm coefficients if needed.
        /// </summary>
        /// <param name="pWinnow">User-adjusted Winnowing coefficient.</param>
        /// <param name="pProps">User-adjusted file properties algorithm coefficient.</param>
        /// <param name="checkSumChecked">User-adjusted CheckSum checkbox value that determines if CheckSum should be executed.</param>
        /// <param name="winnowCoeff">Corrected Winnowing coefficient.</param>
        /// <param name="propsCoeff">Corrected file properties algorithm coefficent.</param>
        /// <param name="checkSum">Corrected CheckSum algorithm boolean.</param>
        private void SetAlgorithmCoeffs(int pWinnow, int pProps, bool checkSumChecked, 
            out int winnowCoeff, out int propsCoeff, out bool checkSum)
        {
            bool noAlgorithmsUsed = (pWinnow == 0 && pProps == 0 && checkSumChecked == false);
            winnowCoeff = (noAlgorithmsUsed == false) ? pWinnow : winnowCoeffDefault;
            propsCoeff = (noAlgorithmsUsed == false) ? pProps : filePropsCoeffDefault;
            checkSum = (noAlgorithmsUsed == false) ? checkSumChecked : checkSumDefault;
        }

        /// <summary>
        /// Cancels the algorithm parameter adjustment and returns the user to the home screen.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AlgorithmParameterAdjustmentCancelBtn_Click(object sender, EventArgs e)
        {
            algorithmParameterAdjustmentPanel.Visible = false;
        }

        /// <summary>
        /// Handles cell clicks in the file list.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AddFilesFileListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow row = addFilesFileListGridView.Rows[e.RowIndex];
                string jmbag = row.Cells["AddFilesFileListJMBAG"].Value.ToString();
                string fileName = row.Cells["AddFilesFileListFile"].Value.ToString();
                var files = _fileEntryController
                    .GetFiles()
                    .Where(f => f.FileAuthor.Equals(jmbag) && f.FileName.Equals(fileName))
                    .ToList();

                if (files.Count != 0)
                {
                    _fileEntryController.DeleteFile(files.First().Id);
                }

                addFilesFileListGridView.Rows.Remove(row);
                var file = taskFiles
                    .Where(f => f.FileAuthor.Equals(jmbag) && f.FileName.Equals(fileName))
                    .ToList()
                    .First();
                taskFiles.Remove(file);

                addFilesStatusStripNoOfFiles.Text = addFilesStatusStripNoOfFiles.Text.Split(':')[0].Trim() + ": " + taskFiles.Count;
                ShowCurrentFilesPage();
            }
        }

        /// <summary>
        /// Saves added files for the given task and returns the user to the home screen.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AddFilesSaveBtn_Click(object sender, EventArgs e)
        {
            string taskName = addFilesStatusStripTaskName.Text.Split(':')[1].Trim();
            addFilesStatusStripTaskName.Text = addFilesStatusStripTaskName.Text.Split(':')[0].Trim() + ":";
            var tasks = _taskController.GetTasks();
            Task task = tasks
                .Where(t => t.TaskName.Equals(taskName))
                .FirstOrDefault();
            var files = _fileEntryController.GetFilesByTask(task.Id);

            foreach (var file in taskFiles)
            {
                var filteredFiles = files
                    .Where(f => f.FileAuthor.Equals(file.FileAuthor) && f.FileName.Equals(file.FileName))
                    .ToList();

                if (filteredFiles.Count == 0)
                {
                    _fileEntryController.AddFile(file);
                }
            }

            tasks = _taskController
                .GetTasks()
                .OrderByDescending(t => t.TaskCreatedOn)
                .ToList();

            page = 1;
            taskListStatusStripNoOfTasks.Text = taskListStatusStripNoOfTasks.Text.Split(':')[0].Trim() + ": " + tasks.Count;
            ShowCurrentTasksPage();
            addFilesPanel.Visible = false;
        }

        /// <summary>
        /// Cancels the saving of files and returns the user to the home screen.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AddFilesCancelBtn_Click(object sender, EventArgs e)
        {
            resultsPerPage = 50;
            taskListResultsPerPageComboBox.Text = resultsPerPage.ToString();
            page = 1;
            ShowCurrentTasksPage();
            addFilesPanel.Visible = false;
            addFilesStatusStripTaskName.Text = addFilesStatusStripTaskName.Text.Split(':')[0].Trim() + ":";
        }

        /// <summary>
        /// Grays out the Winnowing coefficient label if the coefficient value is null.
        /// This shows the user that the Winnow algorithm will not be in use.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AlgorithmParameterAdjustmentWinnowingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (algorithmParameterAdjustmentWinnowingComboBox.Text.Equals("0"))
            {
                algorithmParameterAdjustmentWinnowingLabel.ForeColor = SystemColors.ControlDark;
            }
            else
            {
                algorithmParameterAdjustmentWinnowingLabel.ForeColor = SystemColors.ControlText;
            }
        }

        /// <summary>
        /// Grays out the file properties algorithm coefficient label if the coefficient value is null.
        /// This shows the user that the file properties algorithm will not be in use.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AlgorithmParameterAdjustmentCharacteristicsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (algorithmParameterAdjustmentPropertiesComboBox.Text.Equals("0"))
            {
                algorithmParameterAdjustmentPropertiesLabel.ForeColor = SystemColors.ControlDark;
            }
            else
            {
                algorithmParameterAdjustmentPropertiesLabel.ForeColor = SystemColors.ControlText;
            }
        }

        /// <summary>
        /// Opens the file explorer for the user to choose a zip archive.
        /// When the user chooses a zip archive, all of the files in this archive are being preprocessed.
        /// This method also corrects the input and generates the incorrect files report.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AddFilesAddManyAuthorsArchivesBtn_Click(object sender, EventArgs e)
        {
            string taskName = addFilesStatusStripTaskName.Text.Split(':')[1].Trim();
            var tasks = _taskController.GetTasks();
            Task task = tasks.Where(t => t.TaskName.Equals(taskName)).FirstOrDefault();
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "zip files (*.zip)|*.zip";
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> allowedFileExtensions = File.ReadAllLines(@"Resources\\allowed_file_extensions.txt").ToList();
                    List<string> ignoredFileExtensions = File.ReadAllLines(@"Resources\\ignored_file_extensions.txt").ToList();
                    string selectedFilePath = fileDialog.FileName;
                    _dataProcessor.DeleteIfPreviouslyExtracted(selectedFilePath);
                    string selectedDirectory = Path.GetDirectoryName(selectedFilePath);
                    string rootZipName = Path.GetFileNameWithoutExtension(selectedFilePath);
                    string reportFilePath = selectedDirectory + "\\" + rootZipName + "_IncorrectFilesReport.txt";
                    File.Create(reportFilePath).Dispose();
                    selectedDirectory += "\\" + rootZipName + "_extracted";

                    ZipFile.ExtractToDirectory(selectedFilePath, selectedDirectory);
                    List<string> studentDirectories = Directory.GetDirectories(selectedDirectory).ToList();
                    using (StreamWriter sw = new StreamWriter(reportFilePath))
                    {
                        foreach (var studentPath in studentDirectories)
                        {
                            string dirName = new DirectoryInfo(studentPath).Name;
                            string studentZip = Directory.GetFiles(studentPath, "*.zip").FirstOrDefault();
                            if (studentZip == null)
                            {
                                try
                                {
                                    ExtractAuthorsRarArchive(sw, studentPath, dirName);
                                }
                                catch (Exception ex)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                ExtractAuthorsZipArchive(studentZip, studentPath);
                            }

                            _dataProcessor.DirectoryTreeSearch(studentPath, allowedFileExtensions, ignoredFileExtensions, 
                                out List<string> correctFiles, out List<string> incorrectFiles, out List<string> subdirectories);

                            if (incorrectFiles.Count != 0 || subdirectories.Count != 0)
                            {
                                sw.WriteLine(dirName);

                                foreach (var file in incorrectFiles)
                                {
                                    sw.WriteLine($"{file} - predana datoteka s krivom ekstenzijom ({Path.GetExtension(file)})");
                                }

                                foreach (var dir in subdirectories)
                                {
                                    sw.WriteLine($"{dir} - predan direktorij");
                                }

                                sw.WriteLine();
                            }

                            string clearedFilesPath = Path.GetDirectoryName(selectedFilePath) + "\\" + rootZipName 
                                + "_extracted_rfa\\" + dirName + "\\";
                            Directory.CreateDirectory(clearedFilesPath);
                            _dataProcessor.ProcessCorrectFiles(correctFiles, clearedFilesPath, taskFiles, task, dirName);
                        }
                    }
                    var correctedFilesPath = Path.GetDirectoryName(selectedFilePath) + "\\" + rootZipName + "_extracted_rfa";
                    _dataProcessor.CreateCorrectedZip(correctedFilesPath, rootZipName);

                    page = 1;
                    ShowCurrentFilesPage();
                    addFilesStatusStripNoOfFiles.Text = addFilesStatusStripNoOfFiles.Text.Split(':')[0].Trim() + ": " + taskFiles.Count;
                }
            }
        }

        /// <summary>
        /// Extracts a zip archive using either the <see cref="ZipFile"/> class or WinRAR.
        /// After extracting, this method deletes the zip archive.
        /// </summary>
        /// <param name="studentZip">The zip archive that needs to be extracted.</param>
        /// <param name="studentArchivePath">The path to a directory where the zip archive is extracted.</param>
        private void ExtractAuthorsZipArchive(string studentZip, string studentArchivePath)
        {
            try
            {
                ZipFile.ExtractToDirectory(studentZip, studentArchivePath);
            }
            catch (Exception ex)
            {
                _dataProcessor.ExtractWithWinRAR(studentZip, studentArchivePath);
            }
            File.Delete(studentZip);
        }

        /// <summary>
        /// Extracts a rar archive using WinRAR. After extracting, this method deletes the rar archive.
        /// </summary>
        /// <param name="sw">A <see cref="StreamWriter" /> used to write to incorrect files report.</param>
        /// <param name="studentArchivePath">The path where the rar archive is located.</param>
        /// <param name="directoryName">The path to a directory where the rar archive is extracted.</param>
        private void ExtractAuthorsRarArchive(StreamWriter sw, string studentArchivePath, string directoryName)
        {
            string studentRar = Directory.GetFiles(studentArchivePath, "*.rar").FirstOrDefault();
            if (studentRar != null)
            {
                _dataProcessor.ExtractWithWinRAR(studentRar, studentArchivePath);
                sw.WriteLine(directoryName + " - " + "predan je .rar\n");
                File.Delete(studentRar);
            }
            else
            {
                sw.WriteLine(directoryName + " - " + "student nije predao .rar ni .zip arhivu\n");
            }
        }

        /// <summary>
        /// Enables/disables paging buttons based on the current page, the number of entries and the number of results per page.
        /// </summary>
        /// <param name="noOfEntries">The number of entries that will be shown in the list (table).</param>
        /// <param name="firstBtn">The "first" button in the paging section.</param>
        /// <param name="previousBtn">The "previous" button in the paging section.</param>
        /// <param name="nextBtn">The "next" button in the paging section.</param>
        /// <param name="lastBtn">The "last" button in the paging section.</param>
        private void SetPagingButtonsStatus(int noOfEntries, Button firstBtn, Button previousBtn, Button nextBtn, Button lastBtn)
        {
            if (noOfEntries == 0)
            {
                firstBtn.Enabled = false;
                previousBtn.Enabled = false;
                nextBtn.Enabled = false;
                lastBtn.Enabled = false;
            }
            else if (page == 1 && page != (int)Math.Ceiling((double)noOfEntries / resultsPerPage))
            {
                firstBtn.Enabled = false;
                previousBtn.Enabled = false;
                nextBtn.Enabled = true;
                lastBtn.Enabled = true;
            }
            else if (page != 1 && page == (int)Math.Ceiling((double)noOfEntries / resultsPerPage))
            {
                firstBtn.Enabled = true;
                previousBtn.Enabled = true;
                nextBtn.Enabled = false;
                lastBtn.Enabled = false;

            }
            else if (page == 1 && page == (int)Math.Ceiling((double)noOfEntries / resultsPerPage))
            {
                firstBtn.Enabled = false;
                previousBtn.Enabled = false;
                nextBtn.Enabled = false;
                lastBtn.Enabled = false;
            }
            else
            {
                firstBtn.Enabled = true;
                previousBtn.Enabled = true;
                nextBtn.Enabled = true;
                lastBtn.Enabled = true;
            }
        }

        /// <summary>
        /// Sets the page information based on the current page, the number of entries and the number of results per page.
        /// </summary>
        /// <param name="noOfEntries">The number of entries that will be shown in the list (table).</param>
        /// <param name="statusStripPageInfo">The status strip page information label.</param>
        private void SetPageInfo(int noOfEntries, ToolStripStatusLabel statusStripPageInfo)
        {
            if (noOfEntries == 0)
            {
                statusStripPageInfo.Text = statusStripPageInfo.Text.Split(':')[0].Trim() + ": " + page + "/1";
            }
            else
            {
                statusStripPageInfo.Text = statusStripPageInfo.Text.Split(':')[0].Trim() + ": " + page + "/" 
                    + (int)Math.Ceiling((double)noOfEntries / resultsPerPage);
            }
        }

        /// <summary>
        /// Adds comparison results to the current page of the list (table) in the Comparison Results screen.
        /// </summary>
        private void ShowCurrentResultsPage()
        {
            SetPagingButtonsStatus(filteredResults.Count, taskDetailsFirstPageBtn, taskDetailsPreviousPageBtn,
                taskDetailsNextPageBtn, taskDetailsLastPageBtn);

            taskDetailsScanResultsGridView.Rows.Clear();
            taskDetailsStatusStripNoOfResults.Text = taskDetailsStatusStripNoOfResults.Text.Split(':')[0].Trim() 
                + ": " + filteredResults.Count;
            
            for (int i = (page - 1) * resultsPerPage; i < filteredResults.Count && i < page * resultsPerPage; i++)
            {
                taskDetailsScanResultsGridView.Rows
                    .Add(
                    filteredResults[i].Jmbag1,
                    _fileEntryController.GetFile(filteredResults[i].File1Id).FileName,
                    filteredResults[i].Jmbag2,
                    _fileEntryController.GetFile(filteredResults[i].File2Id).FileName, 
                    String.Format("{0:0.00}", filteredResults[i].Similarity) + "%"
                    );
            }

            SetPageInfo(filteredResults.Count, taskDetailsStatusStripPageInfo);
        }

        /// <summary>
        /// Sets the current page to the first page and displays comparison results for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskDetailsFirstPageBtn_Click(object sender, EventArgs e)
        {
            page = 1;
            ShowCurrentResultsPage();
        }

        /// <summary>
        /// Sets the current page to the previous page and displays comparison results for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskDetailsPreviousPageBtn_Click(object sender, EventArgs e)
        {
            page--;
            ShowCurrentResultsPage();
        }

        /// <summary>
        /// Sets the current page to the next page and displays comparison results for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskDetailsNextPageBtn_Click(object sender, EventArgs e)
        {
            page++;
            ShowCurrentResultsPage();
        }

        /// <summary>
        /// Sets the current page to the last page and displays comparison results for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskDetailsLastPageBtn_Click(object sender, EventArgs e)
        {
            page = (int)Math.Ceiling((double)filteredResults.Count / resultsPerPage);
            ShowCurrentResultsPage();
        }

        /// <summary>
        /// Adds files to the current page of the list (table) in the Add Files screen.
        /// </summary>
        private void ShowCurrentFilesPage()
        {
            SetPagingButtonsStatus(taskFiles.Count, addFilesFirstPageBtn, addFilesPreviousPageBtn,
                addFilesNextPageBtn, addFilesLastPageBtn);

            addFilesFileListGridView.Rows.Clear();
            for (int i = (page - 1) * resultsPerPage; i < taskFiles.Count && i < page * resultsPerPage; i++)
            {
                addFilesFileListGridView.Rows
                    .Add(
                    taskFiles[i].FileAuthor,
                    taskFiles[i].FileName,
                    taskFiles[i].FileCheckSumBeforePreprocessing, 
                    taskFiles[i].FileCheckSumAfterPreprocessing,
                    taskFiles[i].FileSize,
                    taskFiles[i].FileContent
                    );
            }

            SetPageInfo(taskFiles.Count, addFilesStatusStripPageInfo);
        }

        /// <summary>
        /// Sets the current page to the first page and displays files for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AddFilesFirstPageBtn_Click(object sender, EventArgs e)
        {
            page = 1;
            ShowCurrentFilesPage();
        }

        /// <summary>
        /// Sets the current page to the previous page and displays files for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AddFilesPreviousPageBtn_Click(object sender, EventArgs e)
        {
            page--;
            ShowCurrentFilesPage();
        }

        /// <summary>
        /// Sets the current page to the next page and displays files for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AddFilesNextPageBtn_Click(object sender, EventArgs e)
        {
            page++;
            ShowCurrentFilesPage();
        }

        /// <summary>
        /// Sets the current page to the last page and displays files for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AddFilesLastPageBtn_Click(object sender, EventArgs e)
        {
            page = (int)Math.Ceiling((double)taskFiles.Count / resultsPerPage);
            ShowCurrentFilesPage();
        }

        /// <summary>
        /// Adds tasks to the current page of the list (table) in the home screen.
        /// </summary>
        private void ShowCurrentTasksPage()
        {
            SetPagingButtonsStatus(tasks.Count, taskListFirstPageBtn, taskListPreviousPageBtn,
                taskListNextPageBtn, taskListLastPageBtn);

            taskListGrid.Rows.Clear();
            for (int i = (page - 1) * resultsPerPage; i < tasks.Count && i < page * resultsPerPage; i++)
            {
                taskListGrid.Rows
                    .Add(
                    tasks[i].TaskName, 
                    tasks[i].TaskCourse, 
                    tasks[i].TaskDesc, 
                    tasks[i].TaskCreatedOn,
                    _fileEntryController.GetFilesByTask(tasks[i].Id).Select(f => f.FileAuthor).Distinct().ToList().Count,
                    _fileEntryController.GetFilesByTask(tasks[i].Id).Count
                    );
            }

            SetPageInfo(tasks.Count, taskListStatusStripPageInfo);
        }

        /// <summary>
        /// Sets the current page to the first page and displays tasks for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskListFirstPageBtn_Click(object sender, EventArgs e)
        {
            page = 1;
            ShowCurrentTasksPage();
        }

        /// <summary>
        /// Sets the current page to the previous page and displays tasks for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskListPreviousPageBtn_Click(object sender, EventArgs e)
        {
            page--;
            ShowCurrentTasksPage();
        }

        /// <summary>
        /// Sets the current page to the next page and displays tasks for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskListNextPageBtn_Click(object sender, EventArgs e)
        {
            page++;
            ShowCurrentTasksPage();
        }

        /// <summary>
        /// Sets the current page to the last page and displays tasks for that page.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskListLastPageBtn_Click(object sender, EventArgs e)
        {
            page = (int)Math.Ceiling((double)tasks.Count / resultsPerPage);
            ShowCurrentTasksPage();
        }

        /// <summary>
        /// Changes the number of results per page for files list and adjusts the entries in the said list.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void AddFilesResultsPerPageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultsPerPage = Int32.Parse(addFilesResultsPerPageComboBox.Text);
            ShowCurrentFilesPage();
        }

        /// <summary>
        /// Changes the number of results per page for task list and adjusts the entries in the said list.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskListResultsPerPageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultsPerPage = Int32.Parse(taskListResultsPerPageComboBox.Text);
            ShowCurrentTasksPage();
        }

        /// <summary>
        /// Changes the number of results per page for comparison results list and adjusts the entries in the said list.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskDetailsResultsPerPageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultsPerPage = Int32.Parse(taskDetailsResultsPerPageComboBox.Text);
            ShowCurrentResultsPage();
        }

        /// <summary>
        /// Changes comparison results' threshold.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void TaskDetailsThresholdTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                similarityThreshold = Int32.Parse(taskDetailsThresholdTxtBox.Text);
            }
            catch(Exception)
            {
                similarityThreshold = 0;
            }

            string taskName = taskDetailsStatusStripTaskName.Text.Split(':')[1].Trim();
            var tasks = _taskController.GetTasks();

            Task task = tasks
                .Where(t => t.TaskName.Equals(taskName))
                .FirstOrDefault();
            filteredResults = comparisonResults
                .Where(r => r.Similarity >= similarityThreshold)
                .ToList();

            page = 1;
            ShowCurrentResultsPage();
        }

        /// <summary>
        /// Handles cell clicks in the comparison results list.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        public void TaskDetailsScanResultsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string taskName = taskDetailsStatusStripTaskName.Text.Split(':')[1].Trim();
            Task task = tasks
                .Where(t => t.TaskName.Equals(taskName))
                .FirstOrDefault();

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = taskDetailsScanResultsGridView.Rows[e.RowIndex];
                string file1Name = row.Cells[ScanResultsFile1.Index].Value.ToString();
                string file1Author = row.Cells[ScanResultsJMBAG1.Index].Value.ToString();
                string file2Name = row.Cells[ScanResultsFile2.Index].Value.ToString();
                string file2Author = row.Cells[ScanResultsJMBAG2.Index].Value.ToString();

                FileEntry file1 = _fileEntryController
                    .GetFilesByTask(task.Id)
                    .Where(f => f.FileAuthor.Equals(file1Author) && f.FileName.Equals(file1Name))
                    .FirstOrDefault();
                FileEntry file2 = _fileEntryController
                    .GetFilesByTask(task.Id)
                    .Where(f => f.FileAuthor.Equals(file2Author) && f.FileName.Equals(file2Name))
                    .FirstOrDefault();

                ComparisonResult comparisonResult = _comparisonResultController
                    .GetComparisonResultsByTask(task.Id)
                    .Where(r => 
                        (r.Jmbag1.Equals(file1Author) && r.Jmbag2.Equals(file2Author) 
                        && r.File1Id == file1.Id && r.File2Id == file2.Id)
                    )
                    .FirstOrDefault();

                if (senderGrid.Columns[e.ColumnIndex].Name.Equals("ScanResultsViewDetails"))
                {
                    SetComparisonResultInfo(file1, file2, comparisonResult);
                    taskDetailsPanel.Visible = false;
                    similarFilesComparisonPanel.Visible = true;
                }
            }
        }

        /// <summary>
        /// Sets the comparison result details information.
        /// </summary>
        /// <param name="file1">The first file in the comparison result.</param>
        /// <param name="file2">The second file in the comparison result.</param>
        /// <param name="comparisonResult">The comparison result for which the details are shown.</param>
        private void SetComparisonResultInfo(FileEntry file1, FileEntry file2, ComparisonResult comparisonResult)
        {
            similarFilesComparisonFileAuthor1TxtBox.Text = file1.FileAuthor;
            similarFilesComparisonFileName1TxtBox.Text = file1.FileName;
            similarFilesComparisonFileSize1TxtBox.Text = file1.FileSize + " B";
            similarFilesComparisonNoOfLines1TxtBox.Text = file1.FileNoOfLines.ToString();
            similarFilesComparisonNoOfEmptyLines1TxtBox.Text = file1.FileNoOfEmptyLines.ToString();
            similarFilesComparisonNoOfLineComments1TxtBox.Text = file1.FileNoOfLineComments.ToString();
            similarFilesComparisonNoOfBlockComments1TxtBox.Text = file1.FileNoOfBlockComments.ToString();
            similarFilesComparisonHashBeforePreprocessing1TxtBox.Text = file1.FileCheckSumBeforePreprocessing;
            similarFilesComparisonHashAfterPreprocessing1TxtBox.Text = file1.FileCheckSumAfterPreprocessing;

            similarFilesComparisonFileAuthor2TxtBox.Text = file2.FileAuthor;
            similarFilesComparisonFileName2TxtBox.Text = file2.FileName;
            similarFilesComparisonFileSize2TxtBox.Text = file2.FileSize + " B";
            similarFilesComparisonNoOfLines2TxtBox.Text = file2.FileNoOfLines.ToString();
            similarFilesComparisonNoOfEmptyLines2TxtBox.Text = file2.FileNoOfEmptyLines.ToString();
            similarFilesComparisonNoOfLineComments2TxtBox.Text = file2.FileNoOfLineComments.ToString();
            similarFilesComparisonNoOfBlockComments2TxtBox.Text = file2.FileNoOfBlockComments.ToString();
            similarFilesComparisonHashBeforePreprocessing2TxtBox.Text = file2.FileCheckSumBeforePreprocessing;
            similarFilesComparisonHashAfterPreprocessing2TxtBox.Text = file2.FileCheckSumAfterPreprocessing;

            similarFilesComparisonWinnowingResultsTxtBox.Text = comparisonResult.WinnowingSimilarity + "%";
            similarFilesComparisonPropertiesResultsTxtBox.Text = comparisonResult.PropertiesSimilarity + "%";
            similarFilesComparisonCheckSumResultsTxtBox.Text = comparisonResult.CheckSumSimilarity + "%";
            similarFilesComparisonSimilarityTxtBox.Text = comparisonResult.Similarity + "%";
        }

        /// <summary>
        /// Handles window resizing.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void resize1Func(object sender, EventArgs e)
        {
            if (similarFilesComparisonPanel.Visible)
            {
                similarFilesComparisonFileInfo1Panel.Width = similarFilesComparisonResultsPanel.Width / 2;
            }
        }

        /// <summary>
        /// Finishes the overview of a comparison result and returns the user back to the home screen.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void similarFilesComparisonFinishOverviewBtn_Click(object sender, EventArgs e)
        {
            similarFilesComparisonPanel.Visible = false;
            taskDetailsPanel.Visible = true;
        }

        /// <summary>
        /// Generates the Excel report with comparison results and their details for the given task.
        /// </summary>
        /// <param name="sender">The object that invoked the event causing the event handler to be triggered.</param>
        /// <param name="e">Event arguments.</param>
        private void taskDetailsGenerateExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                var taskName = taskDetailsStatusStripTaskName.Text.Split(':')[1].Trim();
                var files = _fileEntryController
                    .GetFilesByTask(
                    _taskController.GetTasks().Where(t => t.TaskName.Equals(taskName))
                    .First()
                    .Id
                    );
                var data = _dataProcessor.PrepareResultsForExcel(comparisonResults, files);

                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;

                var workbook = excelApp.Workbooks.Add("");
                var sheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;

                sheet.get_Range("A1", "H1").Font.Bold = true;
                sheet.get_Range("A1", "H1").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                var range = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[1, 1];
                range = range.get_Resize(data.GetLength(0), data.GetLength(1));
                range.set_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault, data);

                sheet.get_Range("A1", "H1").EntireColumn.AutoFit();
                excelApp.UserControl = false;

                var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                workbook.SaveAs(documentsPath + "\\Maat_" + taskName + "_rezultati_usporedbe.xlsx", 
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                workbook.Close();
                excelApp.Quit();
                MessageBox.Show("Izvještaj je uspješno stvoren na lokaciji 'Dokumenti'!", "Poruka sustava Maat", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške, pokušajte ponovno!", "Poruka sustava Maat", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
