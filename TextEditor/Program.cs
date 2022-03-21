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
            Console.WriteLine("Editor de texto\n");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo\n2 - Criar novo arquivo\n0 - Sair\n");

            short options = short.Parse(Console.ReadLine());

            switch (options)
            {
                case 0: Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: CreateFile(); break;
            }

        }

        static void OpenFile() { }

        static void CreateFile()
        {
            Console.Clear();
            Console.WriteLine("Escreva seu texto abaixo (ESC para Sair)");
            Console.WriteLine("--------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho que o arquivo será salvo:");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.Write($"Arquivo salvo em {path} com sucesso!\nPrencione ENTER para voltar ao menu.");
            Console.ReadLine();
            Menu();
        }
    }
}
