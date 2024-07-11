using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    internal struct Point
    {
        public double x;
        public double y;

        public Point(double X, double Y)
        {
            x= X;
            y= Y;
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
    }
}
