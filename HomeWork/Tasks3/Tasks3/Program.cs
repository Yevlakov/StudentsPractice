using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            try
            {
                Console.Write("Введите число -> ");
                num = Convert.ToDouble(Console.ReadLine());

                for (int i = 1; i < 21; i++)
                {
                    Console.WriteLine(i + " * " + num + " = " + i * num);
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный формат ввода");
                Console.ReadKey(); 
            }

        }
    }
}
