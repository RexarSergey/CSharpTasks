using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal struct Linear
    {
        double k_;
        double b_;

        public Linear(double k, double b)
        {
            k_ = k;
            b_ = b;
        }

        public string Root()
        {
            if (k_ == 0 && b_ == 0)
            {
                return "Бесконечное множество решений";
            }
            else if (k_ == 0)
            {
                return "Решений нет";
            }
            else if (b_ == 0)
            {
                return "x = 0";
            }

            return $"x = {-b_ / k_:F2}";
        }
    }
}
