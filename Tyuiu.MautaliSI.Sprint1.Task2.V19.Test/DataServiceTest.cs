using Tyuiu.MautaliSI.Sprint1.Task2.V19.Lib;

namespace Tyuiu.MautaliSI.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 10000;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(254, res);
        }
    }
}
