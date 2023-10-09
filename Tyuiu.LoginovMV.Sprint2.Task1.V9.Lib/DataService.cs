using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LoginovMV.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b) | (c + 304 != d);
            res[1] = (a > b) & (d < c);
            res[2] = (a <= b) || (d >= c);
            res[3] = (a == b) && (c + 304 != d);
            res[4] = !(res[0]);
            res[5] = (a <= b) ^ (d >= c);
            return res;
        }
    }
}
