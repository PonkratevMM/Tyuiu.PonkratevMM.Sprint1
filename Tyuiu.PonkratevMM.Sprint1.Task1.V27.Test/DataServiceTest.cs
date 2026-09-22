using Tyuiu.PonkratevMM.Sprint1.Task1.V27.Lib;

namespace Tyuiu.PonkratevMM.Sprint1.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);

        }
    }
}
