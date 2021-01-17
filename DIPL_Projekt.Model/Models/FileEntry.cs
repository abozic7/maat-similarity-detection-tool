using System;
using System.Collections.Generic;

namespace DIPL_Projekt.Model.Models
{
    public partial class FileEntry
    {
        public FileEntry()
        {
            ComparisonResultFile1 = new HashSet<ComparisonResult>();
            ComparisonResultFile2 = new HashSet<ComparisonResult>();
        }

        public int Id { get; set; }
        public int TaskId { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public decimal FileSize { get; set; }
        public int FileNoOfLines { get; set; }
        public int FileNoOfLineComments { get; set; }
        public int FileNoOfBlockComments { get; set; }
        public int FileNoOfEmptyLines { get; set; }
        public string FileAuthor { get; set; }
        public string FileContent { get; set; }
        public string FileContentAfterLexAnalysis { get; set; }
        public string FileCheckSumBeforePreprocessing { get; set; }
        public string FileCheckSumAfterPreprocessing { get; set; }

        public virtual Task Task { get; set; }
        public virtual ICollection<ComparisonResult> ComparisonResultFile1 { get; set; }
        public virtual ICollection<ComparisonResult> ComparisonResultFile2 { get; set; }
    }
}
