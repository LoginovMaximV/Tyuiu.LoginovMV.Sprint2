using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint2.Task2.V25.Lib;

namespace Tyuiu.LoginovMV.Sprint2.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                  *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                                                         *");
            Console.WriteLine("* Задание #2                                                                                                 *");
            Console.WriteLine("* Вариант #25                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет                         *");
            Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int x;
            Console.WriteLine("Введите координату Х:");
            x = Convert.ToInt32(Console.ReadLine());
            int y;
            Console.WriteLine("Введиет координату У:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            bool res;
            res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Точка попадает в закрашенную область");
            }
            else
            {
                Console.WriteLine("Точка не попадает в закрашенную область");
            }
            Console.ReadKey();
        }
    }
}
