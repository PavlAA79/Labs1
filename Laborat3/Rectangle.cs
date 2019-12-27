using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat3
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

        public override string ToString()
        {
            return (Type.ToString() + ": ширина = " + width + ", высота = " + height + ", площадь = " + Area());
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}