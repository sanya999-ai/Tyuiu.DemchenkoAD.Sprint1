using Tyuiu.DemchenkoAD.Sprint1.Task3.V2.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task3.V2
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
            Console.WriteLine("* Задание #Task3                                                *");
            Console.WriteLine("* Вариант #2                                                    *");
            Console.WriteLine("* Выполнила: Демченко А. Д. | ИСПб-24-1                         *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* написать программу, которая вычисляет стоимость покупки,      *");
            Console.WriteLine("* состоящей из нескольких тетрадей и карандашей.                *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                               *");
            Console.WriteLine("*****************************************************************");

            double priceNotebook = 7.12;
            int amountNotebook = 5;
            double pricePencil = 3.05;
            int amountPencil = 8;

            Console.WriteLine("Цена одной тетради:" + priceNotebook);
            Console.WriteLine("Количество тетрадей:" + amountNotebook);
            Console.WriteLine("Цена одного карандаша:" + pricePencil);
            Console.WriteLine("Количество карандашей:" + amountPencil);

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Общая стоимость = " + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));
            Console.ReadKey();
        }
    }
}
