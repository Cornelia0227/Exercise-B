using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exciese_B
{
    class Class_B10
    {
        public void B10()
        {
            double[] s= new double[3];
            Console.WriteLine("Please Input the lengths of a triangle's 3 sides(a,b,c):");
            for (int i = 0; i < 3; i++)
            {
                s[i] = Convert.ToDouble(Console.ReadLine());
            }
            double S = (s[0]+s[1]+s[2]) / 2;
            if (S > s[0] && S > s[1] && S > s[2])
            {
                Console.WriteLine("The Area of the Triangle is:   {0:###}", Math.Sqrt(S * (S - s[0]) * (S - s[1]) * (S - s[2])));
            }
            else { Console.WriteLine("The lengths of the triangle are wrong!\nThe area cannot not be computed!"); }
        }
    }
}
