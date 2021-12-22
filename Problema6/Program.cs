using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 

            int a;
            int b;
            int c;

            Console.Write("Introduceti un numar pentru a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar pentru b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar pentru c: ");
            c = int.Parse(Console.ReadLine());

            if (a < (b + c) && b < (a + c) && c < (a + b)) ;
            {
                Console.WriteLine("Numerele pot fi lungimile laturilor unui triunghi");
            }
            
            else
            {
                Console.WriteLine("Numerele nu pot fi lungimile laturilor unui triunghi");
            }
       
               
        }
    }
}
