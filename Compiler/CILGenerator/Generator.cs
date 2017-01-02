using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CompilerConsole.Parser;
using CompilerConsole.Parser.Nodes.BodyNodes;

namespace CompilerConsole.CILGenerator
{
    enum Template {
        ClassDecl,
        DeclFuncFinich,
        DeclMainFunc,
        StartFuncDecl,
        StartProgram,
        LocalvariableDeclaration,
        /// <summary>
        /// Содержит триггер {type} - тип данных, который нужно вывести
        /// </summary>
        ConsoleWriteLine
    }

    public enum CILToken
    {
        Method,

    }

    public enum CILReplacedToken
    {
        MethodName,
        MethodArgs,
        Variables,
        ClassBody
    }


    public partial class Generator {

        private Dictionary<Template, string> templatesDictionary;
        private Dictionary<CILReplacedToken, string> cilReplacedToken;

        private StringBuilder cilCode { get; set; }

        public Generator() {
            this.cilCode = new StringBuilder();
            this.InitializeTemplates();
        }

        public void Generate(Parser.Parser parser)
        {
            this.cilCode.Append(this.Reader(Template.StartProgram));
            this.cilCode.AppendLine();
            string classDecl = this.Reader(Template.ClassDecl);
            classDecl = classDecl.Replace(this.cilReplacedToken[CILReplacedToken.ClassBody], this.ParseClass(parser.MainBody));
            this.cilCode.AppendLine(classDecl);
            this.Writer(this.cilCode.ToString());
        }

        private string ParseClass(Body classBody) {
            string body = "";
            foreach (var node in classBody.Nodes) {
                if (node is MethodNode && (node as MethodNode).MethodType == MethodType.Cust) {
                    body += this.GenerateCILMethod(node as MethodNode);
                }
            }

            return body;
        }



        #region Addition
        private void InitializeTemplates() {
            this.templatesDictionary = new Dictionary<Template, string>() {
                { Template.ClassDecl , "ClassDeclTemplate.txt"},
                { Template.DeclFuncFinich, "DeclFuncFinish.txt"},
                { Template.DeclMainFunc, "DeclMainFuncStart.txt"},
                { Template.StartFuncDecl, "StartFucDecl.txt"},
                { Template.StartProgram, "StartProgramTempate.txt" },
                { Template.LocalvariableDeclaration, "LocalvariableDeclaration.txt" },
                { Template.ConsoleWriteLine, "WriteLineTemplate.txt" }
            };

            this.cilReplacedToken = new Dictionary<CILReplacedToken, string>() {
                {CILReplacedToken.MethodName, "{name}"},
                {CILReplacedToken.MethodArgs, "{args}"},
                { CILReplacedToken.Variables, "{variables}"},
                { CILReplacedToken.ClassBody, "{classBody}"}
            };

        }

        private string Reader(Template template) {
            string fileName =Environment.CurrentDirectory + "..\\..\\..\\Templates\\"+ this.templatesDictionary[template];

            FileStream file = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string result = reader.ReadToEnd();
            reader.Close();
            file.Close();
            return result;
        }

        private void Writer(string cilCode) {
            FileStream file = new FileStream("cil.il", FileMode.Create);
            StreamWriter reader = new StreamWriter(file);
            reader.Write(cilCode);
            reader.Close();
            file.Close();
        }

        #endregion

    }
}
