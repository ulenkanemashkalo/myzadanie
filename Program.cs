using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(20, 2);
        Console.WriteLine("МЕНЮ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(20, 4);
        Console.WriteLine("1 - Красный");
        Console.WriteLine("2 - Зеленый");
        Console.WriteLine("3 - Выход");

        Console.Write("\nВыбор: ");
        string x = Console.ReadLine();

        Console.Clear();

        if (x == "1")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Красный текст");
        }
        else if (x == "2")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Зеленый текст");
        }
        else if (x == "3")
        {
            return;
        }
        else
        {
            Console.WriteLine("Нет такого пункта");
        }

        Console.ResetColor();
        Console.ReadKey();
    }
}
