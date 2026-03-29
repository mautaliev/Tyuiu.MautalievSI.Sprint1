using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint1.Task6.V9.Lib;

namespace Tyuiu.MautalievSI.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MoveLetterToStart_ValidText_ReturnsModifiedWords()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "hello world";

            // Act
            string result = ds.MoveLetterToStart(value);

            // Assert
            Assert.AreEqual("ohell dworl", result);
        }
    }
}