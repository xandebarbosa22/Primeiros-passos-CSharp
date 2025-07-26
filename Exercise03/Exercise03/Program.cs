using System;
using System.Globalization;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 01

            Console.Write("Digite a senha correta: ");
            int senhaDigitada = int.Parse(Console.ReadLine());
            int senhaCorreta = 2002;

            while (senhaDigitada != senhaCorreta)
            {
                Console.WriteLine("Senha Inválida.");
                senhaDigitada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido.");

            // Exercício 02

            Console.Write("Escreva uma coordenada X e Y: ");
            string[] vetCoord = Console.ReadLine().Split(' ');
            int coordX = int.Parse(vetCoord[0]);
            int coordY = int.Parse(vetCoord[1]);

            while (coordX == 0 || coordY == 0)
            {
                break;
            }

            if (coordX > 0 && coordY > 0)
            {
                Console.WriteLine("Primeiro Quadrante.");
            }
            else if (coordX < 0 && coordY > 0)
            {
                Console.WriteLine("Segundo Quadrante.");
            }
            else if (coordX < 0 && coordY < 0)
            {
                Console.WriteLine("Terceiro Quadrante.");
            }
            else if (coordX > 0 && coordY < 0)
            {
                Console.WriteLine("Quarto Quadrante.");
            }
        }
    }
}