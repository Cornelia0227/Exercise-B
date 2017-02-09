using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exciese_B
{
    class Class_B3
    {
        public void B3(double[] x)  //工资*113%
        {
            Console.WriteLine("Exciese B-<3>");
            Console.WriteLine(" Salary： {0}\t\t{1}\t\t{2}", x[0], x[1], x[2]);
            Console.WriteLine("Benefit： {0:#.00}\t{1:0.00}\t{2:#.00}", x[0] * 1.13, x[1] * 1.13, x[2] * 1.13);
        }
    }
}
