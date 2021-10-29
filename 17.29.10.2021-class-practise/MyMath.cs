using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._29._10._2021_class_practise
{
    class MyMath
    {
        public int Pow(int x, int y)
        {
            int product = 1;
            for (int i = 0; i < y; i++)
            {
                product *= x;
            }
            return product;
        }

        public double Pow(double x, double y)
        {
            double product = 1;
            for (int i = 0; i < y; i++)
            {
                product *= x;
            }
            return product;
        }
    }
}
