using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _0._1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("+-------------------------------+");
//            Console.WriteLine($"|{"Kostenko",8} {"Rostyslav",10} {"Andreevich",10}|");
//            Console.WriteLine("+-------------------------------+");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter first number:");
//            var firstNum = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Enter second number:");
//            var secondNum = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Bigger number is: ");
//            if (firstNum > secondNum)
//            {
//                Console.WriteLine($"{firstNum}");
//            }
//            else
//            {
//                Console.WriteLine($"{secondNum}");
//            }

//            Console.ReadKey();

//        }
//    }
//}

//namespace _1._2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the phrase:");
//            var phrase = Console.ReadLine();
//            if (phrase != "meow" && phrase != "bark")
//            {
//                Console.WriteLine("Entered phrase is unhandled.");
//            }
//            else
//            {
//                Console.WriteLine(phrase == "meow" ? "Feed the cat!" : "Walk out the dog!");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);

//            while (true)
//            {
//                ShowDialog();
//            }

//        }

//        private static void ShowDialog()
//        {
//            Console.WriteLine("Введите номер месяца:");
//            var mounthNum = Convert.ToInt16(Console.ReadLine());
//            if (mounthNum < 1 || mounthNum > 12)
//            {
//                Console.WriteLine("На этой планете такого месяца нет.");

//            }
//            else if (mounthNum == 1 || mounthNum == 12 || mounthNum == 2)
//            {
//                Console.WriteLine("Зима");
//            }
//            else if (mounthNum > 2 && mounthNum < 6)
//            {
//                Console.WriteLine("Весна");
//            }
//            else if (mounthNum >= 6 && mounthNum < 9)
//            {
//                Console.WriteLine("Лето");
//            }
//            else if (mounthNum >= 9 && mounthNum < 12)
//            {
//                Console.WriteLine("Осень");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number:");
//            var number = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine(number == 1 ? "Good!" : number == 0 ? "Bad!" : "NULL");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._5
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            var daysOfAWeek = new List<string>();

//            daysOfAWeek.Add("Sunday");
//            daysOfAWeek.Add("Monday");
//            daysOfAWeek.Add("Tuesday");
//            daysOfAWeek.Add("Wednesday");
//            daysOfAWeek.Add("Thursday");
//            daysOfAWeek.Add("Friday");
//            daysOfAWeek.Add("Saturday");
//            while (true)
//            {
//                Console.WriteLine("Enter the day's position in a week: ");
//                var number = Convert.ToInt32(Console.ReadLine());
//                try
//                {
//                    Console.WriteLine(daysOfAWeek[number]);
//                }
//                catch (Exception)
//                {
//                    Console.WriteLine("There's no such day in a week");
//                }

//            }
//        }
//    }

//}

//namespace _1._6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a trip length: ");
//            var tripLength = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter a waiting length: ");
//            var waitingLength = Convert.ToInt32(Console.ReadLine());
//            int cost = waitingLength;

//            for (int i = 0; i < tripLength; i++)
//            {
//                if (i < 5)
//                {
//                    cost += 20;
//                }
//                else
//                {
//                    cost += 3;
//                }
//            }
//            Console.WriteLine($"Trip cost: {cost}");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._7
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter natural number:");
//            var natNumber = Convert.ToInt32(Console.ReadLine());
//            bool flag = false;
//            for (int i = 2; i < natNumber; i++)
//            {
//                if (natNumber % i == 0)
//                {
//                    flag = true;
//                }
//            }
//            if (!flag)
//            {
//                Console.WriteLine("The number is simple");
//            }
//            else
//            {
//                Console.WriteLine("The number isn't simple!");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._8
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var random = new Random();
//            var res = random.Next(1, 12);
//            Console.WriteLine("Enter the wager:");
//            int wager = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine($"The number on cube:{res}");
//            if (res >= 1 && res <= 5)
//            {
//                Console.WriteLine("You lose!");
//            }
//            if (res >= 6 && res <= 8)
//            {
//                wager -= wager;
//                Console.WriteLine($"You win {wager}!");
//            }
//            if (res >= 9 && res <= 11)
//            {
//                wager += wager;
//                Console.WriteLine($"You win {wager}!");
//            }
//            if (res == 12)
//            {
//                wager = 10 * wager;
//                Console.WriteLine($"You win {wager}!");
//            }
//            Console.ReadKey();
//        }
//    }
//}
//namespace _1._9
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//                Console.WriteLine("Enter number:");
//                double number = Convert.ToDouble(Console.ReadLine());
//                int temp1 = 0;
//                Console.WriteLine("1-grn\n2-dollar\n3-euro");
//                Console.WriteLine("Enter currency number:");
//                int temp = Convert.ToInt32(Console.ReadLine());
//                if (temp == 1)
//                {
//                    Console.WriteLine("Enter transfer currency number:");
//                    temp1 = Convert.ToInt32(Console.ReadLine());
//                    switch (temp1)
//                    {
//                        case 1: Console.WriteLine(number / 1); break;
//                        case 2: Console.WriteLine(number / 25.15); break;
//                        case 3: Console.WriteLine(number / 28.4); break;
//                    }
//                }
//                if (temp == 2)
//                {
//                    Console.WriteLine("Enter transfer currency number:");
//                    temp1 = Convert.ToInt32(Console.ReadLine());
//                    switch (temp1)
//                    {
//                        case 1: Console.WriteLine(number * 25.38); break;
//                        case 2: Console.WriteLine(number * 1); break;
//                        case 3: Console.WriteLine(number * 28.7); break;
//                    }
//                }
//                if (temp == 3)
//                {
//                    Console.WriteLine("Enter transfer currency number:");
//                    temp1 = Convert.ToInt32(Console.ReadLine());
//                    switch (temp1)
//                    {
//                        case 1: Console.WriteLine(number * 28.4); break;
//                        case 2: Console.WriteLine(number * 28.74); break;
//                        case 3: Console.WriteLine(number * 1); break;
//                    }
//                }
//        }
//    }
//}

//namespace _2._1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string n;
//            Console.WriteLine("Enter number:");
//            n = Console.ReadLine();
//            for (int i = 0; i < 21; i++)
//            {
//                Console.WriteLine(n + "*" + i + "=" + Convert.ToInt32(n) * i);
//            }
//        }
//    }
//}


//namespace _2._2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string n;
//            Console.WriteLine("Enter number:");
//            n = Console.ReadLine();
//            int nn = Convert.ToInt32(n);
//            int i = 0;
//            nn = Convert.ToInt32(n);
//            for (; nn != 0; i++)
//            {
//                nn = nn / 10;
//            }
//            Console.WriteLine(i);
//        }
//    }
//}
//namespace _2._3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rand = new Random();
//            int temp;
//            temp = rand.Next(0,147);
//            string n;
//            for (; ; )
//            {
//                Console.WriteLine("Enter number:");
//                n = Console.ReadLine();
//                if (Convert.ToInt32(n) > temp)
//                {
//                    Console.WriteLine("Меньше");
//                }
//                if (Convert.ToInt32(n) < temp)
//                {
//                    Console.WriteLine("Больше");
//                }
//                if (Convert.ToInt32(n) == temp)
//                {
//                    Console.WriteLine("Big Win!!!");
//                    return;
//                }
//            }
//        }
//    }
//}
//namespace _2._4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number:");
//            int temp = Convert.ToInt32(Console.ReadLine());
//            int kvad = 0;

//            for (int i = 1; ; i++)
//            {
//                kvad = i * i;

//                if (kvad >= temp)
//                {
//                    return;
//                }
//                Console.WriteLine(kvad);
//            }
//        }
//    }
//}
//namespace _2._5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Введите число 1:");
//            string s = Console.ReadLine();
//            int a = int.Parse(s);
//            Console.WriteLine("Введите число 2:");
//            string s1 = Console.ReadLine();
//            int b = int.Parse(s1);
//            Console.WriteLine("Введите число 3:");
//            string s2 = Console.ReadLine();
//            int c = int.Parse(s2);
//            Console.WriteLine("Введите число 4:");
//            string s3 = Console.ReadLine();
//            int d = int.Parse(s3);
//            Console.WriteLine("Введите число 5:");
//            string s4 = Console.ReadLine();
//            int e = int.Parse(s4);
//            int mid;
//            mid = (a + b + c + d + e) / 5;
//            Console.WriteLine("Средне Арфиметическое:");
//            Console.Write(mid);
//            Console.ReadKey();

//        }
//    }
//}
//namespace _2._6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rand = new Random();
//            Console.OutputEncoding = Encoding.GetEncoding(1251);

//            int a = rand.Next(0, 147);
//            Console.WriteLine("Число 1: "+a);

//            int b = rand.Next(0, 147);
//            Console.WriteLine("Число 2: "+b);

//            int c = rand.Next(0, 147);
//            Console.WriteLine("Число 3: "+c);

//            int d = rand.Next(0, 147);
//            Console.WriteLine("Число 4: "+d);

//            int e = rand.Next(0, 147);
//            Console.WriteLine("Число 5: "+e);
//            int mid;
//            mid = (a + b + c + d + e) / 5;
//            Console.WriteLine("Средне Арфиметическое: ");
//            Console.Write(mid);
//            Console.ReadKey();

//        }
//    }
//}
//namespace _2._7
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            int sk;
//            int sl = sk = 64;// количество лапок всех зверушек вместе 
//            int rl = 4;//количество лапок для одних зверушек (кроли) 
//            int dl = 2;//количество лапок для других зверушек (гуси) 
//            while (sl >= 0)
//            {
//                int r = sl / rl; //количество одних зверушек (кроли) 
//                int d = (sk - sl) / dl;//количество других зверушек (гуси) 
//                if ((sl % rl == 0) && ((sk - sl) % dl == 0))
//                {
//                    Console.WriteLine(r + "-кролик."+d + " -гусь");

//                }
//                sl = sl - 1;
//            }


//            Console.ReadKey();

//        }
//    }
//}

//namespace _2._8
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            string password = "root", input = string.Empty;
//            while (input != password)
//            {
//                Console.WriteLine("Введите пароль:");
//                input = Console.ReadLine();
//            }
//            Console.WriteLine("Пароль принят");
//            Console.ReadKey();

//        }
//    }
//}




