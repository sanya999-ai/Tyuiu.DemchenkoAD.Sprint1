﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DemchenkoAD.Sprint1.Task3.V2.Lib
{
    public class DataService : ISprint1Task3V2
    {
        public double PurchaseAmount(double priceNotebook, int amountNotebook, double pricePencil, int amountPencil)
        {
            return priceNotebook * amountNotebook + pricePencil * amountPencil;
        }
    }
}
