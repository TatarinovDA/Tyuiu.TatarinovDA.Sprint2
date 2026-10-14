using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TatarinovDA.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n > 1)
            {
                return $"{n - 1:D2}.{m:D2}.{g}";
            }
            else
            {
                return m switch
                {
                    1 => $"31.12.{g-1}",
                    2 => $"31.01.{g}",
                    3 => $"28.02.{g}",
                    4 => $"31.03.{g}",
                    5 => $"30.04.{g}",
                    6 => $"31.05.{g}",
                    7 => $"30.06.{g}",
                    8 => $"31.07.{g}",
                    9 => $"31.08.{g}",
                    10 => $"30.09.{g}",
                    11 => $"31.10.{g}",
                    12 => $"30.11.{g}",
                    _ => throw new ArgumentException("Некорректный номер месяца")
                };
            }
        }
    }
}
