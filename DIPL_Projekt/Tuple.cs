using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPL_Projekt
{
    /// <summary>
    /// A pair of distinctor and its counter.
    /// Used to count a number of files for each author, where the author is a distinctor and the number of files is a counter.
    /// </summary>
    public class Tuple
    {
        public string Distinctor { get; set; }
        public int Counter { get; set; }
    }
}
