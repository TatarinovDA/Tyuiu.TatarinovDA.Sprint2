using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TatarinovDA.Sprint2.Task0.V29.Lib
{
    public class DataService : ISprint2Task0V29
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];
            result[0] = x * 2 == y;
            result[1] = (y - x) != 630;
            result[2] = x * 2 < y;
            result[3] = (y - x) > 100;
            result[4] = (y / 7) <= (x / 2);
            result[5] = (x * 5) >= (y + 500);
            return result;
        }
    }
}
