using System;
using System.Globalization;

namespace Course09
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetTeste = new double[3];
            int i = 0;

            while (i < 3)
            {
                vetTeste[i] = double.Parse(Console.ReadLine());

                i++;
            }

            double maior = vetTeste.Max();
            Console.WriteLine(maior);
        }

        //static int funcMaior(int a, int b, int c)
        //{
        //    int maior;
        //    if (a >= b && a >= c)
        //    {
        //        maior = a;
        //    }
        //    else if (b > c)
        //    {
        //        maior = b;
        //    }
        //    else
        //    {
        //        maior = c;
        //    }
        //    return maior;
        //}
    }
}