using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanovJD.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1;
            int k;
            for (k = startValue; k <= stopValue; k++)
            {
                res *= (Math.Pow(value, k) + 1) * Math.Cos(4);
            }
            return Math.Round(res, 3);
        }
    }
}