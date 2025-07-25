using System;
using System.Globalization;


namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Exercício 01

            Console.WriteLine("Digite um número inteiro:");
            int Num1 = int.Parse(Console.ReadLine());

            if (Num1 > 0)
            {
                Console.WriteLine("Seu número é Positivo.");
            }
            else if (Num1 == 0)
            {
                Console.WriteLine("Seu número é Zero.");
            }
            else
            {
                Console.WriteLine("Seu número é Negativo.");
            }

            // Exercício 02

            Console.WriteLine("Digite um número inteiro:");
            int Num2 = int.Parse(Console.ReadLine());

            if (Num2 % 2 != 0)
            {
                Console.WriteLine("Seu número é Ímpar.");
            }
            else
            {
                Console.WriteLine("Seu número é Par.");
            }

            // Exercício 03

            Console.WriteLine("Digite um número inteiro:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro:");
            int b = int.Parse(Console.ReadLine());
            int c = a % b;

            if (c == 0)
            {
                Console.WriteLine("Os números são múltiplos");
            }
            else
            {
                Console.WriteLine("Os números não são múltiplos");
            }

            // Exercício 04

            Console.WriteLine("Digite, a seguir, a hora em que começou o jogo:");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite, a seguir, a hora em que terminou o jogo:");
            int horaFinal = int.Parse(Console.ReadLine());
            int horaDia = 24;

            if (horaInicial == horaFinal)
            {
                Console.WriteLine("A duração do jogo foi de 24 horas.");
            }
            else if (horaInicial > horaFinal)
            {
                int duraçãoDoJogo = horaDia - horaInicial + horaFinal;
                Console.WriteLine($"A duração do jogo foi de {duraçãoDoJogo} horas.");
            }
            else
            {
                int duraçãoDoJogo = horaFinal - horaInicial;
                Console.WriteLine($"A duração do jogo foi de {duraçãoDoJogo} horas.");
            }
            
            // Exercício 05

            Console.WriteLine("Qual o código do seu pedido?");
            int codigoPedido = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos você vai querer?");
            int quantidadePedido = int.Parse(Console.ReadLine());

            double cachorroQuente = 4.00;
            double xSalada = 4.50;
            double xBacon = 5.00;
            double torradaSimples = 2.00;
            double refrigerante = 1.50;

            if (codigoPedido == 1)
            {
                double total = cachorroQuente * quantidadePedido;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigoPedido == 2)
            {
                double total = xSalada * quantidadePedido;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigoPedido == 3)
            {
                double total = xBacon * quantidadePedido;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigoPedido == 4)
            {
                double total = torradaSimples * quantidadePedido;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigoPedido == 5)
            {
                double total = refrigerante * quantidadePedido;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}