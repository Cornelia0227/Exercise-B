using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exciese_B
{
    class Class_B2
    {
        public void B2(double[] x)  //取平方(3 dgit)
        {
            Console.WriteLine("Exciese B-<2>");
            Console.WriteLine("Number： {0}\t{1}\t{2}\t{3}", x[0], x[1], x[2], x[3]);
            Console.WriteLine("Square： {0:0.000}\t{1:#.000}\t{2:#.000}\t{3:#.000}", Math.Sqrt(x[0]), Math.Sqrt(x[1]), Math.Sqrt(x[2]), Math.Sqrt(x[3]));
        }
    }
}
