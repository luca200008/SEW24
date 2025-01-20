using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Properties
{
    internal class Rectangle
    {
        private double a;
        private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double A
        {
            get
            {
                return this.a;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this.a = value;
            }

        }
        public double GetA()    //getter
        {
            return this.a;
        }
        public void SetA(double newValue)       //setter
        {
            if (newValue < 0)
            {
                return;
            }
            this.a = newValue;
        }
        public double Area()
        {
            return a * b;
        }
        public double Circumference()
        {
            return 2 * a + 2 * b;
        }
        public void ResizeArea(double factor)
        {


            this.a = this.Area() * Math.Sqrt(factor) / b;
            this.b = this.Area() * Math.Sqrt(factor) / a;



        }
        public void ResizeSideLength(double dactor)
        {
            this.a = this.a * 2;
            this.b = this.b * 2;
        }
    }
}
