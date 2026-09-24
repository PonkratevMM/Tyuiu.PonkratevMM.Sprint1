using Tyuiu.PonkratevMM.Sprint1.Task5.V6.Lib;

namespace Tyuiu.PonkratevMM.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExprassion()
        {
            int k = 1;
            DataService ds = new DataService();
            int res = ds.Calculate(k);

            Assert.AreEqual(1, res);
        }
    }
}
