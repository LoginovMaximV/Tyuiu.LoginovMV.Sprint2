using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint2.Task6.V13.Lib;

namespace Tyuiu.LoginovMV.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2000;
            int m = 12;
            int n = 31;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "2001.1.1";
            Assert.AreEqual(wait, res);
        }
    }
}
