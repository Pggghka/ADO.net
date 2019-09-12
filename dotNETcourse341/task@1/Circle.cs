using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Circle
    {
        private double x, y, r;
        public double Radius
        {
            get
            {
                return r;
            }

            set
            {
                if (value <= 0) { throw new ArgumentException(" Wrong radius!"); }
                r = value;
            }
        }

        public double GetArea
        {
            get
            {
                return Math.PI * r * r;
            }
        }

        public double Length
        {
            get
            {
                return 2 * Math.PI * r;
            }
        }

        public double X
        {
            set
            {
                this.x = value;
            }
            get
            {
                return x;
            }
        }

        public double Y
        {
            set
            {
                this.y = value;
            }
            get
            {
                return y;
            }
        }
    }
}
