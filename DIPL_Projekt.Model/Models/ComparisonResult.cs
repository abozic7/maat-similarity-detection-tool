using System;
using System.Collections.Generic;

namespace DIPL_Projekt.Model.Models
{
    public partial class ComparisonResult
    {
        public int TaskId { get; set; }
        public string Jmbag1 { get; set; }
        public string Jmbag2 { get; set; }
        public int File1Id { get; set; }
        public int File2Id { get; set; }
        public double Similarity { get; set; }
        public double WinnowingSimilarity { get; set; }
        public double CheckSumSimilarity { get; set; }
        public double PropertiesSimilarity { get; set; }

        public virtual FileEntry File1 { get; set; }
        public virtual FileEntry File2 { get; set; }
        public virtual Task Task { get; set; }
    }
}
