using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthnum=0;
            Console.Write("Введите номер месяца -> ");
           
            try
            {
                monthnum = Convert.ToInt32(Console.ReadLine());

                if (monthnum == 1 || monthnum == 2 || monthnum == 12)
                {
                    Console.WriteLine("Зима");
                    Console.ReadKey();
                }

                if (monthnum == 3 || monthnum == 4 || monthnum == 5)
                {
                    Console.WriteLine("Весна");
                    Console.ReadKey();
                }

                if (monthnum == 6 || monthnum == 7 || monthnum == 8)
                {
                    Console.WriteLine("Лето");
                    Console.ReadKey();
                }
                if (monthnum == 9 || monthnum == 10 || monthnum == 11)
                {
                    Console.WriteLine("Осень");
                    Console.ReadKey();
                }

                if (monthnum < 1 || monthnum > 12)
                {
                    Console.WriteLine("На этой планете такого месяца нет");
                    Console.ReadKey();
                }

            }
            catch(Exception)
            {
                Console.WriteLine("Некорректный формат ввода");
                Console.WriteLine("На этой планете такого месяца нет");
                Console.ReadKey();
            }


        }
    }
}
