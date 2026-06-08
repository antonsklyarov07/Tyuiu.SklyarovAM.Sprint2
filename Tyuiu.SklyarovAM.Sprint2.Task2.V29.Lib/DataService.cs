using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SklyarovAM.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((y >= 3 && y <= 4) && (x >= 3 && x <= 5)) || ((y == 4) && (x >= 1 && x <= 2)) || ((y >= 5 && y <= 7) && (x >= 3 && x <= 9)) || ((y >= 8 && y <= 11) && (x == 6)) || ((y == 11 && x >= 3 && x <= 5) || ((y == 12 && x >= 4 && x <= 5)) || (y >= 3 && y <= 12) && (x >= 10 && x <= 13)) || ((y >= 3 && y <= 12) && (x >= 10 && x <= 13)) || ((y >= 6 && y <= 7) && (x == 14)) || ((y == 8) && (x == 14)))
            {
                return res = true;
            }
            else
            { 
                 return res = false;
            }
        }
    }
}
