using Tyuiu.TatarinovDA.Sprint2.Task6.V10.Lib;
//Написать программу, которая использует сокращенную форму записи оператора switch
//вычисляет требуемое значение и возвращает результат.
//Условие: Дата некоторого дня характеризуется тремя натуральными числами:
//g(год), m(порядковый номер месяца) и n(число).
//По заданным g, n и m определить дату предыдущего дня.
//Заданный год не является високосным.
namespace Tyuiu.TatarinovDA.Sprint2.Task6.V10
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами:*");
            Console.WriteLine("* g(год), m(порядковый номер месяца) и n(число).                          *");
            Console.WriteLine("* По заданным g, n и m определить дату предыдущего дня.                   *");
            Console.WriteLine("* Заданный год не является високосным.                                    *");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите год g : ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите месяц m : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите число n : ");
            int n = Convert.ToInt32(Console.ReadLine());


            string res = ds.FindDateOfPreviousDay(g,m,n);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine($"Предыдущая дата: {res}");


            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }

}
