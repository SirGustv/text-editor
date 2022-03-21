using System;

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
        static void CreateFile() { }
    }
}
