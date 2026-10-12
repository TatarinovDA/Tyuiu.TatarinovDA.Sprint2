using Tyuiu.TatarinovDA.Sprint2.Task2.V8.Lib;
//Написать программу на, которая запрашивает целые значения с клавиатуры
//и вычисляет находится ли точка с координатами X,Y в заштрихованной области.
namespace Tyuiu.TatarinovDA.Sprint2.Task2.V8
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                       *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите координату X (от 1 до 15): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* Введите координату Y (от 1 до 15): ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            bool result = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (result)
            {
                Console.WriteLine($"Точка ({x}, {y}) попадает в заштрихованную область.");
            }
            else
            {
                Console.WriteLine($"Точка ({x}, {y}) НЕ попадает в заштрихованную область.");
            }
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }

}
