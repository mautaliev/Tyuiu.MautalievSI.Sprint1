using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MautalievSI.Sprint1.Task1.V12.Lib
{
    interface ISprint1Task1V12
    {
        public double Calculate(double x, double y)
        {
            return x / (1 - y);
        }
    }
}
