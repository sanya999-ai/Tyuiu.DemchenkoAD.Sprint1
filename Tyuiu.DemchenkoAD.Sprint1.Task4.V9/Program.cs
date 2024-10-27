using Tyuiu.DemchenkoAD.Sprint1.Task4.V9.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task4.V9
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
            Console.WriteLine("* Задание #Task4                                                *");
            Console.WriteLine("* Вариант #9                                                    *");
            Console.WriteLine("* Выполнила: Демченко А. Д. | ИСПб-24-1                         *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* написать программу,которая запрашивает у пользователя         *");
            Console.WriteLine("* исходные данные, выполняет указанные расчёты и печатает ответ *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                               *");
            Console.WriteLine("* Формула: ln(x*y)/x-√(1-y^2)                                   *");
            Console.WriteLine("*****************************************************************");

            double x;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("******************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                     *");
            Console.WriteLine("******************************************************************");
            Console.WriteLine($"* ln(x*y)/x-√(1-y^2) = {ds.Calculate(x, y)}                     *");
            Console.WriteLine("******************************************************************");
            Console.ReadKey();
        }
    }
}
