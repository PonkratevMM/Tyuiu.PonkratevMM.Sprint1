using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PonkratevMM.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            char first = value[0];
            return value.IndexOf(first, 1) != -1;
        }
    }
}
