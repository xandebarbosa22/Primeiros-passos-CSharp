using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'f';
            char letra = '\u0041';
            sbyte x = 100;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green"; // String é uma cadeia de caracteres unicode IMUTÁVEL! (segurança, simplicidade, thread safe)
            object obj1 = "Alexandre";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            // -------------------------------------------------------

            int num1 = int.MinValue;
            int num2 = int.MaxValue;
            sbyte num3 = sbyte.MinValue;
            decimal num4 = decimal.MaxValue;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
        }
    }
}