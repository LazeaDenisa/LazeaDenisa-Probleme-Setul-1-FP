using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

            int n;
            int k;

            Console.Write("Introduceti un numar pentru n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar pentru k: ");
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine($"{n} se divide cu {k}");
            }
            else
            {
                Console.WriteLine($"{n} nu se divide cu {k}");
            }

        }
    }
}
