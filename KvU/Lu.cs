using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvU
{
    public class Ku
    {
        /// <summary>
        /// Линейное уравнение
        /// </summary>
        /// <param name="k">стоит у неизвестной X</param>
        /// <param name="m">второе значение рядом</param>
        /// <returns>Чему равен х выводит</returns>
        public static string Liu(double k, double m)
        {
            double x=0;
            double y = k * x + m;
            if (y > 0)
            {
                x = (y - m )/ k;
                return $"Корень = {x} ";
            }
            else if (y < 0)
            {
                x = (y - m) / k;
                return $"Корень = {x} ";
            }
            else if (y == 0)
            {
                return $"Корень = любое число";
            }
            else
            {
                return "Корней нет";
            }
        }
    }
}
