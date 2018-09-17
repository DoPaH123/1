using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            second(_1_1());
        }
        static double[] _1_1 ()
            {

            Random r = new Random();
            double[] rarr = new double[10];
            for (int i = 0; i < rarr.Length; i++)
            {
                rarr[i] = r.NextDouble();
            }
            Console.WriteLine("Введите а");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = int.Parse(Console.ReadLine());
            double[] y = new double[10];
            for (int i = 0; i < rarr.Length; i++)
            {
                y[i] = a + rarr[i] * (b - a);
            }
            for (int i = 0; i < rarr.Length; i++)
            {
                Console.Write(y[i] + " ");
            }
            Console.WriteLine();
            return y;
        }
        static double[] _1_2()
        {
            Random r = new Random();
            double[] rarr = new double[10];
            for (int i = 0; i < rarr.Length; i++)
            {
                rarr[i] = r.NextDouble();
            }
            Console.WriteLine("Введите lambda");
            double l = int.Parse(Console.ReadLine());
            double[] tau = new double[10];
            for (int i = 0; i < rarr.Length; i++)
            {
                tau[i] = (-1 / l) * Math.Log(rarr[i]);
            }
            for (int i = 0; i < rarr.Length; i++)
            {
                Console.Write(tau[i] + " ");
            }
            Console.WriteLine();
            return tau;
        }
        static void _1_3()
        {
            Random r = new Random();
            double[] rarr = new double[12];
            for (int i = 0; i < rarr.Length; i++)
            {
                rarr[i] = r.NextDouble();
            }
            Console.WriteLine("Введите gamma");
            double g = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите omega");
            double o = int.Parse(Console.ReadLine());
            double y = 0;
            for (int i = 0; i < rarr.Length; i++)
            {
                y += (rarr[i] - 6);
            }
            y *= o;
            y += g;
            Console.WriteLine(y);

        }
        static void second(double[]a)
        {
            double m = 0;
            for(int i=0;i<a.Length;i++)
            {
                m += a[i];
            }
            m /= a.Length;
            Console.WriteLine(m);
            double D = 0;
            for (int i = 0; i < a.Length; i++)
            {
                D += Math.Pow((a[i] - m), 2);
            }
            D *= 1.0 / ( a.Length-1);
            Console.WriteLine(D);
        }

    }
}
