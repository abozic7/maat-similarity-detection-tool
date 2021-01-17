using Antlr4.Runtime;
using DIPL_Projekt.Algorithms.LexicalAnalyzers.GeneratedLexers;
using DIPL_Projekt.BaseLib.Controllers;
using DIPL_Projekt.Controllers.Controllers;
using DIPL_Projekt.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DIPL_Projekt.LexicalAnalyzers
{
    /// <summary>
    /// Class that performs lexical analysis for files written in C.
    /// </summary>
    public class CLexicalAnalyzer : ILexicalAnalyzer
    {
        private static IFileEntryController _fileEntryController;

        public CLexicalAnalyzer()
        {
            _fileEntryController = new FileEntryController();
        }

        public string Tokenize(string fileContent)
        {
            AntlrInputStream inputStream = new AntlrInputStream(fileContent);
            CLexer lexer = new CLexer(inputStream);
            Antlr4.Runtime.CommonTokenStream tokenStream = new Antlr4.Runtime.CommonTokenStream(lexer);
            tokenStream.Fill();
            string result = "";

            IList<Antlr4.Runtime.IToken> tokens = tokenStream.GetTokens();
            foreach (var token in tokens)
            {
                result += (token.Type == CLexer.Identifier) ? "ID" : token.Text;
            }

            result = result.Replace("<EOF>", "");
            return result;
        }
    }
}
