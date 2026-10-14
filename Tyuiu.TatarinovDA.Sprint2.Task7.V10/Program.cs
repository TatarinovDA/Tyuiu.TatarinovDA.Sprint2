using Tyuiu.TatarinovDA.Sprint2.Task7.V10.Lib;
//Написать программу на C#, которая запрашивает исходные данные (вещественные значения) и вычисляет,
//находится ли точка с координатами X,Y в заштрихованной области.
namespace Tyuiu.TatarinovDA.Sprint2.Task7.V10
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X,Y в заштрихованной области.                                           *");
            



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите координату X : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите координату Y : ");
            double y = Convert.ToDouble(Console.ReadLine());
            


            bool res = ds.CheckDotInShadedArea(x,y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");



            if (res)
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) НЕ находится в заштрихованной области.");
            }


            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }

}
