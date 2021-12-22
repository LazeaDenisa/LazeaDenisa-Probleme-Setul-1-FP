using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2 ^ 3 x 3 ^ 1 x 7 ^ 2.

            int n;
            int d = 2; //// d va fi, pe rand, fiecare factor prim din descompunere
            int p; // // p va fi puterea lui d in descompunere

            Console.Write("Introduceti un numar pentru n: ");
            n = int.Parse(Console.ReadLine());

            while (n > 1)
            {
                p = 0;

                while (n % d == 0)
                {
                    ++p;
                    n /= d;
                }
            }

        }
    }
}
