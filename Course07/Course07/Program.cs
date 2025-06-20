using System;
using System.Globalization;

namespace Course07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);     // Só com isso, o compilador ainda vai mostrar com a ",".
            string[] i = Console.ReadLine().Split(' ');
            string nome = i[0];
            char sexo = char.Parse(i[1]);
            int idade = int.Parse(i[2]);
            double altura = double.Parse(i[3], CultureInfo.InvariantCulture);


            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));             // Dessa forma, os números decimais serão apresentados com ".".
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            Console.WriteLine("Entre com o seu nome completo:");
            string nome1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Entre com o seu nome, idade e altura (mesma linha):");
            string[] i = Console.ReadLine().Split(' ');
            string nome2 = i[0];
            int idade = int.Parse(i[1]);
            double altura = double.Parse(i[2]);
            Console.WriteLine();

            Console.WriteLine(nome1);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2"));
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}