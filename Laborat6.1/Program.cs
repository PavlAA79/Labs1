using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat6._1
{
   
    delegate double GeomOrArithm(string str,int i1,int i2);

    class Program
    {
        static double GeomMean(string str, int i1, int i2)
        {
                Console.WriteLine(str);
                return Math.Sqrt(Math.Abs(i1 * i2));
        }
        static double ArithmMean(string str, int i1, int i2)
        {
            Console.WriteLine(str);
            return ((i1 + i2) / 2);
        }
        static void ArithmMean1(string str, int i1, int i2)
        {
            Console.WriteLine("Среднее арифметическое: ");
          double Result = ((i1 + i2) / 2);
            Console.WriteLine(Result.ToString());
        }
        static void PrintGA(string str, int i1, int i2, GeomOrArithm func)
        {
            Console.WriteLine("i1 = " + i1.ToString() + ", i2 = " + i2.ToString());
            Console.WriteLine("Ответ:" + (func(str, i1, i2)).ToString());
        }
        static void PrintAction(string str, int i1, int i2, Action<string, int, int> GAparam)
        {
            Console.WriteLine("i1 = " + i1.ToString() + ", i2 = " + i2.ToString());
            GAparam(str, i1, i2);
        }

        
        static void Main(string[] args)
        {
            int i1 = 3;
            int i2 = 5;
            Console.WriteLine("Создание экземпляра делегата на основе метода: ");
            PrintGA("Среднее геометрическое: ",i1,i2, GeomMean);
            Console.WriteLine("\nСоздание экземпляра делегата на лямбда-выражения: ");
            PrintGA("Среднее арифметическое: ", i1, i2,
                (str, x, y) =>
                {
                    Console.Write(str);
                    return ((x + y) / 2);
                }
                );
            Console.WriteLine("\n\nИспользование обощенного делегата Action<>");
            Console.WriteLine("\nСоздание экземпляра делегата на основе метода: ");
            PrintAction("Ответ:",i1, i2, ArithmMean1);
            Console.WriteLine("\nСоздание экземпляра делегата на лямбда-выражения: ");
            PrintAction("Cреднее геометрическое: ", i1, i2,
            (string str, int x, int y) =>
            {
                Console.WriteLine(str + Math.Sqrt(Math.Abs(i1 * i2)).ToString());
            }
            );
            Console.ReadKey();
        }
    }
}
