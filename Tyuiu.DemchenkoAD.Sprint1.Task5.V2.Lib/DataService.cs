﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DemchenkoAD.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double res = (temp - 32) * 5 / 9;
            return Convert.ToInt32(res); 
        }
    }
}
