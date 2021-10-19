using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x;

            y = 4; // определно заранее

            Console.Write("Введите x = ");
            x = Convert.ToDouble(Console.ReadLine()); // считываем с консоли

            if ((x % y) == 0) // проверка деления без остатка
                Console.WriteLine($"y = {x/y}");
            else
                Console.WriteLine("Введренное число не делится нацело ");

            Console.ReadLine(); // задерживаем консоль для просмотра
        }
    }
}
