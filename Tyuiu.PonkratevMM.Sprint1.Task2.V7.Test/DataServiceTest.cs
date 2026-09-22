using Newtonsoft.Json.Linq;
using Tyuiu.PonkratevMM.Sprint1.Task2.V7.Lib;

namespace Tyuiu.PonkratevMM.Sprint1.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateSquareCircle(x);

        }
    }
}
