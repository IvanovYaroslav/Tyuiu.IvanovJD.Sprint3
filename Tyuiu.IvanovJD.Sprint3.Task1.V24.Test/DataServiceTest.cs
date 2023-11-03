using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint3.Task1.V24.Lib;
namespace Tyuiu.IvanovJD.Sprint3.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 12;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.186;
            Assert.AreEqual(wait, res);
        }
    }
}