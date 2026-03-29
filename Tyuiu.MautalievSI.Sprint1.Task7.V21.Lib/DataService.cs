using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MautalievSI.Sprint1.Task7.V21.Lib
{
    public class DataService : ISprint1Task7V21
    {
        public double Calculate(double x, double y)
        {
            double part1 = Math.Pow(y, x) / (Math.Cos(x) - x / 3);
            double part2 = (Math.Sin(x * x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y)) * Math.Tan(x * y);

            double result = part1 + part2;

            return Math.Round(result, 3);
        }
    }
}