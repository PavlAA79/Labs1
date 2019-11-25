using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat2
{
    class Square : Rectangle, IPrint
    {
        public Square(double a) : base(a, a)
        {
            this.Type = "Квадрат";
        }

    }
}