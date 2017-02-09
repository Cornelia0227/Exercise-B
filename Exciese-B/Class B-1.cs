using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exciese_B
{
    class Class_B1
    {
        public void B1(double[] x)  //取平方
        {
            //double[] x = new double[3] /*{0,25,3}*/;
            Console.WriteLine("Exciese B-<1>");
            Console.WriteLine("Number： {0}\t{1}\t{2}",x[0],x[1],x[2]);
            Console.WriteLine("Square： {0}\t{1}\t{2:#.00}",Math.Sqrt(x[0]), Math.Sqrt(x[1]), Math.Sqrt(x[2]));
        }
    }
}
