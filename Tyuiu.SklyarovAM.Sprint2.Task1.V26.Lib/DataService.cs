using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SklyarovAM.Sprint2.Task1.V26.Lib
{
    public class DataService
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) || (c > d);
            res[1] = (a <= c) && (b >= d);
            res[2] = !(!res[0]);
            res[3] = (a != b) ^ (c != d);
            res[4] = (a + 23 > b) | (c < d + 736);
            res[5] = (a == b) & (c == d);
            return res;
        }
    }
}
