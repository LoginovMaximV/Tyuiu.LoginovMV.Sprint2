﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint2.Task5.V10.Lib;

namespace Tyuiu.LoginovMV.Sprint2.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                  *");
            Console.WriteLine("* Тема: Оператор switch                                                                                      *");
            Console.WriteLine("* Задание #5                                                                                                 *");
            Console.WriteLine("* Вариант #10                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат.*");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами: g(год), m(месяц), n(день)         *");
            Console.WriteLine("* По заданным g, n и m определить дату предыдущего дня. Заданный год не является високосным.                 *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int g, m, n;
            Console.WriteLine("Введите невисокосный год:");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день:");
            n = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((m>12)||(m<1))
            {
                res = "Введено неверное значение месяца, введите значение от 1 до 12";
            }
            else if ((n < 1) || (n > 31))
            {
                res = "Введено неверное значение дня, введите значение от 1 до 31";
            }
            else if ((n>28)&&(m==2))
            {
                res = "В Феврале всего 28 дней!!!";
            }
            else if ((n>30)&&((m==4)||(m==6)||(m==9)||(m==11)))
            {
                res = "В Апреле, Июне, Сентябре и Ноябре всего 30 дней!!!";
            }
            else if ((g % 4 == 0) && (g % 100 == 0) && (g % 400 == 0))
            {
                res = "Заданный год является високосным, введите не високосный год";
            }
            else
            {
                res = ds.FindDateOfPreviousDay(g, m, n);
            }
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("Дата предыдущего дня:" + res);
            Console.ReadKey();

        }
    }
}
