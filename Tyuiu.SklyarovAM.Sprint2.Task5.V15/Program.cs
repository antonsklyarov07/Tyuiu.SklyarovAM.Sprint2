using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SklyarovAM.Sprint2.Task5.V15.Lib;

namespace Tyuiu.SklyarovAM.Sprint2.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите день года 1 - 365:");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            string res;
            if((dayNumber < 1) ||(dayNumber > 365))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это: " + ds.FindDayName(dayNumber);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
