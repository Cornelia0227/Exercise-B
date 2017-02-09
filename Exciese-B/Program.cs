using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exciese_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习B-1
            Class_B1 b1 = new Class_B1();
            double[] a = new double[3] {0,25,3};
            b1.B1(a);
            Console.WriteLine("\n\n");

            //练习B-2
            Class_B2 b2 = new Class_B2();
            double[] aa = new double[4] {0,25,3,300};
            b2.B2(aa);
            Console.WriteLine("\n\n");

            //练习B-3
            Class_B3 b3 = new Class_B3();
            double[] aaa = new double[3] { 1000, 0, 2000};
            b3.B3(aaa);
            Console.WriteLine("\n\n");

            //练习B-4
            Class_B4 b4 = new Class_B4();
            double[] c = new double[3] { 0, -100, 100 };
            b4.B4(c);
            Console.WriteLine("\n\n");

            //练习B-5
            Class_B5 b5 = new Class_B5();
            double[] y = new double[3] { b5.B5(0), b5.B5 (-100), b5.B5(100)};

            Console.WriteLine("Exciese B-<5>");
            Console.WriteLine("Formula: y = 5x*x - 4x + 3");
            Console.WriteLine("Input  x : 0\t-100\t100");
            Console.WriteLine("Output y : {0:#}\t{1:##}\t{2:##}\t",y[0],y[1],y[2]);
            Console.WriteLine("\n\n");

            //练习B-6
            Console.WriteLine("Exciese B-<6>");
            Class_B6 b6 = new Class_B6();
            b6.B6();
            Console.WriteLine("\n\n");

            //练习B-7,8,9
            Class_B789 b789 = new Class_B789();
            b789.B789();
            Console.WriteLine("\n\n");

            //练习B-10
            Class_B10 b10 = new Class_B10();
            b10.B10();



           // double zzz = Math.Round(5.55, 1);
           // Console.WriteLine(zzz);
            Console.ReadLine();
        }
    }
}
