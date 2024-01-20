using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Angle
    {
        double gradus_;
        double min_;
        double sec_;

        public double Gradus
        {
            get { return gradus_; }
            set 
            { 
                gradus_ = value; 
            }
        }

        public double Min
        {
            get { return min_; }
            set 
            {
                Gradus += (value / 60);
                min_ = value % 60;
            }
        }

        public double Sec
        {
            get { return sec_; }
            set
            {
                Min += (value / 60);
                sec_ = value % 60;
            }
        }

        public Angle(double gradus, double min, double sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public double ToRadans()
        {
            return (Math.PI / 180.0 * (Gradus + (Min / 60.0) + (Sec / 3600.0)));
        }
    }
}
