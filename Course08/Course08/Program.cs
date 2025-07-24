using System;

namespace Course08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int Num1 = int.Parse(Console.ReadLine());
            int rep = 0;

            while (Num1 == 0 && rep < 2)
            {
                Console.WriteLine("Digite um número diferente de zero.");
                int Num2 = int.Parse((string)Console.ReadLine());
                Num1 = Num2;
                rep++;
            }

            while (Num1 == 0)
            {
                Console.WriteLine("Você é burro?");
                Console.WriteLine("Digita a p0@#$ de um número diferente de zero!");
                int Num2 = int.Parse((string)Console.ReadLine());
                Num1 = Num2;
            }

            if (Num1%2 != 0)
            {
                Console.WriteLine("Seu número é ímpar.");
            } else
            {
                Console.WriteLine("Seu número é par.");
            }

        }
    }
}