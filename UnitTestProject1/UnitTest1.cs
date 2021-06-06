using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calc obj = new Calc();

        [TestMethod]
        public void TestMethod1()
        {
            int actual = obj.add(5, 2);
            int expected = 8;
            Assert.AreEqual(expected, actual);

        }
        public void TestMethod2()
        {
            int actual = obj.sub(5, 2);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod3()
        {
            int actual = obj.mul(5, 2);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod4()
        {
            int actual = obj.div(10, 2);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}
