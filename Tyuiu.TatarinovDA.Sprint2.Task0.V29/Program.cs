using Tyuiu.TatarinovDA.Sprint2.Task0.V29.Lib;
//Написать программу из операций сравнений (==, !=, <, >, <=, >=,
//последовательность операций не должна нарушаться) и арифметических выражений,
//которая вернет логическую последовательность(массив): ((False, False, True, True, False, False), при x = 105, y = 735
namespace Tyuiu.TatarinovDA.Sprint2.Task0.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* последовательность операций не должна нарушаться)                       *");
            Console.WriteLine("* и арифметических выражений,которая вернет логическую                    *");
            Console.WriteLine("* последовательность(массив): ((False, False, True, True, False, False),  *");
            Console.WriteLine("* при x = 105, y = 735                                                    *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 105;
            int y = 735;
            Console.WriteLine($"* X = {x}, Y = {y}                                                        *");
            bool[] res = ds.GetCompareOperations(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("* [ ");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
                if (i < res.Length - 1)
                    Console.Write(", ");

            }
            Console.WriteLine(" ] *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }

}
