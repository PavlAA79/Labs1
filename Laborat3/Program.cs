using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Laborat2
{

    class Program
    {
        static void Main(string[] args)
        {
            Circle obj1 = new Circle(3);
            Rectangle obj2 = new Rectangle(5, 10);
            Square obj3 = new Square(5);
            ArrayList arrl = new ArrayList();
            arrl.Add(obj1);
            arrl.Add(obj2);
            arrl.Add(obj3);

            foreach (var x in arrl) Console.WriteLine(x);
            arrl.Sort();
            foreach (var x in arrl) Console.WriteLine(x);

            List<GeomFigure> LF = new List<GeomFigure>();
            LF.Add(obj1);
            LF.Add(obj2);
            LF.Add(obj3);
            foreach (var x in LF) Console.WriteLine(x);
            LF.Sort();
            foreach (var x in LF) Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
