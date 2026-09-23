using Tyuiu.PonkratevMM.Sprint1.Task4.V1.Lib;
namespace Tyuiu.PonkratevMM.Sprint1.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExprassion()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 0.062;
            var res = ds.Calculate(x);
            Assert.AreEqual(y, res);

        }
    }
}
