using System;
using System.Globalization;

namespace Course07
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}