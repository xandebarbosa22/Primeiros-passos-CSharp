using System;

namespace Course06
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            /*
            string i = Console.ReadLine();
            string[] vet = i.Split(' ');
            */

            string[] i = Console.ReadLine().Split(' ');
            
            string a = i[0];
            string b = i[1];
            string c = i[2];


            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
