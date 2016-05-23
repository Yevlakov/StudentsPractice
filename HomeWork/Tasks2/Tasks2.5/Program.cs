using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int daynum;
            Console.Write("Введите номер дня недели [1-7] -> ");
            try
            {
                daynum = Convert.ToInt32(Console.ReadLine());

                switch (daynum)
                {
                    case 1:
                        {
                            Console.WriteLine("Понедельник");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Вторник");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Среда");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Четверг");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Пятница");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Суббота");
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Воскресенье");
                            Console.ReadKey();
                            break;
                        }
                }

                if (daynum < 1 || daynum > 7)
                {
                    Console.WriteLine("Упс, такой день не найден введите [1-7]");
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
