using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Swap)Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.

            int a;
            int b;

            Console.Write("Introduceti un numar pentru  a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar pentru b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(" a = {0}, b = {1}" a, b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.Write("Dupa interschimbare a={0}, b={1}", a, b);
            Console.ReadKey();
        }
    }
}
