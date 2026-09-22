using Tyuiu.PonkratevMM.Sprint1.Task2.V7.Lib;
namespace Tyuiu.PonkratevMM.Sprint1.Task2.V7
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
            Console.WriteLine("* Задание #2                                        *");
            Console.WriteLine("* Вариант #27                                       *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает           *");
            Console.WriteLine("* указанные расчёты и печатает результат            *");
            Console.WriteLine("* на экране.                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            int x;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ                                          *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("Площадь круга = " + ds.CalculateSquareCircle(x));
            Console.ReadKey();



        }
    }
}

