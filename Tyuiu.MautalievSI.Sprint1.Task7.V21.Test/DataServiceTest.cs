using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint1.Task7.V21.Lib;

namespace Tyuiu.MautalievSI.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ValidInput_ReturnsCorrectResult()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(4.741, res);
        }
    }
}