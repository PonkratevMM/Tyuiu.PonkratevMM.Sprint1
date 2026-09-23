using Tyuiu.PonkratevMM.Sprint1.Task3.V18.Lib;
namespace Tyuiu.PonkratevMM.Sprint1.Task3.V18
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
            Console.WriteLine("* Написать программу, которая вычисляет             *");
            Console.WriteLine("* сколько квадратов со стороной C можно             *");
            Console.WriteLine("* разместить внутри прямоугольника с размерами      *");
            Console.WriteLine("* A x B без наложений. Ответ округлите до 3 знаков  *");
            Console.WriteLine("* после запятой.                                    *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.Write("Введите сторону прямоугольника A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону прямоугольника B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону квадрата C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            try
            { 
                double result = ds.HowManySquares(a, b, c);

                Console.WriteLine("Количество вмещаемых квадратов =" + Math.Round(result,3));
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }

            Console.ReadKey();



        }
    }
}