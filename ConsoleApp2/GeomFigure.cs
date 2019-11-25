using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat2
{

    abstract class GeomFigure: IComparable
    {

        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;


        public abstract double Area();


        public override string ToString()
        {
            return base.ToString()+"";
        }
        public int CompareTo(object obj)
        {
            GeomFigure p = (GeomFigure)obj;
            if (this.Area() < p.Area()) return -1;
            else if (this.Area() == p.Area()) return 0;
            else return 1;
        }
    }


}
