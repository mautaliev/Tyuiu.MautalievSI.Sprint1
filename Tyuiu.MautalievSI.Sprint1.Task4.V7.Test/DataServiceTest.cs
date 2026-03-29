using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint1.Task4.V7.Lib;

namespace Tyuiu.MautalievSI.Sprint1.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ValidInput_ReturnsCorrectResult()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;

            double result = ds.Calculate(x, y);

            // (1 + sqrt(4*1)) / (4 - 3*1)^2 = (1 + 2) / (1)^2 = 3
            Assert.AreEqual(3.000, result);
        }
    }
}