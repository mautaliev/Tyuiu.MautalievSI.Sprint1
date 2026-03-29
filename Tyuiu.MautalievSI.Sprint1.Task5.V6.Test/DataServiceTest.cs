using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint1.Task5.V6.Lib;

namespace Tyuiu.MautalievSI.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_DayOfYear_ReturnsCorrectWeekDay()
        {
            // Arrange
            DataService ds = new DataService();

            // Act
            int result1 = ds.Calculate(1);   // Понедельник
            int result2 = ds.Calculate(7);   // Воскресенье
            int result3 = ds.Calculate(8);   // Понедельник

            // Assert
            Assert.AreEqual(1, result1);
            Assert.AreEqual(7, result2);
            Assert.AreEqual(1, result3);
        }
    }
}