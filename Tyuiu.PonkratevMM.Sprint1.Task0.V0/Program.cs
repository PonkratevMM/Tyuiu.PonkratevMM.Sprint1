using Tyuiu.PonkratevMM.Sprint1.Task0.V6.Lib;
namespace Tyuiu.PonkratevMM.Sprint1.Task0.V6
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Понкратьев М.М | ИИПб-26";
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #1                                         *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту       *");
            Console.WriteLine("* Задание #0                                        *");
            Console.WriteLine("* Вариант #6                                        *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет             *");
            Console.WriteLine("* выражение 3 * (4 + 1) и печатает резульатат      *");
            Console.WriteLine("* на экран                                          *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* 3 * (4 + 1)                                       *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ                                          *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine(); 

        }
    }
}