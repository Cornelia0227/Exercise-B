using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exciese_B
{
    class Class_B6
    {
        public void B6() //求平方再开方的结果（距离）
        {
            double[] x1 = new double[3] { 0, 0, 1 };
            double[] x2 = new double[3] { 0, 10, 10 };
            double[] y1 = new double[3] { 0, 0, 1 };
            double[] y2 = new double[3] { 0, 10, 1 };
            double [] D = new double[3];
            int i = 0;
            while (i<=2)
            {
                D[i] = Math.Sqrt(Math.Pow((x2[i] - x1[i]), 2) + Math.Pow((y2[i] - y1[i]), 2));
                i++;
            }
            Console.Write("Distance={0}\n\t {1}\n\t {2}",D[0],D[1],D[2]);
        }
    }
}
