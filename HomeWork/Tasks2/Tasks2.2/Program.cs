using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Введите слово (мяу/гав) -> ");
            str = Console.ReadLine();

            if (str == "мяу")
            {
                Console.WriteLine("Покорми кота");
                Console.ReadKey();
            }

            if (str == "гав")
            {
                Console.WriteLine("Погуляй с собакой");
                Console.ReadKey();
            }


            if ((str != "мяу") && (str != "гав"))
            {
                Console.WriteLine("Команда не распознана,возможно ошибка ввода!");
                Console.ReadKey();
            }

        }
    }
}
