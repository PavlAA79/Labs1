using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat1
{
    class Program
    {
        static void WriteColor(string st, int color)
        {
            if (color == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(st);
                Console.ResetColor();
            }
            if (color == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(st);
                Console.ResetColor();
            }
        }

        static void QEquat(double a, double b, double c)
        {
            //hgulghjgkjg
            if ((a == 0) & (b == 0))
            {
                WriteColor("Нет корней", 1);
            }

            if ((a == 0) & (b != 0))
            {
                double x = -c / b;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("R={0}", x);
                Console.ResetColor();
            }
            if ((b == 0) & (a != 0))
            {
                double x1 = Math.Sqrt(Math.Abs(-c / a));
                double x2 = -Math.Sqrt(Math.Abs(-c / a));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("R1={0},R2={1}", x1, x2);
                Console.ResetColor();
            }
            if ((a != 0) & (b != 0))
            {
                double D = b * b - 4 * a * c;

                if (D == 0)
                {
                    double R = -b / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("R={0}, D={1}", R, D);
                    Console.ResetColor();
                }
                else if (D > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    double R1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double R2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("R1={0}, R2={1}, D={2}", R1, R2, D);
                    Console.ResetColor();
                }
                else if (D < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет");
                    Console.ResetColor();
                }

            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Павловская Анастасия ИУ5-31Б");
            double a = 0, b = 0, c = 0;
            Console.WriteLine("Ax^2+Bx+C=0");
            Console.WriteLine("Введите коэффициенты A, B, C");


            bool e = true;
            do
            {
                Console.Write("A = ");
                e = double.TryParse(Console.ReadLine(), out a);
                //ф = double.Parse(args[0]); - для командной строки
                Console.ForegroundColor = ConsoleColor.Red;
                if (!e) Console.WriteLine("Ошибка!Введите число");
                Console.ResetColor();
            }
            while (!e);
            do
            {
                Console.Write("B = ");
                e = double.TryParse(Console.ReadLine(), out b);
                Console.ForegroundColor = ConsoleColor.Red;
                if (!e) Console.WriteLine("Ошибка!Введите число");
                Console.ResetColor();
            }
            while (!e);
            do
            {
                Console.Write("C = ");
                e = double.TryParse(Console.ReadLine(), out c);
                Console.ForegroundColor = ConsoleColor.Red;
                if (!e) Console.WriteLine("Ошибка!Введите число");
                Console.ResetColor();
            }
            while (!e);
            Program.QEquat(a, b, c);
            Console.ReadKey();
        }
    }
}
