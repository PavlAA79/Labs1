using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat2
{

    abstract class GeomFigure
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
            return this.Type + " площадью " + this.Area().ToString();
        }
    }


    interface IPrint
    {
        void Print();
    }


}
