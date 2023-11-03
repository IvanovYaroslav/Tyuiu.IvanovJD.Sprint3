using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanovJD.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            while (startValue <= stopValue)
            {
                res += Math.Pow(2 / (Math.Pow(value, startValue) + 6), startValue);
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}