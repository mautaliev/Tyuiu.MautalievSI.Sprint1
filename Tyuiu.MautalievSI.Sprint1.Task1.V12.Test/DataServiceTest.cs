using Tyuiu.MautalievSI.Sprint1.Task1.V12.Lib;

namespace Tyuiu.MautalievSI.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 6;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);

        }
    }
}
