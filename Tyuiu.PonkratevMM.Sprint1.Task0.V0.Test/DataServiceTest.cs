using Tyuiu.PonkratevMM.Sprint1.Task0.V6.Lib;

namespace Tyuiu.PonkratevMM.Sprint1.Task0.V6.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds_Calculate();
            Assert.AreEqual(2, res);
        }

        private int ds_Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
