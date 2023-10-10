using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint2.Task4.V7.Lib;

namespace Tyuiu.LoginovMV.Sprint2.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 22;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 1.010;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 12;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 1762.000;
            Assert.AreEqual(wait, res);
        }
    }
}
