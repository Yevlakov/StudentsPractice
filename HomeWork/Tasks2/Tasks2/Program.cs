using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите 2 числа");

            try
            {
                Console.Write("a -> ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b -> ");
                b = Convert.ToDouble(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine(a + ">" + b + " -> a>b");
                    Console.ReadKey();
                }

                if (a < b)
                {
                    Console.WriteLine(a + "<" + b + " -> a<b");
                    Console.ReadKey();
                }

                if (a == b)
                {
                    Console.WriteLine(a + "=" + b + " -> a=b");
                    Console.ReadKey();
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Некорректный формат ввода");
                Console.ReadKey();
            }

        }
    }
}
