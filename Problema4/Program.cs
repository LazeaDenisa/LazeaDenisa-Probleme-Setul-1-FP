
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Detreminati daca un an y este an bisect.

            int y;

            Console.Write("Introduceti un an: ");

            y = int.Parse(Console.ReadLine());

            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
            {
                Console.WriteLine($"{y} este an bisect");
            }
            else
            {
                Console.WriteLine($"{y} nu este an bisect");
            }

        }
    }
}
