using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int natnum,counter=1;
            int tmp = 1;
            Console.Write("Введите натуральное число -> ");
            try
            {
                natnum = Convert.ToInt32(Console.ReadLine());

                if (natnum > 1)
                {
                    Console.WriteLine("А вот квадраты предыдущих натуральных чисел, меьших введеного числа:)");

                    while (counter * counter < natnum)
                    {
                        tmp = (counter * counter);
                        counter++;
                        //if(tmp<natnum)
                        Console.WriteLine(tmp);
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Не существует квадратов предыдущих натуральных чисел, меньших введеного числа :(");
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
