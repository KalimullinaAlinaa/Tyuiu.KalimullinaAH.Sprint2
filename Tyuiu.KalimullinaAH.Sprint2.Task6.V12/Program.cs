using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KalimullinaAH.Sprint2.Task6.V12.Lib;
namespace Tyuiu.KalimullinaAH.Sprint2.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Калимуллина А.Х | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Калимуллина Алина Халимовна | ИИПБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными         *");
            Console.WriteLine("* числами: g (год), m (порядковый номер месяца) и n (число). По заданным  *");
            Console.WriteLine("* g, n и m определить дату предыдущего дня. Заданный год является         *");
            Console.WriteLine("* високосным.                                                             *"); 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Предыдущая дата: " + ds.FindDateOfPreviousDay(g, m, n));

            Console.ReadKey();
        }
    }
}
