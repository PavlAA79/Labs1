using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle obj1 = new Circle(3);
            Rectangle obj2 = new Rectangle(5, 10);
            Square obj3 = new Square(5);
            Console.WriteLine("\nМатрица");
            Matrix3<GeomFigure> matrix = new Matrix3 <GeomFigure>(3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = obj1;
            matrix[1, 1, 1] = obj2;
            matrix[2, 2, 2] = obj3;
            Console.WriteLine(matrix.ToString());
        }
    }
}
