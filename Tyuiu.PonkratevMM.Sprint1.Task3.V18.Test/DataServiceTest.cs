using Tyuiu.PonkratevMM.Sprint1.Task3.V18.Lib;
namespace Tyuiu.PonkratevMM.Sprint1.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 5;
            double b = 6;
            double c = 3;
            var res = ds.HowManySquares(a, b, c);

        }
    }
}
