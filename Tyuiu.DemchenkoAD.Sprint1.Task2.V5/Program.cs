using Tyuiu.DemchenkoAD.Sprint1.Task2.V5.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Демченко А. Д. | ИСПб-24-1";
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Спринт #1                                              *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                    *");
            Console.WriteLine("* Задание #Task0                                         *");
            Console.WriteLine("* Вариант #5                                             *");
            Console.WriteLine("* Выполнила: Демченко А. Д. | ИСПб-24-1                  *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                               *");
            Console.WriteLine("* Написать программу на С#, которая которая запрашивает  *");
            Console.WriteLine("* у пользователя исходные данные, выполняет указанные    *");
            Console.WriteLine("* расчёты и печатает результат на экране.                *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                        *");
            Console.WriteLine("**********************************************************");

            int x;

            Console.WriteLine("Введите значение длины стороны куба:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("**********************************************************");

            Console.WriteLine("Площадь боковой поверхности куба = " + ds.CalculateSideSquare(x));

            Console.ReadLine();


        }
    }
}
