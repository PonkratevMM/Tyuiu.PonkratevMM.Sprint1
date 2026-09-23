using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PonkratevMM.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {

            if (c <= 0 || a <= 0 || b<=0)
            {
                return 0;

            }
            double x = Math.Floor(a / c);
            double y = Math.Floor(b / c);
            double total = x * y;
            return Math.Round(total, 3);

        }
    }
}
