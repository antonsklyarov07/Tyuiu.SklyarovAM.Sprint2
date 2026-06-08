using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SklyarovAM.Sprint2.Task6.V11.Lib;
namespace Tyuiu.SklyarovAM.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindDateOfNextDay(g, m, n);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Дата следующего дня: " + res);
            Console.ReadKey();
        }
    }
}
