using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat2
{
    class Circle : GeomFigure, IPrint
    {

        double R;

        public Circle(double a)
        {
            this.R = a;
            this.Type = "Круг";
        }
        public override double Area()
        {
            double S = Math.PI * this.R * this.R;
            return S;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}