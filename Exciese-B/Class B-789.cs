using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exciese_B
{
    class Class_B789
    {
        public void B789()  //Taxi fee 3 types
        {
            double[] km = new double[3] { 0, 3.3, 10.23 };
            int i = 0;
            Console.WriteLine("Exciese B-<7>");  //原始数据
            Console.WriteLine("Travel Distance: {0}\t{1}\t{2}",km[0],km[1],km[2]);

            double[] Fee = new double[3];

            while (i <= 2)
            {
                Fee[i] = 2.40 + km[i] * 0.40;
                i++;
            }
            Console.WriteLine("Total Fare:\t{0}\t{1}\t{2}",Fee[0],Fee[1],Fee[2]);
            Console.WriteLine("\n");

            Console.WriteLine("Exciese B-<8>");  //四舍五入
            Console.WriteLine("Total Fare:\t{0:#.00}\t{1}\t{2}", Math.Round(Fee[0],2), Math.Round(Fee[1],2), Math.Round(Fee[2],2));
            Console.WriteLine("\n");

            Console.WriteLine("Exciese B-<9>");  //向上取值
            Console.WriteLine("Total Fare:\t{0}\t{1}\t{2}", Math.Ceiling(Fee[0]*10)/10, Math.Ceiling(Fee[1]*10)/10, Math.Ceiling(Fee[2]*10)/10);
        }
    }

}
