using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace htmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen(lines: 30, 10);
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOptions(option);
        }
        public static void DrawScreen(int lines, int columns)
        {
            DrawLines(lines);
            DrawColumns(columns, lines);
            DrawLines(lines);

        }
        public static void DrawLines(int lines)
        {
            System.Console.Write("+");
            for (int i = 0; i <= lines; i++)
                System.Console.Write("-");

            System.Console.Write("+");
            System.Console.Write("\n");
        }
        public static void DrawColumns(int columns, int lines)
        {
            for (int i = 0; i <= columns; i++)
            {
                System.Console.Write("|");
                for (int col = 0; col <= lines; col++)
                    System.Console.Write(" ");

                System.Console.Write("|");
                System.Console.Write("\n");
            }
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            System.Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            System.Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            System.Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            System.Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            System.Console.WriteLine("2 - Abrir Arquivo");
            Console.SetCursorPosition(3, 9);
            System.Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            System.Console.Write("Opção: ");
        }
        public static void HandleMenuOptions(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2:; break;
                case 0:
                    {
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}