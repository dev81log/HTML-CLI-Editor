using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var options = short.Parse(Console.ReadLine());
            HandleMenuOption(options);
        }

        public static void DrawScreen()
        {
            // +---------------------+
            // |                     |
            // |                     |
            // |                     |
            // +---------------------+

            int x = 30;
            int y = 15;
            CreateDrawLines(x);
            CreateDrawPipes(y, x);
            CreateDrawLines(x);

            static void CreateDrawLines(int x)
            {
                Console.Write("+");
                for (int i = 0; i <= x; i++)
                    Console.Write("-");

                Console.Write("+");
                Console.Write("\n");
            }

            static void CreateDrawPipes(int y, int x)
            {
                for (int lines = 0; lines <= y; lines++)
                {
                    Console.Write("|");
                    for (int i = 0; i <= x; i++)
                        Console.Write(" ");

                    Console.Write("|");
                    Console.Write("\n");
                }
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Select options below");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - New file");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Open file");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Exit");
            Console.SetCursorPosition(3, 9);
            Console.Write("Option: ");

        }

        public static void HandleMenuOption(short options)
        {
            switch (options)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}