using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\nTEXT EDITOR\n");
            Console.WriteLine("A - Abrir arquivo");
            Console.WriteLine("C - Criar novo arquivo");
            Console.WriteLine("S - Sair\n");

            switch(Console.ReadLine().ToLower())
            {
                case "a": Open(); break;
                case "c": Edit(); break;
                case "s": System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();

            Console.WriteLine("\n-----------------------------------\n");

            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("\n-----------------------------------\n");
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.WriteLine("Aperte ESC para sair\n");

            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.Enter: Menu(); break;
                case ConsoleKey.Escape: System.Environment.Exit(0); break;
                default: Console.WriteLine("\n..."); break;
            }
        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("\n(Aperte ESC para sair)");
            Console.WriteLine("-----------------------------------\n");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
//nice
            SaveFile(text);
        }

        static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("\n SALVAR \n");
            Console.WriteLine("Digite o caminho do arquivo: ");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine("\nArquivo salvo\n");
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.WriteLine("Aperte ESC para sair\n");

            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.Enter: Menu(); break;
                case ConsoleKey.Escape: System.Environment.Exit(0); break;
                default: Console.WriteLine("\n..."); break;
            }
        }
    }
}
