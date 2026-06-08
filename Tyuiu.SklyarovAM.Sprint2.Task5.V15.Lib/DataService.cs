using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SklyarovAM.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            int dayOfWeekNumber = k % 7;
            string dayName;

            switch (dayOfWeekNumber)
            {
                case 1:
                    return dayName = "понедельник";
                    break;
                case 2:
                    return dayName = "вторник";
                    break;
                case 3:
                    return dayName = "среда";
                    break;
                case 4:
                    return dayName = "четверг";
                    break;
                case 5:
                    return dayName = "пятница";
                    break;
                case 6:
                    return dayName = "суббота";
                    break;
                case 0:
                    return dayName = "воскресенье";
                    break;
                default:
                    return dayName = "неизвестный день";
                    break;
            }
        }
    }
}
