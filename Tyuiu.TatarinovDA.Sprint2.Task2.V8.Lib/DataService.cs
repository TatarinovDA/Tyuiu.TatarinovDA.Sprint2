using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TatarinovDA.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x < 1 || x > 15 || y < 1 || y > 15)
                return false;
            if (y == 2 && x >= 6 && x <= 8)
                return true;
            if (y >= 3 && y <= 6 && x >= 3 && x <= 7)
                return true;
            if (y >= 3 && y <= 4 && x >= 10 && x <= 11)
                return true;
            if (y >= 5 && y <= 6 && x >= 8 && x <= 11)
                return true;
            if (y >= 7 && y <= 9)
            {
                if (x >= 3 && x <= 4) return true;
                if (x == 7) return true;
                if (y <= 8 && x >= 10 && x <= 12) return true;
                if (y == 9 && x >= 10 && x <= 11) return true;
            }
            
            if (y >= 10 && y <= 11 && x >= 3 && x <= 7) return true;
            if (y == 12 && x >= 5 && x <= 7) return true;

            return false;
            
        }
    }
}
