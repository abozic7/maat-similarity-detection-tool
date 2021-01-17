using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPL_Projekt.LexicalAnalyzers
{
    /// <summary>
    /// Class that creates an instance of a lexical analyzer.
    /// </summary>
    public class LexerFactory
    {
        /// <summary>
        /// Creates an instance of a lexical analyzer based on a file extension.
        /// </summary>
        /// <param name="fileExtension">Extension of a file.</param>
        /// <returns>Lexical analyzer object.</returns>
        public static ILexicalAnalyzer GetLexicalAnalyzer(string fileExtension) 
        {
            ILexicalAnalyzer analyzer = null;
            switch (fileExtension)
            {
                case ".c":
                    analyzer = new CPPLexicalAnalyzer();
                    break;
                case ".cpp":
                    analyzer = new CPPLexicalAnalyzer();
                    break;
                case ".java":
                    analyzer = new JavaLexicalAnalyzer();
                    break;
                case ".cs":
                    analyzer = new CSharpLexicalAnalyzer();
                    break;
                case ".py":
                    analyzer = new PythonLexicalAnalyzer();
                    break;
            }

            return analyzer;
        }
    }
}
