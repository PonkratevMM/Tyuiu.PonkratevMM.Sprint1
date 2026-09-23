using Tyuiu.PonkratevMM.Sprint1.Task4.V1.Lib;
namespace Tyuiu.PonkratevMM.Sprint1.Task4.V1
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
            Console.WriteLine("* Задание #3                                        *");
            Console.WriteLine("* Вариант #6                                        *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает           *");
            Console.WriteLine("* у пользователя исходные данные, вычисляет         *");
            Console.WriteLine("* результат по формуле 1/(x+2)^2 и печатает         *");
            Console.WriteLine("* его на экране.                                    *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            int x;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("1 / (x + 2)^2 = " + ds.Calculate(x));
            Console.ReadKey();

            



        }
    }
}