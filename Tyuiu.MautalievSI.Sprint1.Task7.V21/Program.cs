using System;
using Tyuiu.MautalievSI.Sprint1.Task7.V21.Lib;

// ЗАДАНИЕ
// Написать программу, которая вычисляет математическое выражение
// по исходным значениям данных, вводимых пользователем.
// Ответ округлить до 3 знаков после запятой.

namespace Tyuiu.MautalievSI.Sprint1.Task7.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Мауталиев С. И. | НТм-24-1 | Задание #7 | Вариант #21";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Класс Math                                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Мауталиев С. И. | НТм-24-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить выражение:                                                    *");
            Console.WriteLine("* z = y^x / (cos(x) - x/3) + ((sin(x^2) + cos(y)) /                       *");
            Console.WriteLine("*     (cos(x) - sin(y))) * tg(xy)                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("z = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}