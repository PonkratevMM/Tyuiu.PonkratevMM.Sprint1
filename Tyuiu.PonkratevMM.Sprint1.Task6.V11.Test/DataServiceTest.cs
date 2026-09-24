using Newtonsoft.Json.Linq;
using Tyuiu.PonkratevMM.Sprint1.Task6.V11.Lib;

namespace Tyuiu.PonkratevMM.Sprint1.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "йцукенгшщзхъй";
            bool res = ds.CheckeFirstLetterRepetition(value);

            Assert.IsTrue(res);

        }
    }
}
