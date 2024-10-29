using Tyuiu.DemchenkoAD.Sprint1.Task6.V6.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Демченко А. Д. | ИСПб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #1                                                     *");
            Console.WriteLine("* Тема:Операторы составного присваивания в C#                   *");
            Console.WriteLine("* Задание #Task6                                                *");
            Console.WriteLine("* Вариант #6                                                    *");
            Console.WriteLine("* Выполнила: Демченко А. Д. | ИСПб-24-1                         *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* написать программу, которая удаляет первую букву в строчке    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                               *");
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("Ведите строку:");

            string str = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.DeleteFirstLetter(str.TrimEnd()));

            Console.ReadKey();
        }
    }
}
