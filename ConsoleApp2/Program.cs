using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle obj1 = new Circle(3);
            Console.WriteLine(obj1.Area());
            obj1.Print();
            Rectangle obj2 = new Rectangle(5, 10);
            Console.WriteLine(obj2.Area());
            obj2.Print();
            Square obj3 = new Square(5);
            Console.WriteLine(obj3.Area());
            obj3.Print();
            Console.ReadKey();
        }
    }
}
