using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dados que você tem:

            string produto01 = "Computador";
            string produto02 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco01 = 2100.0;
            double preco02 = 650.50;
            double medida = 53.234567;

            // Objetivo -> Produzir a seguinte saída de dados do console:
            /*
                Produtos:
                Computador, cujo preço é $ 2100,00
                Mesa de Escritório, cujo preço é $ 650,50
               
                Registro: 30 anos de idade, código 5290 e gênero: M
                
                Medida com oito casas decimais: 53,23456700
                Arredondando (três casas decimais): 53,235
                Separador decimal invariant culture: 53.235
            */

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto01}, cujo preço é: $ {preco01:F2}");
            Console.WriteLine($"{produto02}, cujo preço é: $ {preco02:F2}");
            Console.WriteLine(" ");
            Console.WriteLine($"Registro: {idade} de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine(" ");
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondando (três casas decimais): {0:F3}", medida);
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}