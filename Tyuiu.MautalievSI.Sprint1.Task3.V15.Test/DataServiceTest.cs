using Tyuiu.MautalievSI.Sprint1.Task3.V15.Lib;

namespace Tyuiu.MautalievSI.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void DistanceOverTime_CarsMovingApart_ReturnsCorrectDistance()
        {
            // Arrange
            DataService ds = new DataService();
            double v1 = 60;
            double v2 = 40;
            double S = 100;
            double T = 2;

            // Act
            double result = ds.DistanceOverTime(v1, v2, S, T);

            // Assert
            Assert.AreEqual(300.000, result);
        }
    }
}