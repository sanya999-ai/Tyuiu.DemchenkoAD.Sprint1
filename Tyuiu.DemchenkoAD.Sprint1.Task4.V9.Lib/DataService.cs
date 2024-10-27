﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DemchenkoAD.Sprint1.Task4.V9.Lib
{
    public class DataService : ISprint1Task4V9
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Log(x * y)) / (x - Math.Sqrt(1 + Math.Pow(y, 2)));
            return double.Round(res, 3);
        }
    }
}
