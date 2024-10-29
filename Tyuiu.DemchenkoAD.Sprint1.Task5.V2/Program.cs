using Tyuiu.DemchenkoAD.Sprint1.Task5.V2.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task5.V2
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
            Console.WriteLine("* Задание #Task5                                                *");
            Console.WriteLine("* Вариант #2                                                    *");
            Console.WriteLine("* Выполнила: Демченко А. Д. | ИСПб-24-1                         *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      *");
            Console.WriteLine("* написать программу,преобразовывающую градусы Фаренгейта в     *");
            Console.WriteLine("* градусы Цельсия и ответ привести к целому с помощью класса Convert.*");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                               *");
            Console.WriteLine("*****************************************************************");


            Console.WriteLine("Введите значение температуры в градусах Фаренгейта: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.FahrenheitToСelsius(temp));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
