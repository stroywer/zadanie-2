using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU
{
    public class Ku
    {
        /// <summary>
        /// Корни квад урав
        /// </summary>
        /// <param name="a">первый</param>
        /// <param name="b">второй</param>
        /// <param name="c">третий</param>
        /// <returns>Результат</returns>
        public static string KvU(double a, double b, double c)
        {
            double x1, x2;
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return $"Корень 1 = {x1},  Корень 2 = {x2} ";
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                return $"Корень = {x1}";
            }
            else
            {
                return "Корней нет";
            }
        }
    }
}
