﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KalimullinaAH.Sprint2.Task5.V6.Lib;
namespace Tyuiu.KalimullinaAH.Sprint2.Task5.V6
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
            Console.WriteLine("* требуемое значение и возвращает результат.                     *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3,                 *");
            Console.WriteLine("* масти «червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12,      *");
            Console.WriteLine("*«королю» — 13, «тузу» — 14 (порядковые номера карт остальных достоинств  *");
            Console.WriteLine("*  соответствуют их названиям: «шестерка», «девятка» и т. п.).            *");
            Console.WriteLine("*  По заданным номеру масти m (1 <= m <= 4) и номеру достоинства карты    *");
            Console.WriteLine("* k (6 <= k <= 14) определить полное название (масть и достоинство)       *");
            Console.WriteLine("* соответствующей карты в виде «Дама пик», Шестерка бубен» и т. п.        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер масти: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер достоинства карты: ");
            int k = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.FindCardNameAndValue(n, k);
            Console.WriteLine(" Название карты = " + res);

            Console.ReadKey();
        }
    }
}
