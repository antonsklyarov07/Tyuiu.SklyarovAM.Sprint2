using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SklyarovAM.Sprint2.Task3.V14.Lib
{
    public class DataService : ISprint2Task3V14
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                return y = x - Math.Pow((x + 1) / (x - 1), 3);
            }
            else if (x == 0)
            {
                double numerator = 3 * Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 3)) + 10;
                double denominator = 4 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 4)) + 12;
                return y = numerator / denominator;
            }
            else if (x > -18 && x < 2)
            {
                if (x == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль в третьей формуле!");
                    return 0;
                }
                return y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }
            else if (x < -18)
            {
                return y = x + 10 * x - (1 / x);
            }
            else
            {
                return 0;
            }
        }
    }
}
