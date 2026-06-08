using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SklyarovAM.Sprint2.Task4.V15.Lib
{
    public class DataService : ISprint2Task4V15
    {
        public double Calculate(double x, double y)
        {
            double z = (Math.Sqrt(x) / 2.0 > Math.Sqrt(y) - 20.0)
                ? Math.Pow(3.0 + 2.0 / (y * y), x)   
                : Math.Cos(y) + 12.0 / (x * x);
            return Math.Round(z,3);
        }
    }
}
