using System;
using System.Collections.Generic;

namespace DIPL_Projekt.Model.Models
{
    public partial class Task
    {
        public Task()
        {
            ComparisonResult = new HashSet<ComparisonResult>();
            FileEntry = new HashSet<FileEntry>();
        }

        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDesc { get; set; }
        public string TaskCourse { get; set; }
        public DateTime TaskCreatedOn { get; set; }
        public int KgramLength { get; set; }
        public int WindowSize { get; set; }
        public int Pwinnowing { get; set; }
        public bool CompareHashValues { get; set; }
        public int Pproperties { get; set; }

        public virtual ICollection<ComparisonResult> ComparisonResult { get; set; }
        public virtual ICollection<FileEntry> FileEntry { get; set; }
    }
}
