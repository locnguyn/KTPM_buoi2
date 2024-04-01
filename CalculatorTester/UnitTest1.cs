using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation loc13;
        [TestInitialize]
        public void setUp()
        {
            loc13 = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestMethodCong()
        {
            int expected, actual;
            expected = 15;
            actual = loc13.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodTru()
        {
            int expected, actual;
            expected = 5;
            actual = loc13.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodNhan()
        {
            int expected, actual;
            expected = 50;
            actual = loc13.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodChia()
        {
            int expected, actual;
            expected = 2;
            actual = loc13.Execute("/");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZeroException()
        {
            loc13 = new Calculation(10, 0);
            int result = loc13.Execute("/");
        }

        //liên kết datafile với project
        
    }
}
