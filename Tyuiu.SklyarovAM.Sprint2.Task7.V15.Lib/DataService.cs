using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SklyarovAM.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double distanceSquared = x * x + y * y;
            if (y >= 0 && distanceSquared >= 1 && distanceSquared <= 4)
            {
                return true;
            }
            else
            {  
                return false; 
            }
        }
    }
}
