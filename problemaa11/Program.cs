using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemaa11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati in ordine inversa cifrele unui numar n.

            int n;
            int cifra;

            Console.Write("Introducetiun numar pentru n: ");
            n = int.Parse(Console.ReadLine()); 

            while(n > 0)
            {
                cifra = n % 10;
                n = n / 10;
                Console.Write(cifra);

            }



        }
    }
}
