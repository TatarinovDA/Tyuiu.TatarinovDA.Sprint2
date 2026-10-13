using Tyuiu.TatarinovDA.Sprint2.Task4.V26.Lib;
//
namespace Tyuiu.TatarinovDA.Sprint2.Task4.V26
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение тернарного     *");
            Console.WriteLine("* оператора, где пользователь вводит значение переменных X,Y с            *");
            Console.WriteLine("* клавиатуры, если x - 2 < y/2, то z = ( 10 + 2/x^2)^y иначе              *");
            Console.WriteLine("* x^2 - (1/y); Ответ округлите до 3 знаков после запятой;                 *");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double z = ds.Calculate(x,y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine($"Результат вычисления Z: {z}");


            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }

}