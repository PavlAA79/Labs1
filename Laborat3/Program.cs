using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Laborat3
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка геометрических фигур ");
            Circle obj1 = new Circle(3);
            Rectangle obj2 = new Rectangle(5, 10);
            Square obj3 = new Square(5);
            
            Console.WriteLine("\n\nПример работы класса ArrayList");
            ArrayList arr = new ArrayList();
            arr.Add(obj1);
            arr.Add(obj2);
            arr.Add(obj3);
            Console.WriteLine("\nДо сортировки:");
            foreach (GeomFigure f in arr) Console.WriteLine(f);
            arr.Sort();
            Console.WriteLine("\nПосле сортировки:");
            foreach (GeomFigure f in arr) Console.WriteLine(f);

            Console.WriteLine("\n\nПример работы класса List<T>");
            List<GeomFigure> LF = new List<GeomFigure>();
            LF.Add(obj1);
            LF.Add(obj2);
            LF.Add(obj3);
            Console.WriteLine("\nПеред сортировкой:");
            foreach (var x in LF) Console.WriteLine(x);
            LF.Sort();
            Console.WriteLine("\nПосле сортировки:");
            foreach (var x in LF) Console.WriteLine(x);

            Console.WriteLine("\n\nПример работы класса SimpleList");
            SimpleList<GeomFigure> list = new SimpleList<GeomFigure>();
            list.Add(obj1); list.Add(obj2); list.Add(obj3);
            Console.WriteLine("\nПеред сортировкой:");
            foreach (var x in list)
                Console.WriteLine(x); //сортировка 
            list.Sort();
            Console.WriteLine("\nПосле сортировки:");
            foreach (var x in list)
                Console.WriteLine(x);

            Console.WriteLine("\n\nПример работы класса SimpleStack ");
            SimpleStack<GeomFigure> stack = new SimpleStack<GeomFigure>();
            //добавление данных в стек 
            stack.Push(obj1); stack.Push(obj2); stack.Push(obj3);
            //чтение данных из стека
            while (stack.Count > 0)
            {
                GeomFigure f = stack.Pop();
                Console.WriteLine(f);
            }

           Console.WriteLine("\n\nПример работы класса Matrix3");

            Matrix3<GeomFigure> matrix = new Matrix3<GeomFigure>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = obj1;
            matrix[1, 1, 1] = obj2;
            matrix[2, 2, 2] = obj3;
            Console.WriteLine(matrix.ToString());

            Console.ReadKey();
        }
    }
}
