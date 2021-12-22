using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ndmn
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 

            float a, b, c, x1, x2, dt;

            Console.WriteLine("Introduceti un numar pentru a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar pentru b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar pentru c: ");
            c = float.Parse(Console.ReadLine());

            if (a != 0) 
            {
                dt = b * b - 4 * a * c;
                if (dt < 0)
                    Console.WriteLine("Radacinile sunt complexe");
                else
                {
                    x1 = (float)(-b + Math.Sqrt(dt)) / (2 * a);
                    x2 = (float)(-b - Math.Sqrt(dt)) / (2 * a);
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);

                }
            }

            else
            {
                if (b != 0)
                {
                    x1 = -c / b;
                    Console.WriteLine("Ecuatia e de gradul 1: x1 = {0}" x1);
                }

                else
                {
                    if (c == 0)
                        Console.WriteLine("Identitate");
                    else
                        Console.WriteLine("Exuatie imposibila");

                }
            }

            Console.ReadLine();
        }

}
