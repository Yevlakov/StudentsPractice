using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str,pass = "root";

            do
            {
                Console.Write("Введите пароль -> ");
                str = Console.ReadLine();
                if (pass == str)
                {
                    Console.WriteLine("Пароль введен верно!");
                    Console.ReadKey();
                }
                if (pass != str)
                {
                    Console.WriteLine("Неверный пароль!");
                }
            }
            while (pass != str);


        }
    }
}
