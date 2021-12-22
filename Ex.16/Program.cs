using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

            Console.WriteLine("Introduceti 5 numere a, b, c, d si e");
            Console.Write("a = ");

            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");

            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");

            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");

            int d = int.Parse(Console.ReadLine());
            Console.Write("e = ");

            int e = int.Parse(Console.ReadLine());
            int max = 0;

            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            if (b > c)
            {
                max = b;
                b = c;
                c = max;
            }
            if (c > d)
            {
                max = c;
                c = d;
                d = max;
            }
            if (d > e)
            {
                max = d;
                d = e;
                e = max;
            }
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            if (b > c)
            {
                max = b;
                b = c;
                c = max;
            }
            if (c > d)
            {
                max = c;
                c = d;
                d = max;
            }
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            if (b > c)
            {
                max = b;
                b = c;
                c = max;
            }
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
        }
    }
}
