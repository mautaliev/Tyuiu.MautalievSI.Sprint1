using System;
using Tyuiu.MautalievSI.Sprint1.Task3.V15.Lib;

namespace Tyuiu.MautalievSI.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Мауталиев С. И. | НТм-24-1 | Задание #3 | Вариант #15";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                      *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Мауталиев С. И. | НТм-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Два автомобиля движутся в противоположные стороны.                       *");
            Console.WriteLine("* Найти расстояние между ними через T часов.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double v1, v2, S, T;

            Console.WriteLine("Введите скорость первого автомобиля (км/ч):");
            v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля (км/ч):");
            v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите начальное расстояние (км):");
            S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время (часы):");
            T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние через T часов = " + ds.DistanceOverTime(v1, v2, S, T));

            Console.ReadLine();
        }
    }
}