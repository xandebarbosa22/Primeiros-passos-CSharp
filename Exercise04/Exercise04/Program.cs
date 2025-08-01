using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 01

            Console.Write("Digite um número inteiro entre 1 e 1000: ");
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

            // Exercício 02

            Console.Write("Digite quantos números inteiros você deseja inserir: ");
            int nNumeros = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os valores abaixo:");
            int[] vet = new int[nNumeros];
            int dentro = 0, fora = 0;

            for (int i = 0; i < nNumeros; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
                
                if (vet[i] >= 10 && vet[i] <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine("---------------");

            Console.WriteLine("{0} in", dentro);
            Console.WriteLine($"{fora} out");
        }
    }
}