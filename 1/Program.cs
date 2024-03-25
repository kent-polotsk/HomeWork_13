
using _1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

internal class Program
{

    public static string[] GetRandomWords(int count)
    {
        var randWords = new string[count];

        Dictionary<int, string> myDictionary = new Dictionary<int, string>
            {
                { 1, "Audi" },
                { 2, "Mercedes" },
                { 3, "Renault" },
                { 4, "BMW" },
                { 5, "Peugeot" },
                { 6, "Honda" },
                { 7, "Ford" },
                { 8, "Lincoln" },
                { 9, "Nissan" },
                { 10, "Opel" }
            };

        Random random = new Random();

        if (count == 0)
        {
            Console.WriteLine("---Dictionary---");
            foreach (var w in myDictionary)
                Console.WriteLine(w);
            Console.WriteLine("----------------");
        }

        for (int i = 0; i < count; i++)
            randWords[i] = myDictionary[random.Next(1, myDictionary.Count + 1)];

        return randWords;
    }

    public static IEnumerable<string> CheckWordsAndGetLong(string[] words)
    {
        foreach (var w in words)
            if (w.Length >= 5)
                yield return w;
    }



    public static void PrintGuide()
    {
        const string Guide = "1 - Выполнить программу с размером массива по умолчанию (3)\n2 - Выполнить программу с размером массива заданным вручную\n3 - Просмотр словаря\n4 - Инструкция\nESC - выход";
        Console.ForegroundColor = ConsoleColor.Yellow;
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


    private static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Задание 1: работа с Dictionary, yield, IEnumerable");
        Console.ResetColor();

        PrintGuide();

        Words words;
        ConsoleKeyInfo key;

        do
        {
            key = PressKey();
            switch (key.Key)
            {
                case ConsoleKey.D3:
                    {
                        CheckWordsAndGetLong(GetRandomWords(0));
                        break;
                    }
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("-Метод вне класса-");
                        IEnumerable wrds = CheckWordsAndGetLong(GetRandomWords(3));
                        foreach (var w in wrds)
                        {
                            Console.WriteLine(w);
                        }


                        Console.WriteLine("--Метод в классе--");
                        words = new Words(GetRandomWords(3));
                        foreach (var w in words)
                            Console.WriteLine(w);
                        Console.WriteLine("----------------");

                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Console.WriteLine("Введите размер для рандомного массива (1-10): ");
                        string? input = Console.ReadLine();

                        if (int.TryParse(input, out int result) && result >= 1 && result <= 10)
                        {
                            Console.WriteLine("--Метод вне класса--");
                            foreach (var w in CheckWordsAndGetLong(GetRandomWords(result)))
                            {
                                Console.WriteLine(w);
                            }

                            Console.WriteLine("--Метод в классе--");

                            words = new Words(GetRandomWords(result));
                            foreach (var w in words)
                                Console.WriteLine(w);

                            Console.WriteLine("----------------");
                        }
                        else Console.WriteLine("Некорректный ввод");
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        string bye = "Спасибо за внимание!";
                        for (int i = 0; i < bye.Length; i++)
                        {
                            Console.Write(bye[i]);
                            Thread.Sleep(60);
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
}