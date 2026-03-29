using System;
using Tyuiu.MautalievSI.Sprint1.Task6.V9.Lib;

// ЗАДАНИЕ
// Написать программу: пользователь вводит текст.
// Напечатать все слова, перенеся их последнюю букву в начало.

namespace Tyuiu.MautalievSI.Sprint1.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Мауталиев С. И. | НТм-24-1 | Задание #6 | Вариант #9";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками в C#                                            *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнил: Мауталиев С. И. | НТм-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Перенести последнюю букву каждого слова в начало.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            string value;

            Console.WriteLine("Введите текст:");
            value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.MoveLetterToStart(value);

            Console.WriteLine("Изменённый текст = " + result);

            Console.ReadKey();
        }
    }
}