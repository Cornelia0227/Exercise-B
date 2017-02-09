using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exciese_B
{
    class Class_B4
    {
        public void B4(double[] x)  //摄氏度-->华氏度
        {
            Console.WriteLine("Exciese B-<4>");
            Console.WriteLine("Centigrade： {0}\t{1}\t{2}", x[0], x[1], x[2]);
            Console.WriteLine("Fahrenheit： {0:##}\t{1:###}\t{2:###}", (x[0]*1.8+32), (x[1] * 1.8 + 32), (x[2] * 1.8 + 32));
        }
    }
}
