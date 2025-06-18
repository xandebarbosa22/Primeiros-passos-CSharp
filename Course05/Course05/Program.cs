using System;

namespace Course05
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8;       // Ou usar o casting (double) na frente do 10 para que o resultado seja 1,25 e não seja truncado.

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;    // A expressão "Math.Pow()" serve para calcular potência (power). Também pode ser usado (b * b).

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);    // A expressão "Math.Sqrt()" serve para calcular raiz quadrada (square root).
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}