using Tyuiu.PonkratevMM.Sprint1.Task1.V27.Lib;
namespace Tyuiu.PonkratevMM.Sprint1.Task0.V27
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Понкратьев М.М | ИИПб-26";
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #1                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
            Console.WriteLine("* Задание #1                                        *");
            Console.WriteLine("* Вариант #27                                       *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает           *");
            Console.WriteLine("* у пользователя исходные данные, вычисляет         *");
            Console.WriteLine("* результат по формуле (x + y ) / 2 и печатает его  *");
            Console.WriteLine("* на экране.                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");


            double x, y;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ                                          *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();


        }
    }
}