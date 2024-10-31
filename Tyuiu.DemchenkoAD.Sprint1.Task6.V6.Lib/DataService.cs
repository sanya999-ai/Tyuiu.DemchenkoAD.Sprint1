using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DemchenkoAD.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            
                string[] arrOfStr = value.Split(' ');


                string res = "";


                foreach (string a in arrOfStr)
                {
                    res += a.Substring(1, a.Length - 1) + "";
                }

                return res;
            }
    }
}
