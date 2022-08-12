using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    struct Result
    {
        double k;
        double b;

        public Result(double k, double b)
        {
            this.k = k; 
            this.b = b;
        }

        public string Root()
        {
            if (k == 0 && b != 0)
                return "Решений нет";
            if (k == 0 && b == 0)
                return "х - любое значение";
            double r = -b / k;
                return $"Решение = {r}";
        }

    }
}
