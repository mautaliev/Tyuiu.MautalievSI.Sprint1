using System;
using Tyuiu.MautalievSI.Sprint1.Task4.V7.Lib;

// ЗАДАНИЕ
// Написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчёты и печатает результат на экране.
// Формула: (1 + sqrt(x*y)) / (x - 3*y)^2

namespace Tyuiu.MautalievSI.Sprint1.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Мауталиев С. И. | НТм-24-1 | Задание #4 | Вариант #7";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                      *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Мауталиев С. И. | НТм-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Вычислить значение выражения:                                            *");
            Console.WriteLine("* (1 + sqrt(x*y)) / (x - 3*y)^2                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}