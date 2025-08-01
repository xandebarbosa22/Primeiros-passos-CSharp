using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro entre 1 e 1000: ");
            int num = int.Parse(Console.ReadLine());
            int impares = 0;

            Console.WriteLine("-------------------");

            for (int i = 1; i > 0 && i <= num; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}