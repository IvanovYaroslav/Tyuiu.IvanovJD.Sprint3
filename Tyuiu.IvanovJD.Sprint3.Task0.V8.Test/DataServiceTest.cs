using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint3.Task0.V8.Lib;

namespace Tyuiu.IvanovJD.Sprint3.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double value = 0.25;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.019;
            Assert.AreEqual(wait, res);
        }
    }
}