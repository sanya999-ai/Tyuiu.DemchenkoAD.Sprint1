using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DemchenkoAD.Sprint1.Task7.V15.Lib
{
    public class DataService : ISprint1Task7V15
    {
        public double Calculate(double x)
        {
            double res = Math.Pow(3, 2) - Math.Pow(3, 3) - Math.Cos(Math.Pow(2, 3)) + (7 * Math.Pow(2, 2) / Math.Pow(2, 3)) - (15 * 2);
          
            return res;

        }
    }
}
