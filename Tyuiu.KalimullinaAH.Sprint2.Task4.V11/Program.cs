using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KalimullinaAH.Sprint2.Task4.V11.Lib;
namespace Tyuiu.KalimullinaAH.Sprint2.Task4.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Калимуллина А.Х | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:Оператор if – полная и короткая форма записи                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Калимуллина Алина Халимовна | ИИПБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение c              *");
            Console.WriteLine("* использованием тернарного оператора , где пользователь вводит           *");
            Console.WriteLine("* значение переменной x,y с клавиатуры, (x - 20 * 2 < y / 4) ?            *");
            Console.WriteLine("*Math.Pow(3 + (8 / Math.Pow(x, 2)), y) : y - Math.Pow((x + 1)/(y + 2), x) *");

            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.Calculate(x, y);
            Console.WriteLine("Значение функции = " +res);

            Console.ReadKey();

        }
    }
}
