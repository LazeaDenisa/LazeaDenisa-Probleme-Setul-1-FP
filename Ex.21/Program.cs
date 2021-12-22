using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
            
            int x = -1, numar;
            Random rnd = new Random();
            numar = rnd.Next(1024);

            while(x != numar)
            {
                Console.WriteLine("Introduceti un numar: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"Numarul este mai mare sau egal decat {x}?");

                if( x == numar)
                {
                    Console.WriteLine($"Numarul este {x}");
                    break;
                }
                else if(x <= numar)
                {
                    Console.WriteLine("Da");
                    Console.WriteLine();

                }
                else if (x > numar)
                {
                    Console.WriteLine("Nu");
                    Console.WriteLine();
                }
            }
        }
    }
}
