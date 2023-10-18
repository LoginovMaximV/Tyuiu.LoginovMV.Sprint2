using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint2.Task5.V10.Lib;


namespace Tyuiu.LoginovMV.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2001;
            int m = 9;
            int n = 30;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = "29.9.2001";
            Assert.AreEqual(wait, res);
        }
    }
}
