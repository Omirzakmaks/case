using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    class Program
    {
        static void case1()
        {
            Console.WriteLine("1-7 san engiz:");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("1- kun Dusenbi");
                    break;
                case 2:
                    Console.WriteLine("2- kun Seisenbi");
                    break;
                case 3:
                    Console.WriteLine("3- kun Sarsenbi");
                    break;
                case 4:
                    Console.WriteLine("4- kun Beisenbi");
                    break;
                case 5:
                    Console.WriteLine("5- kun Zhuma");
                    break;
                case 6:
                    Console.WriteLine("6- kun Senbi");
                    break;
                case 7:
                    Console.WriteLine("7- kun Zheksenbi");
                    break;
                default:
                    Console.WriteLine("Aptada ondai kun jok");
                    break;

            }
        }
            static void case2()
            {
                Console.WriteLine("1-5 aralykta san engiz:");
                int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("zhaman");
                    break;
                case 2: Console.WriteLine("kanagattanarlyksyz");
                    break;
                case 3:
                    Console.WriteLine("kanagattanarlyk");
                    break;
                case 4:
                    Console.WriteLine("zhaksy");
                    break;
                case 5:
                    Console.WriteLine("ote zhaksy");
                    break;
                default:
                    Console.WriteLine("kate!!!");
                    break;
            }

            }
        static void case3()
        {
            Console.WriteLine("1-12 aralykta san engiz: ");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1: Console.WriteLine("1-Kantar ai");break;
                case 2: Console.WriteLine("2-Akpan ai"); break;
                case 3: Console.WriteLine("3-Nauryz ai"); break;
                case 4: Console.WriteLine("4-Sauir ai"); break;
                case 5: Console.WriteLine("5-Mamyr ai"); break;
                case 6: Console.WriteLine("6-Mausym ai"); break;
                case 7: Console.WriteLine("7-Shilde ai"); break;
                case 8: Console.WriteLine("8-Tamyz ai"); break;
                case 9: Console.WriteLine("9-Kyrkuiek"); break;
                case 10: Console.WriteLine("10-Kazan ai"); break;
                case 11: Console.WriteLine("11-Karasha ai"); break;
                case 12: Console.WriteLine("12-Zheltoksan ai"); break;
                default: Console.WriteLine("Kate!");break;
            }

        }
        static void case4()
        {
            Console.WriteLine("1-12 aralykta san engiz: ");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: Console.WriteLine("31 kun");break;
                case 4:
                case 6:
                case 9:
                case 11: Console.WriteLine("30 kun"); break;
                case 2: Console.WriteLine("28-29 kun"); break;
                default: Console.WriteLine("Kate!"); break;
            }

        }
        static void case5()
        {
            Console.Write("san engiz:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            switch (x)
            {
                case 1: Console.WriteLine($"a+b={a+b}"); break;
                case 2: Console.WriteLine($"a-b={a-b}");break;
                case 3: Console.WriteLine($"a*b={a*b}");break;
                case 4: Console.WriteLine($"a/b={a/b}");break;
            }
        }
        static void Main(string[] args)
        {
            case5();
            Console.ReadKey();

        }
    }
}
