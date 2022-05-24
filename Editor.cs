using System;
using System.Text;

namespace EditorHtml
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Editor Start - Choice");
            Console.WriteLine("---------------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("Save Selected File?");
            Console.WriteLine("1 - Save");
            Console.WriteLine("2 - Exit");
            Console.WriteLine("-------------------");

            short response = short.Parse(Console.ReadLine());

            switch (response)
            {
                case 1: ChoiceSaveFile(file); break;
                case 2: Console.WriteLine("Exit"); break;
                default: Console.WriteLine("Dont save file"); break;
            }


            static void ChoiceSaveFile(StringBuilder file)
            {
                var path = Console.ReadLine();
                using (var fileSave = new StreamWriter(path))
                {
                    fileSave.Write(file);
                }

                Console.WriteLine($"File saved {path} on success");
                Thread.Sleep(2000);

            }
        }
    }
}