using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2._6
{
    class Program
    {
        public static double Score(double kolkm, int standtime)
        {
            double summ = 20;

            if (kolkm > 5)
            {
                summ += (kolkm - 5) * 3;
            }

            if (standtime > 0)
            {
                summ += standtime;
            }

            return summ;
 
        }
        static void Main(string[] args)
        {
           
            double kolkm = 0;
            int standtime = 0;
           
            Console.Write("Введите колличетсво километров -> ");
            kolkm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время простоя (минут) -> ");
            standtime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Цена поездки -> "+Score(kolkm,standtime)+"грн.");
            Console.ReadKey();

        }
    }
}
