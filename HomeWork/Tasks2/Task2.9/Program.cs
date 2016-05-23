using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._9
{
    class Program
    {
        public static void CurrConvert(double sum,int num)
        {
            double doll = 25;
            double euro = 27;
            
            switch (num)
            {
                    //грн
                case 1:
                    {

                        Console.WriteLine(sum + " гривен -> " + Math.Round(Convert.ToDouble(sum / doll), 2) + " долларов");
                        Console.WriteLine(sum + " гривен -> " + Math.Round(sum / euro,2) + " евро");
                        break;
                    }
                    //долл
                case 2:
                    {
                        Console.WriteLine(sum + " долларов -> " + Math.Round(sum * doll,2) + " гривен");
                        Console.WriteLine(sum + " долларов -> " + Math.Round(sum * doll /euro, 2) + " евро");
                        break;
                    }
                    //евро
                case 3:
                    {
                        Console.WriteLine(sum + " евро -> " + Math.Round(sum * euro, 2) + " гривен");
                        Console.WriteLine(sum + " евро -> " + Math.Round(sum * euro / doll, 2) + " долларов");
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            double mysum = 0;
            int mynum = 0;
            try
            {
                Console.Write("Введите необходимую для перевода сумму -> ");
                mysum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Выберите валюту");
                Console.WriteLine("1 - Гривны");
                Console.WriteLine("2 - Доллары");
                Console.WriteLine("3 - Евро");
                Console.Write("->");
                mynum = Convert.ToInt32(Console.ReadLine());

                CurrConvert(mysum, mynum);
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный формат ввода");
                Console.ReadKey(); 
            }
        }
    }
}
