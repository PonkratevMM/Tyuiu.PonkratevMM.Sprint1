using Tyuiu.PonkratevMM.Sprint1.Task6.V11.Lib;
namespace Tyuiu.PonkratevMM.Sprint1.Task6.V11
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
            Console.WriteLine("* Задание #6                                        *");
            Console.WriteLine("* Вариант #11                                       *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.    *");
            Console.WriteLine("* Проверить, что первая буква строки входит в нее   *");
            Console.WriteLine("* еще раз.                                          *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("Введите строку:");
            string value = Console.ReadLine();
            bool result = ds.CheckeFirstLetterRepetition(value);



            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("Первая буква повторяется в строке: " + result);

         


            Console.ReadKey();

        }
    }
}
