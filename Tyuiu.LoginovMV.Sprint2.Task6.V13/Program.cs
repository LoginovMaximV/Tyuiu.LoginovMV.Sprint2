﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint2.Task6.V13.Lib;

namespace Tyuiu.LoginovMV.Sprint2.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                  *");
            Console.WriteLine("* Тема: Получение результата из switch                                                                       *");
            Console.WriteLine("* Задание #6                                                                                                 *");
            Console.WriteLine("* Вариант #13                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая использует сокращенный оператор switch и вычисляет требуемое значение и        *");
            Console.WriteLine("* возвращает результат.                                                                                      *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами: g(год), m(месяц), n(день)         *");
            Console.WriteLine("* По заданным g, n и m определить дату следующего дня. Заданный год является високосным.                  *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int g, m, n;
            Console.WriteLine("Введите високосный год:");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день:");
            n = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((m > 12) || (m < 1))
            {
                res = "Введено неверное значение месяца, введите значение от 1 до 12";
            }
            else if ((n < 1) || (n > 31))
            {
                res = "Введено неверное значение дня, введите значение от 1 до 31";
            }
            else if ((n > 29) && (m == 2))
            {
                res = "В Феврале всего 29 дней!!!";
            }
            else if ((n > 30) && ((m == 4) || (m == 6) || (m == 9) || (m == 11)))
            {
                res = "В Апреле, Июне, Сентябре и Ноябре всего 30 дней!!!";
            }
            else if ((g%4==0) && (g % 100 == 0) && (g % 400 == 0))
            {
                res = ds.FindDateOfNextDay(g, m, n);
            }
            else
            {
                res = "Год не високосный, введите високосный год";
            }
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("Дата следующего дня:" + res);
            Console.ReadKey();

        }
    }
}
