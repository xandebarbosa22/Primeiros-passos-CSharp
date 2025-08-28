using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course10
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
            /*
            Também pode ser feito assim:

            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area; 
            */
        }
    }
}
