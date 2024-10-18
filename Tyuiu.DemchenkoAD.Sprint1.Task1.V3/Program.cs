using Tyuiu.DemchenkoAD.Sprint1.Task1.V3.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task1.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Демченко А. Д. | ИСПб-24-1";
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Спринт #1                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                       *");
            Console.WriteLine("* Задание #Task0                                         *");
            Console.WriteLine("* Вариант #3                                             *");
            Console.WriteLine("* Выполнила: Демченко А. Д. | ИСПб-24-1                  *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                               *");
            Console.WriteLine("* Написать консольную программу на С#, которая  решает   *");
            Console.WriteLine("* пример (x - y) / (x + 3) + 3 и ответ печатает          *");
            Console.WriteLine("* на экране                                              *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                        *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* (x - y) / (x + 3) + 3                                  *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Результат:                                             *");
            Console.WriteLine("**********************************************************");

            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                              *");
            Console.WriteLine("**********************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
