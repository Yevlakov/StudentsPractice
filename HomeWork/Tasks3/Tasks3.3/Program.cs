using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,num;
            bool ansv = false;
            try
            {
                do
                {
                Random rnd = new Random();
                n = rnd.Next(1, 147);
                Console.WriteLine(n);

                Console.Write("Угадайте загаданне число [1-146] - >");
                num = Convert.ToInt32(Console.ReadLine());

                if (n != num)
                {
                    while (n != num)
                    {
                        if (num > n)
                        {
                            Console.Write("Загаданное число меньше,попробуйте ещё ->");
                            num = Convert.ToInt32(Console.ReadLine());
                        }

                        if (num < n)
                        {
                            Console.Write("Загаданное число больше,попробуйте ещё ->");
                            num = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                if(n == num)
                {
                    string str;
                    Console.WriteLine("Поздравлем,вы угадали!");
                    Console.WriteLine("Ещё разок? (да/нет)");
                    Console.Write("->");
                    str = Console.ReadLine();
                    if (str == "да")
                        ansv = true;
                    if(str == "нет")
                    {
                        ansv = false;
                        Console.WriteLine("Спасибо за игру!");
                        Console.ReadKey();
                    }
                    if (str != "да" && str != "нет")
                    {
                        Console.WriteLine("Некорректный формат ввода");
                        Console.ReadKey();
                    }
                
                
                }
                }
                while(ansv == true);
            }
            catch(Exception)
            {
                Console.WriteLine("Некорректный формат ввода");
                Console.ReadKey();
            }

            
            
        }
    }
}
