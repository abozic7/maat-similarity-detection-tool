using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Antlr.Runtime;
using Antlr4.Runtime;
using DIPL_Projekt.Algorithms.LexicalAnalyzers.GeneratedLexers;
using DIPL_Projekt.BaseLib.Controllers;
using DIPL_Projekt.Controllers.Controllers;
using DIPL_Projekt.Model.Models;

namespace DIPL_Projekt.LexicalAnalyzers
{
    /// <summary>
    /// Class that performs lexical analysis for files written in Java.
    /// </summary>
    public class JavaLexicalAnalyzer : ILexicalAnalyzer
    {
        private static IFileEntryController _fileEntryController;

        public JavaLexicalAnalyzer()
        {
            _fileEntryController = new FileEntryController();
        }

        public string Tokenize(string fileContent)
        {
            AntlrInputStream inputStream = new AntlrInputStream(fileContent);
            Java8Lexer lexer = new Java8Lexer(inputStream);
            Antlr4.Runtime.CommonTokenStream tokenStream = new Antlr4.Runtime.CommonTokenStream(lexer);
            tokenStream.Fill();
            string result = "";

            IList<Antlr4.Runtime.IToken> tokens = tokenStream.GetTokens();
            foreach (var token in tokens)
            {
                result += (token.Type == Java8Lexer.Identifier) ? "ID" : token.Text;
            }

            result = result.Replace("<EOF>", "");
            return result;
        }
    }
}
