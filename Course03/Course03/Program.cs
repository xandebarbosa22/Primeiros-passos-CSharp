using System;

namespace Course03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores de Atribuição

            int a = 10;  // a = 10
            a += 2;     // a = 12 (10 + 2)
            a -= 2;     // a = 10 (12 - 2)
            a *= 2;     // a = 20 (10 * 2)
            a /= 2;     // a = 10 (20 / 2)
            a %= 3;     // a = 1  (10 / 3 = resto 1)

            Console.WriteLine(a);

            string s = "ABC";
            s += "DEF";

            Console.WriteLine(s);

            int b = 10;
            b++;            // "++" adiciona 1
            b--;            // "--" subtrai 1

            Console.WriteLine(b);
            Console.WriteLine("-----------");

            //    *-----> ATENÇÃO <-----*

            int c = b++;

            Console.WriteLine(b);
            Console.WriteLine(c);      // O valor de "c" ainda vai ser 10 porque primeiro "c" recebe "b", depois "b" recebe +1

            Console.WriteLine("-----------");

            c = ++b;

            Console.WriteLine(b);
            Console.WriteLine(c);      // Já se você colocar o "++" antes, "c" já recebe "b" com +1
        }
    }
}