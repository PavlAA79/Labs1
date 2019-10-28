using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat2
{
    class Rectangle : GeomFigure, IPrint
    {
        double height;
        double width;

        public Rectangle(double a, double b)
        {
            this.height = a;
            this.width = b;
            this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            double S = this.width * this.height;
            return S;
        }

        public void Print()
        {
            string str = this.ToString() + " ширина=" + this.width.ToString() + " высота=" + this.height.ToString();
            Console.WriteLine(str);
        }
    }
}