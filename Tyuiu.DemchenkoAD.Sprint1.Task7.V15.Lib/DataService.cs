﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DemchenkoAD.Sprint1.Task7.V15.Lib
{
    public class DataService : ISprint1Task7V15
    {
        public double Calculate(double x)
        {
            var res = Math.Round((Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3))) - ((Math.Cos(Math.Pow(x, 3)) + 7 * (Math.Pow(x, 2))) / ((Math.Pow(x, 3)) - 15 * x)), 3);
            return res;

        }
    }
}
