
using _2;
using System.Collections.ObjectModel;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Задание 2: пользовательский список Collection<T>, IComparable ");
        Console.ResetColor();

        PrintGuide();

        ConsoleKeyInfo key;

        Random random = new Random();
        MyCollection<MyClass> collection = new MyCollection<MyClass>();

        do
        {
            key = PressKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        collection.PrintItems();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        collection.Add();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        collection.Clear();
                        break;
                    }
                case ConsoleKey.D4:
                    {
                        PrintGuide();
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("1");
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string bye = "С наилучшими пожеланиями)))";
                        for (int i = 0; i < bye.Length; i++)
                        {
                            Console.Write(bye[i]);
                            Thread.Sleep(45);
                        }
                        Console.ResetColor();
                        Thread.Sleep(300);
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    }
                default: break;
            }
        } while (true);

    }

    public static void PrintGuide()
    {
        const string Guide = "1 - Печать списка\t2 - Добавить значение\n3 - Очистить список\t4 - Инструкция\nESC - выход";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(Guide);
        Console.ResetColor();
    }

    public static ConsoleKeyInfo PressKey()
    {
        int cursorLeft = Console.CursorLeft;
        ConsoleKeyInfo key = Console.ReadKey();
        Console.SetCursorPosition(cursorLeft, Console.CursorTop);
        Console.Write(" ");
        Console.SetCursorPosition(cursorLeft, Console.CursorTop);
        return key;
    }
}