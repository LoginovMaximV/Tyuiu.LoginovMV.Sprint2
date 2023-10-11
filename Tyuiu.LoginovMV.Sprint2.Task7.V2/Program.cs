using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint2.Task7.V2.Lib;

namespace Tyuiu.LoginovMV.Sprint2.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                    *");
            Console.WriteLine("* Задание #7                                                                                                 *");
            Console.WriteLine("* Вариант #2                                                                                                 *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные значения)                      *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.                               *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            double x, y;
            Console.WriteLine("Введите координату Х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Точка попадает в заштрихованную область");
            }
            else
            {
                Console.WriteLine("Точка не попадает в заштрихованную область");
            }
            Console.ReadKey();
        }
    }
}
