using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //double sr;
            Console.Write("Введите 5 целых чисел  -> ");
            try
            {

                int[] mas = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(e => Convert.ToInt32(e)).ToArray();
                if (mas.Length > 5)
                {
                    Console.WriteLine("Введено более 5 символов");
                    Console.ReadKey();

                }
                else
                {
                    //Console.WriteLine(String.Join(" ", mas));
                    //int[] nmas = new int[5];
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    nmas[i] = mas[i];
                    //}
                    //Console.WriteLine(String.Join(" ", nmas));
                    //sr = nmas.Sum() / nmas.Length;
                    //sr = mas.Sum() / mas.Length;
                    Console.WriteLine("Cреднее арифметическое -> " + mas.Sum() / mas.Length);
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
