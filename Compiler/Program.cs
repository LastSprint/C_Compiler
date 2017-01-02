﻿using System;
using System.Net.Mime;
using System.Security.Policy;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using CompilerConsole.CILGenerator;
using Lang2;

namespace CompilerConsole {
    class Program {
        static void Main(string[] args) {
            try {
                string ta = Environment.CurrentDirectory;
                // В качестве входного потока символов устанавливаем консольный ввод
                ANTLRReaderStream input = new ANTLRReaderStream(Console.In);
                // Настраиваем лексер на этот поток
                Lang2Lexer lexer = new Lang2Lexer(input);
                // Создаем поток токенов на основе лексера
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                // Создаем парсер
                Lang2Parser parser = new Lang2Parser(tokens);
                // И запускаем первое правило грамматики!!!
                Object t;
                try {
                    t = parser.execute().Tree;
                }
                catch (Exception ex) {

                    Console.WriteLine();
                    Console.WriteLine("Компилятор говорит: " + ex.Message);
                    Console.ReadKey();
                    return;
                }

                ITree tree = t as ITree;
                DrawingTreeLib.Views.DrawingTreeLib.Initialize(tree);
                Parser.Parser pars = new Parser.Parser(tree);
                pars.Pars();
                pars.NumerateVariable();
                pars.MakeGlobalFields();
                pars.Serialize();
                Generator generator = new Generator();
                generator.Generate(pars);
            }
            catch (Exception e) {
                Console.WriteLine();
                Console.WriteLine("Компилятор говорит:");
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
