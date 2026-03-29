using System;
using Tyuiu.MautalievSI.Sprint1.Task5.V6.Lib;

// ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчёты и печатает результат на экране.
// Дано: k – день года (1..365). Определить номер дня недели (1..7),
// если 1 января — понедельник.

namespace Tyuiu.MautalievSI.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Мауталиев С. И. | НТм-24-1 | Задание #5 | Вариант #6";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                      *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнил: Мауталиев С. И. | НТм-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Определить день недели по номеру дня года (1..365).                      *");
            Console.WriteLine("* 1 января — понедельник.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int k;

            Console.WriteLine("Введите номер дня года (1..365):");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int n = ds.Calculate(k);

            Console.WriteLine("Номер дня недели = " + n);

            Console.ReadKey();
        }
    }
}