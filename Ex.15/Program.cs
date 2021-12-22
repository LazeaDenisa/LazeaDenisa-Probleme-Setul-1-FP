using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau 3 numere. Sa se afiseze in ordine crescatoare. 

            int a;
            int b;
            int c;

            Console.Write("Introduceti un numar pentru a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar pentru b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar pentru c: ");
            c = int.Parse(Console.ReadLine());

            if( a <= b && b <= c)
            {
                Console.WriteLine($"Ordinea crescatoare a numerelor este {a}, {b}, {c}," a, b, c);
            }

            else
                if (a <= b && c <= b)
            {
                Console.WriteLine($"Ordinea crescatoare a numerelor este {a}, {c}, {b} " a, c, b);
            }

            else
                 if (b <= a && a <= c)
            {
                Console.WriteLine($"Ordinea crescatoare a numerelor este {b}, {a}, {c}" b, a, c);
            }

            else
                 if (b <= c && c <= a)
            {
                Console.WriteLine($"Ordinea crescatoare a numerelor este {b}, {c}, {a}" b, c, a);
            }

            else
                if (c <= a && a <= b)
            {
                Console.WriteLine($"Ordinea crescatoare a numerelor este {c}, {a}, {b}" c, a, b);
            }

            else
                if (c <= a && b <= a)
            {
                Console.WriteLine($"Ordinea crescatoare a numerelor este {c}, {b}, {a}" c, b, a);
            }

            Console.ReadLine();
        }
    }
}
