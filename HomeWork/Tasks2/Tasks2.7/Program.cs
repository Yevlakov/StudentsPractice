using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2._7
{
    class Program
    {
        public static void IsPrimeNum (int num)
        {
            if (num < 2)
            {
                Console.WriteLine("Число не простое");
                Console.ReadKey();
            }

            else
            {
                bool prime = true;
                for (int i = 2; i <= num/ 2; i++)
                {
                    if (num % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число не простое");
                }
                Console.ReadKey();                
 
            }
        }
        static void Main(string[] args)
        {
            int mynum;
            Console.Write("Введите число,для проверки на его простоту -> ");
            try
            {
                mynum = Convert.ToInt32(Console.ReadLine());
                IsPrimeNum(mynum);
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный формат ввода");
                Console.ReadKey();  
            }
        }
    }
}
