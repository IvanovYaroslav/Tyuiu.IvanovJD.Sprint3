using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint3.Task6.V21.Lib;

namespace Tyuiu.IvanovJD.Sprint3.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Cheeeeeeck()
        {
            DataService ds = new DataService();

            int startValue = 19;
            int stopValue = 30;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 485;

            Assert.AreEqual(wait, res);
        }
    }
}