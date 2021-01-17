using DIPL_Projekt.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPL_Projekt.LexicalAnalyzers
{
    public interface ILexicalAnalyzer
    {
        /// <summary>
        /// Recognizes identifiers in a file content and replaces them with "ID".
        /// </summary>
        /// <param name="fileContent">Content of the file to be tokenized.</param>
        /// <returns>File content with changed identifiers.</returns>
        string Tokenize(string fileContent);
    }
}
