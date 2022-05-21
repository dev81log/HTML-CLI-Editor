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
        }

        public static void DrawScreen()
        {
            // +---------------------+
            // |                     |
            // |                     |
            // |                     |
            // +---------------------+

            int x = 20;
            int y = 3;
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
    }
}