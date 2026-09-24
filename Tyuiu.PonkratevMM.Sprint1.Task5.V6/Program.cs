using Tyuiu.PonkratevMM.Sprint1.Task5.V6.Lib;
namespace Tyuiu.PonkratevMM.Sprint1.Task5.V1
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
            Console.WriteLine("* Задание #5                                        *");
            Console.WriteLine("* Вариант #6                                        *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая решает следующую      *");
            Console.WriteLine("* задачу: Пусть k – целое от 1 до 365.              *");
            Console.WriteLine("* Присвоить целой переменной n значение 1,2,...,7   *");
            Console.WriteLine("* в зависимости от того, на какой день недели       *");
            Console.WriteLine("* приходится k-й день невисокосного года, в котором *");
            Console.WriteLine("* 1 января – понедельник.                           *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("Введите k (1-365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            if (k >= 1 && k <= 365)
            {
                int n = (k - 1) % 7 + 1;
                Console.WriteLine("n = " + n);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }


            Console.ReadKey();

        }
    }
}
