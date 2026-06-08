using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SklyarovAM.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = 0;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;

                case 2:
                    daysInMonth = 28;
                    break;

                default:
                    daysInMonth = 0;
                    break;
            }
            if (daysInMonth == 0 || n < 1 || n > daysInMonth)
            {
                return "Неверная дата";
            }
            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                if (m < 12)
                {
                    m++;
                }
                else
                {
                    m = 1;
                    g++;
                }
            }
            return $"{n:D2}.{m:D2}.{g}";
        }
    }
}
