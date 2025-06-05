using System;

namespace Course04
{
    class Program
    {
        static void Main(string[] args)
        {

            // Conversão implícita entre tipos de variáveis:

            float a = 4.5f;
            double b = a;

            Console.WriteLine(b);

            // Casting -> Conversão explícita entre tipos de variáveis COMPATÍVEIS:

            double c = 2.5;
            float d = (float) c;

            Console.WriteLine(d);

            int e = (int) c;        // Quando convertemos uma variável float ou double para int, os valores decimais vão ser "Truncados"

            Console.WriteLine(e);

            int val1 = 5;
            int val2 = 2;
            double res = (double) val1 / val2;      // Se não usar o "Casting", o compilador só vai fazer o cálculo dos números inteiros.

            Console.WriteLine(res);


        }
    }
}