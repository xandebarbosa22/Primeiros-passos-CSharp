using System;
using System.Globalization;

namespace Course02
{
    class Program
    {
        static void Main(string[] args)
        {
            // char genero = 'f';
            int idade = 23;
            double saldo = 10.35784;
            string nome = "Alexandre";

            /*
            Console.Write("Bom dia!");                  // Diferente do "WriteLine", o comando "Write" não possui quebra de linha no final.
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("----------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));    // "ToString()" comando usado para limitar a quantidade de casas decimais.
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));  // "CultureInfo.InvariantCulture" utilizado para transformar a vírgula em ponto.
            */

            Console.WriteLine("{0} tem {1} anos e um saldo igual a: {2:F2} reais", nome, idade, saldo);                                                     // PlaceHolders
            Console.WriteLine($"{nome} tem {idade} anos e um saldo igual a: {saldo:F2} reais");                                                             // Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e um saldo igual a: " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");       // Concatenação

        }
    }
}