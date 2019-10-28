using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorn1
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

            if ((a == 0) & (b == 0))
            {
                WriteColor("Корней нет", 1);
            }

            if ((a == 0) & (b != 0))
            {
                double x = -c / b;
                WriteColor("R=" + x, 0);
            }
            if ((b == 0) & (a != 0))
            {
                double x1 = Math.Sqrt(Math.Abs(-c / a));
                double x2 = -Math.Sqrt(Math.Abs(-c / a));
                WriteColor("R1=" + x1 + ", R2=" + x2, 0);
            }

            if ((a != 0) & (b != 0))
            {
                double D = b * b - 4 * a * c;

                if (D == 0)
                {
                    double R = -b / (2 * a);
                    WriteColor("R=" + R + ", D=" + D, 0);

                }
                else if (D > 0)
                {
                    double R1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double R2 = (-b - Math.Sqrt(D)) / (2 * a);
                    WriteColor("R1=" + R1 + ", R2=" + R2 + ", D=" + D, 0);

                }
                else if (D < 0)
                {
                    WriteColor("Корней нет", 1);
                }

            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Павловская Анастасия ИУ5-31Б");
            Console.WriteLine("Ax^2+Bx+C=0");
            string k = "y";
            do
            {
                double a = 0, b = 0, c = 0;
                Console.WriteLine("Введите коэффициенты A, B, C");

                if (args.Length == 0)
                {
                    bool e = true;
                    do
                    {
                        Console.Write("A = ");
                        e = double.TryParse(Console.ReadLine(), out a);
                        //ф = double.Parse(args[0]); - для командной строки
                        if (!e) WriteColor("Ошибка!Введите число", 1);
                    }
                    while (!e);
                    do
                    {
                        Console.Write("B = ");
                        e = double.TryParse(Console.ReadLine(), out b);
                        if (!e) WriteColor("Ошибка!Введите число", 1);
                    }
                    while (!e);
                    do
                    {
                        Console.Write("C = ");
                        e = double.TryParse(Console.ReadLine(), out c);
                        if (!e) WriteColor("Ошибка!Введите число", 1);
                    }
                    while (!e);
                }
                else if (args.Length != 0)
                {
                    bool e1 = true;
                    bool e = true;
                    do
                    {
                        Console.Write("A = ");
                        if (e1)
                            e = double.TryParse(args[0], out a);
                        else e = double.TryParse(Console.ReadLine(), out a);
                        if (!e) { WriteColor("Ошибка!Введите число", 1); e1 = false; }
                    }
                    while (!e);
                    e1 = true;
                    do
                    {
                        Console.Write("B = ");

                        if (e1)
                            e = double.TryParse(args[1], out b);
                        else e = double.TryParse(Console.ReadLine(), out b);
                        if (!e) { WriteColor("Ошибка!Введите число", 1); e1 = false; }
                    }
                    while (!e);
                    e1 = true;
                    do
                    {
                        Console.Write("C = ");
                        if (e1)
                            e = double.TryParse(args[2], out c);
                        else e = double.TryParse(Console.ReadLine(), out c);
                        if (!e) { WriteColor("Ошибка!Введите число", 1); e1 = false; }
                    }
                    while (!e);
                }
                Program.QEquat(a, b, c);
                Console.WriteLine("Продолжить?(y/n)");
                k = Console.ReadLine();

            } while (k == "y");
            Console.ReadKey();
        }

    }
}
