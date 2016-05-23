using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Введите число (1/0) -> ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 0:
                        {
                            Console.WriteLine("Хорошо");
                            Console.ReadKey();
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Плохо");
                            Console.ReadKey();
                            break;
                        }

                }
                if (num != 0 && num != 1)
                {
                    Console.WriteLine("Некорректный формат ввода, число не является 1 или 0");
                    Console.ReadKey(); 
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный формат ввода, число должно быть 1 или 0");
                Console.ReadKey();
            }


        }
    }
}
