using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTester2
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        private Calculation loc13;
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestDataLoc13.csv", "TestDataLoc13#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMethodWithDataSource()
        {
            int a, b, expected, actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            loc13 = new Calculation(a, b); ;
            actual = loc13.Execute("+");
            Assert.AreEqual(actual, expected);
        }
    }
}
