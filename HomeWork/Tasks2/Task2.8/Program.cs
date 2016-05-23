using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8
{
    class Program
    {
        public static double Mylottery(double sum)
        {
            if (sum <= 0)
            {
                Console.WriteLine("Увеличте ставку,это не серьёзно :)");
                return 0;
            }
            else
            {
                Random rnd = new Random();
                int n = rnd.Next(1, 13);
                Console.WriteLine("Выпавшее число -> "+n);

                if (n <= 5)
                {
                    sum = 0;
                }

                if (n >= 6 && n <= 8)
                { 
                    // нет изменения
                }

                if (n >= 9 && n <= 11)
                {
                    sum *= 2;
                }

                if (n == 12)
                {
                    sum *= 10;
                }

                return sum;

            }
        }
        static void Main(string[] args)
        {
            double mysum = 0;
            Console.Write("Ваша ставка -> ");
            try
            {
                mysum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                double res = Mylottery(mysum);

                if (res == 0)
                {
                    Console.WriteLine("Вы проиграли");
                }

                else
                {
                    Console.WriteLine("Ваш выиграш состовляет -> " + res);
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
