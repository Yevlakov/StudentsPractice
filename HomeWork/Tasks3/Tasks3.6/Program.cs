using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int [] mas = new int[5];
            Console.WriteLine("Значения элементов массива:");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1,100);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("Cреднее арифметическое -> " + mas.Sum() / mas.Length);
        }
    }
}
