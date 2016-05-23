using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int g=0,k;

            do
            {
                k = (64 - g * 2) / 4;
                if (k * 4 + g * 2 == 64)
                    Console.WriteLine("Гусей -> " + g + "\t Кроликов -> " + k);
                    g++;
            }
            while (g <= 32);
            Console.ReadKey();
        }
    }
}
