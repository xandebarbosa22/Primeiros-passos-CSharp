using System;
using System.Globalization;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {

            // *-----> Exercício proposto - 01 <-----* //

            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos. */


            // Exemplo 01

            int num_1 = int.Parse(Console.ReadLine());
            int num_2 = int.Parse(Console.ReadLine());
            int res_1 = num_1 + num_2;

            Console.WriteLine();
            Console.WriteLine("SOMA = " + res_1);
            Console.WriteLine();

            // Exemplo 02

            int num_3 = int.Parse(Console.ReadLine());
            int num_4 = int.Parse(Console.ReadLine());
            int res_2 = num_3 + num_4;

            Console.WriteLine();
            Console.WriteLine("SOMA = " + res_2);
            Console.WriteLine();

            // Exemplo 03

            int num_5 = int.Parse(Console.ReadLine());
            int num_6 = int.Parse(Console.ReadLine());
            int res_3 = num_5 + num_6;

            Console.WriteLine();
            Console.WriteLine("SOMA = " + res_3);
            Console.WriteLine();


            // *-----> Exercício proposto - 02 <-----* //

            /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            casas decimais conforme exemplos.
            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159 */


            // Exemplo 01

            double raio_1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area_1 = (double) pi * Math.Pow(raio_1, 2);

            Console.WriteLine();
            Console.WriteLine("A=" + area_1.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Exemplo 02

            double raio_2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area_2 = pi * Math.Pow(raio_2, 2);

            Console.WriteLine();
            Console.WriteLine("A=" + area_2.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Exemplo 03

            double raio_3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area_3 = pi * Math.Pow(raio_3, 2);

            Console.WriteLine("A=" + area_3.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine();


            // *-----> Exercício proposto - 03 <-----* //

            /* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). */


            // Exemplo 01

            int A_1, B_1, C_1, D_1, dif_1;

            A_1 = int.Parse(Console.ReadLine());
            B_1 = int.Parse(Console.ReadLine());
            C_1 = int.Parse(Console.ReadLine());
            D_1 = int.Parse(Console.ReadLine());
            dif_1 = A_1 * B_1 - C_1 * D_1;

            Console.WriteLine();
            Console.WriteLine("DIFERENCA = " + dif_1);
            Console.WriteLine();

            // Exemplo 02

            int A_2, B_2, C_2, D_2, dif_2;

            A_2 = int.Parse(Console.ReadLine());
            B_2 = int.Parse(Console.ReadLine());
            C_2 = int.Parse(Console.ReadLine());
            D_2 = int.Parse(Console.ReadLine());
            dif_2 = A_2 * B_2 - C_2 * D_2;

            Console.WriteLine();
            Console.WriteLine("DIFERENCA = " + dif_2);
            Console.WriteLine();
        }
    }
}