using System;
using System.Globalization;
using System.Net.WebSockets;
using System.Runtime.Intrinsics.X86;

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
            double pi1 = 3.14159;
            double area_1 = (double)pi1 * Math.Pow(raio_1, 2);

            Console.WriteLine();
            Console.WriteLine("A=" + area_1.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Exemplo 02

            double raio_2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area_2 = pi1 * Math.Pow(raio_2, 2);

            Console.WriteLine();
            Console.WriteLine("A=" + area_2.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Exemplo 03

            double raio_3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area_3 = pi1 * Math.Pow(raio_3, 2);

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


            // *-----> Exercício proposto - 04 <-----* //

            /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais. */


            // Exemplo 01

            int id_1, horas_1;
            double valor_hora_1, salario_1;

            id_1 = int.Parse(Console.ReadLine());
            horas_1 = int.Parse(Console.ReadLine());
            valor_hora_1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario_1 = horas_1 * valor_hora_1;

            Console.WriteLine();
            Console.WriteLine($"NUMBER = {id_1}");
            Console.WriteLine($"SALARY = U$ " + salario_1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Exemplo 02

            int id_2, horas_2;
            double valor_hora_2, salario_2;

            id_2 = int.Parse(Console.ReadLine());
            horas_2 = int.Parse(Console.ReadLine());
            valor_hora_2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario_2 = horas_2 * valor_hora_2;

            Console.WriteLine();
            Console.WriteLine($"NUMBER = {id_2}");
            Console.WriteLine("SALARY = U$ " + salario_2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Exemplo 03

            int id_3, horas_3;
            double valor_hora_3, salario_3;

            id_3 = int.Parse(Console.ReadLine());
            horas_3 = int.Parse(Console.ReadLine());
            valor_hora_3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario_3 = horas_3 * valor_hora_3;

            Console.WriteLine();
            Console.WriteLine($"NUMBER = {id_3}");
            Console.WriteLine("SALARY = U$ " + salario_3.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();


            // *-----> Exercício proposto - 05 <-----* //

            /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago. */


            // Exemplo 01

            int codigo1, codigo2, numPecas1, numPecas2;
            double valorUnit1, valorUnit2, valorTotal1;

            string[] index1 = Console.ReadLine().Split();
            string[] index2 = Console.ReadLine().Split();


            codigo1 = int.Parse(index1[0]);
            numPecas1 = int.Parse(index1[1]);
            valorUnit1 = double.Parse(index1[2], CultureInfo.InvariantCulture);
            codigo2 = int.Parse(index2[0]);
            numPecas2 = int.Parse(index2[1]);
            valorUnit2 = double.Parse(index2[2], CultureInfo.InvariantCulture);
            valorTotal1 = (numPecas1 * valorUnit1) + (numPecas2 * valorUnit2);

            Console.WriteLine();
            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Exemplo 02

            int codigo3, codigo4, numPecas3, numPecas4;
            double valorUnit3, valorUnit4, valorTotal2;

            string[] index3 = Console.ReadLine().Split();
            string[] index4 = Console.ReadLine().Split();

            codigo1 = int.Parse(index3[0]);
            numPecas1 = int.Parse(index3[1]);
            valorUnit1 = double.Parse(index3[2], CultureInfo.InvariantCulture);
            codigo2 = int.Parse(index4[0]);
            numPecas2 = int.Parse(index4[1]);
            valorUnit2 = double.Parse(index4[2], CultureInfo.InvariantCulture);
            valorTotal2 = (numPecas1 * valorUnit1) + (numPecas2 * valorUnit2);

            Console.WriteLine();
            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Exemplo 03

            int codigo5, codigo6, numPecas5, numPecas6;
            double valorUnit5, valorUnit6, valorTotal3;

            string[] index5 = Console.ReadLine().Split();
            string[] index6 = Console.ReadLine().Split();

            codigo1 = int.Parse(index5[0]);
            numPecas1 = int.Parse(index5[1]);
            valorUnit1 = double.Parse(index5[2], CultureInfo.InvariantCulture);
            codigo2 = int.Parse(index6[0]);
            numPecas2 = int.Parse(index6[1]);
            valorUnit2 = double.Parse(index6[2], CultureInfo.InvariantCulture);
            valorTotal3 = (numPecas1 * valorUnit1) + (numPecas2 * valorUnit2);

            Console.WriteLine();
            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal3.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();


            // *-----> Exercício proposto - 06 <-----* //

            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B. */


            // Exemplo 01

            double A1, B1, C1;
            string[] i1 = Console.ReadLine().Split(' ');

            A1 = double.Parse(i1[0], CultureInfo.InvariantCulture);
            B1 = double.Parse(i1[1], CultureInfo.InvariantCulture);
            C1 = double.Parse(i1[2], CultureInfo.InvariantCulture);

            // Área do triângulo retângulo: Área = (base * altura) / 2 ou Área = (cateto1 * cateto2) / 2

            double areaTrianguloRetangulo1 = (A1 * C1) / 2;

            Console.WriteLine();
            Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo1.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // Área do círculo: A = π . r²

            double pi = 3.14159;
            double areaCirculo1 = pi * Math.Pow(C1, 2);

            Console.WriteLine();
            Console.WriteLine("CIRCULO: " + areaCirculo1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Área do trapézio: A=(a+b)h/2

            double areaTrapezio1 = (A1 + B1) * C1 / 2;

            Console.WriteLine();
            Console.WriteLine("TRAPEZIO: " + areaTrapezio1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Área do quadrado que tem lado B: A = L²

            double areaQuadrado1 = Math.Pow(B1, 2);

            Console.WriteLine();
            Console.WriteLine("QUADRADO: " + areaQuadrado1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Área do retângulo: A = b . h

            double areaRetangulo1 = A1 * B1;

            Console.WriteLine();
            Console.WriteLine("RETANGULO: " + areaRetangulo1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();


            // Exemplo 02

            double A2, B2, C2;
            string[] i2 = Console.ReadLine().Split(' ');

            A2 = double.Parse(i2[0], CultureInfo.InvariantCulture);
            B2 = double.Parse(i2[1], CultureInfo.InvariantCulture);
            C2 = double.Parse(i2[2], CultureInfo.InvariantCulture);

            // Área do triângulo retângulo: Área = (base * altura) / 2 ou Área = (cateto1 * cateto2) / 2

            double areaTrianguloRetangulo2 = (A2 * C2) / 2;

            Console.WriteLine();
            Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo2.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // Área do círculo: A = π . r²

            double areaCirculo2 = pi * Math.Pow(C2, 2);

            Console.WriteLine();
            Console.WriteLine("CIRCULO: " + areaCirculo2.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Área do trapézio: A=(a+b)h/2

            double areaTrapezio2 = (A2 + B2) * C2 / 2;

            Console.WriteLine();
            Console.WriteLine("TRAPEZIO: " + areaTrapezio2.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Área do quadrado que tem lado B: A = L²

            double areaQuadrado2 = Math.Pow(B2, 2);

            Console.WriteLine();
            Console.WriteLine("QUADRADO: " + areaQuadrado2.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Área do retângulo: A = b . h

            double areaRetangulo2 = A2 * B2;

            Console.WriteLine();
            Console.WriteLine("RETANGULO: " + areaRetangulo2.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

        }
    }
}