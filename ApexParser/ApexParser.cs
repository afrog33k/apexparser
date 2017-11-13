﻿using ApexParser.MetaClass;
using ApexParser.Parser;
using ApexParser.Toolbox;
using ApexParser.Visitors;

namespace ApexParser
{
    public class ApexParser
    {
        private static ApexGrammar ApexGrammar { get; } = new ApexGrammar();

        // Convert Apex Code to C#
        public static string ConvertApexToCSharp(string apexCode, string @namespace = null)
        {
            return GetApexAst(apexCode).ToCSharp(@namespace: @namespace);
        }

        // Get the AST for a given APEX File
        public static MemberDeclarationSyntax GetApexAst(string apexCode)
        {
            return ApexGrammar.CompilationUnit.ParseEx(apexCode);
        }

        // Convert a given Apex Ast to C#
        public static string ConvertApexAstToCSharp(MemberDeclarationSyntax astSyntax, string @namespace = null)
        {
            return astSyntax.ToCSharp(@namespace: @namespace);
        }

        // Format APEX Code so each statement is in its own line
        public static string FormatApex(string apexCode)
        {
            return GetApexAst(apexCode).ToApex(tabSize: 0);
        }

        // Indent APEX code, Pass the Tab Size. If Tab size is set to 0, no indentions
        public static string IndentApex(string apexCode, int tabSize = 4)
        {
            return GetApexAst(apexCode).ToApex(tabSize);
        }
    }
}
