using Tyuiu.DemchenkoAD.Sprint1.Task0.V10.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task0.V10
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
            Console.WriteLine("* Вариант #10                                            *");
            Console.WriteLine("* Выполнила: Демченко А. Д. | ИСПб-24-1                  *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                               *");
            Console.WriteLine("* Написать консольную программу на С#, которая  решает   *");
            Console.WriteLine("* пример (3 / 6 - 4) * 3 и ответ печатает на экране      *");
            Console.WriteLine("*                                                        *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                        *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* (3 / 6 - 4) * 3                                        *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Результат:                                             *");
            Console.WriteLine("**********************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}
