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
            int x = 6;
            var res = Math.Round(ds.CalculateSquareCircle(x),3);
            Assert.AreEqual(113.097, res);

        }
    }
}
