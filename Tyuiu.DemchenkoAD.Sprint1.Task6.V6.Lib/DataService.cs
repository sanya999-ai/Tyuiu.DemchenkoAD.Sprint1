using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DemchenkoAD.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {

            string[] s = value.Split(' ');
            string y = "";
            for (int i = 0; i < s.Length; i++)
            {
                value = s[i].Substring(1);
                y += " " + value;


            }
            y = y.Substring(1);
            return y;
        }
    }
}
