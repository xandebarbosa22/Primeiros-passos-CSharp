using System;
using System.Globalization;

namespace Course09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números inteiros:");

            int num1, num2, num3;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            int resultado = funcMaior(num1, num2, num3);

            Console.WriteLine($"O maior número é: {resultado}");
        }

        static int funcMaior(int a, int b, int c)
        {
            int maior;
            if (a >= b && a >= c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }
            return maior;
        }
    }
}