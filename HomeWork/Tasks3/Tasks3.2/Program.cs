using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 0;
            double modnum, num = 0;
            bool test ;

            do
            {
                Console.Write("Введите число -> ");
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());

                    modnum = Math.Abs(num);
                    while (modnum >= 1)
                    {
                        modnum /= 10;
                        digit++;
                    }

                    Console.WriteLine("Колличество разрядов в числе " + num + " -> " + digit);
                    Console.ReadKey();
                    test = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный формат ввода");
                    test = false;
                }
            }
            while (test==false);
        }
    }
}
