using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Ctrl+K+D kod format

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
                case 1: Console.WriteLine("1- kun Dusenbi"); break;
                case 2: Console.WriteLine("2- kun Seisenbi"); break;
                case 3: Console.WriteLine("3- kun Sarsenbi"); break;
                case 4: Console.WriteLine("4- kun Beisenbi"); break;
                case 5: Console.WriteLine("5- kun Zhuma"); break;
                case 6: Console.WriteLine("6- kun Senbi"); break;
                case 7: Console.WriteLine("7- kun Zheksenbi"); break;
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
                case 1: Console.WriteLine("zhaman"); break;
                case 2: Console.WriteLine("kanagattanarlyksyz"); break;
                case 3: Console.WriteLine("kanagattanarlyk"); break;
                case 4: Console.WriteLine("zhaksy"); break;
                case 5: Console.WriteLine("ote zhaksy"); break;
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
                case 1: Console.WriteLine("1-Kantar ai"); break;
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
                default: Console.WriteLine("Kate!"); break;
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
                case 12: Console.WriteLine("31 kun"); break;
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
                case 1: Console.WriteLine($"a+b={a + b}"); break;
                case 2: Console.WriteLine($"a-b={a - b}"); break;
                case 3: Console.WriteLine($"a*b={a * b}"); break;
                case 4: Console.WriteLine($"a/b={a / b}"); break;
            }
        }
        static void case6()
        {
            Console.WriteLine("1-decimetr, 2-kilometr, 3-metr, 4-millimetr, 5-santimetr");
            Console.WriteLine();
            Console.Write("san engiz:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("metr=");
            double metr = Convert.ToDouble(Console.ReadLine());
            switch (x)
            {
                case 1: Console.WriteLine($"{metr}metr={metr * 10} decimetr"); break;
                case 3: Console.WriteLine($"{metr}metr={metr} metr"); break;
                case 4: Console.WriteLine($"{metr}metr={metr * 1000 }millimetr"); break;
                case 2: Console.WriteLine($"{metr}metr={metr / 1000} kilometr"); break;
                case 5: Console.WriteLine($"{metr}metr={metr * 100} santimetr"); break;
                default: Console.WriteLine("Kate!"); break;
            }

        }
        static void case7()
        {
            Console.WriteLine("1-kilogramm, 2-milligramm,3-gramm, 4-tonna, 5-centner");
            Console.Write("san engiz:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Massa:");
            double massa = double.Parse(Console.ReadLine());
            switch (x)
            {
                case 1: Console.WriteLine($"{massa} kg"); break;
                case 2: Console.WriteLine($"{massa / 10000000} mg"); break;
                case 3: Console.WriteLine($"{massa / 1000} gr"); break;
                case 4: Console.WriteLine($"{massa * 1000} tn"); break;
                case 5: Console.WriteLine($"{massa * 100} ct"); break;
            }
        }
        static void case8()
        {
            Console.Write("kun engiz D=");
            int d = int.Parse(Console.ReadLine());
            Console.Write("ai nomerin engiz M=");
            int m = int.Parse(Console.ReadLine());
            d = d - 1;
            if (d == 0)
            {
                d = 1;
                m = m - 1;
                if (m == 0) m = 12;
                switch (m)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: d = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: d = 30; break;
                    case 2: d = 28; break;

                }
            }
            Console.WriteLine($"{d}.{m}");
        }
        static void case9()
        {
            Console.Write("kun engiz D=");
            int day = int.Parse(Console.ReadLine());
            Console.Write("ai nomerin engiz M=");
            int month = int.Parse(Console.ReadLine());
            day++;
            switch (day)
            {
                case 32:
                    day = 1; month++;

                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10: day = 31; break;
                        case 13: day = 1; month = 1; break;

                    }
                    break;
                case 29:
                    day = 1; month++;
                    switch (month)
                    {
                        case 2: day = 28; break;
                    }
                    break;

                case 31:
                    day = 1; month++;
                    switch (month)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            day = 30; break;
                        case 12: day = 1; month = 1; break;
                    }
                    break;

            }

            Console.WriteLine($"{day}.{month}");
        }
        static void case10()
        {
            Console.Write("'s','u','z','v' naplavlenie: ");
            string c = Console.ReadLine();
            Console.Write("0,1,-1 operacia: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case "s":
                    switch (n)
                    {
                        case 0: c = "s"; break;
                        case 1: c = "z"; break;
                        case -1: c = "v"; break;
                    }
                    break;
                case "u":
                    switch (n)
                    {
                        case 0: c = "u"; break;
                        case 1: c = "v"; break;
                        case -1: c = "z"; break;
                    }
                    break;
                case "v":
                    switch (n)
                    {
                        case 0: c = "v"; break;
                        case 1: c = "s"; break;
                        case -1: c = "u"; break;
                    }
                    break;
                case "z":
                    switch (n)
                    {
                        case 0: c = "z"; break;
                        case 1: c = "u"; break;
                        case -1: c = "s"; break;
                    }
                    break;
                default: Console.WriteLine("Kate!"); break;
            }
            Console.WriteLine("rezult: " + c);
        }
        static void case11()
        {
            Console.Write("'s','u','z','v' naplavlenie: ");
            string c = Console.ReadLine();
            Console.Write("0,1,-1 operacia, n1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("0,1,-1 operacia, n2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case "s":
                    switch (n1)
                    {

                        case 1:
                            c = "z";
                            switch (n2)
                            {
                                case 1: c = "u"; break;
                                case -1: c = "s"; break;
                                case 2: c = "v"; break;
                            }
                            break;
                        case -1:
                            c = "v";
                            switch (n2)
                            {
                                case 1: c = "s"; break;
                                case -1: c = "u"; break;
                                case 2: c = "z"; break;
                            }
                            break;
                        case 2:
                            c = "u";
                            switch (n2)
                            {
                                case 1: c = "v"; break;
                                case -1: c = "z"; break;
                                case 2: c = "s"; break;
                            }
                            break;
                    }
                    break;
                case "u":
                    switch (n1)
                    {
                        case 1:
                            switch (n2)
                            {
                                case 1: c = "z"; break;
                                case -1: c = "u"; break;
                                case 2: c = "v"; break;
                            }
                            break;
                        case -1:
                            switch (n2)
                            {
                                case 1: c = "u"; break;
                                case -1: c = "s"; break;
                                case 2: c = "z"; break;
                            }
                            break;
                        case 2:
                            switch (n2)
                            {
                                case 1: c = "z"; break;
                                case -1: c = "v"; break;
                                case 2: c = "u"; break;
                            }
                            break;
                    }
                    break;
                case "v":
                    switch (n1)
                    {
                        case 1:
                            switch (n2)
                            {
                                case 1: c = "z"; break;
                                case -1: c = "v"; break;
                                case 2: c = "u"; break;
                            }
                            break;
                        case -1:
                            switch (n2)
                            {
                                case 1: c = "v"; break;
                                case -1: c = "z"; break;
                                case 2: c = "s"; break;
                            }
                            break;
                        case 2:
                            switch (n2)
                            {
                                case 1: c = "u"; break;
                                case -1: c = "s"; break;
                                case 2: c = "v"; break;
                            }
                            break;
                    }
                    break;
                case "z":
                    switch (n1)
                    {
                        case 1:
                            switch (n2)
                            {
                                case 1: c = "v"; break;
                                case -1: c = "z"; break;
                                case 2: c = "s"; break;
                            }
                            break;
                        case -1:
                            switch (n2)
                            {
                                case 1: c = "z"; break;
                                case -1: c = "v"; break;
                                case 2: c = "s"; break;
                            }
                            break;
                        case 2:
                            switch (n2)
                            {
                                case 1: c = "s"; break;
                                case -1: c = "u"; break;
                                case 2: c = "z"; break;
                            }
                            break;
                    }
                    break;
                default: Console.WriteLine("Kate!"); break;
            }
            Console.WriteLine(c);
        }
        static void case12()
        {
            Console.Write("1-r, 2-d,3-l,4-s: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double r, d, l, s;
            switch (a)
            {
                case 1:
                    Console.WriteLine("r= " + b); r = b; d = r * 2; l = Math.PI * 2 * r; s = Math.PI * r * r;
                    Console.WriteLine($"radius-{r} diametr-{d} dlina-{l} ploshad-{s}"); break;
                case 2:
                    Console.WriteLine("d= " + b); r = b / 2; d = b; l = Math.PI * 2 * r; s = Math.PI * r * r;
                    Console.WriteLine($"radius-{r} diametr-{d} dlina-{l} ploshad-{s}"); break;
                case 3:
                    Console.WriteLine("l= " + b); l = b; r = l / 2 * Math.PI; d = r * 2; s = Math.PI * r * r;
                    Console.WriteLine($"radius-{r} diametr-{d} dlina-{l} ploshad-{s}"); break;
                case 4:
                    Console.WriteLine("s= " + b); s = b; r = Math.Sqrt(s / Math.PI); d = r * 2; l = Math.PI * 2 * r;
                    Console.WriteLine($"radius-{r} diametr-{d} dlina-{l} ploshad-{s}"); break;

            }

        }
        static void case13()
        {
            Console.Write("1-a, 2-c,3-h,4-s: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double a, c, h, s;
            switch (x)
            {
                case 1:
                    Console.WriteLine("1-katet= " + b); a = b; c = a * Math.Sqrt(2); h = c / 2; s = c * h / 2;
                    Console.WriteLine($"katet= {a} gipotenuza= {c} vysota= {h} ploshad= {s}"); break;
                case 2:
                    Console.WriteLine("2-gipotenuza= " + b); c = b; a = c / Math.Sqrt(2); h = c / 2; s = c * h / 2;
                    Console.WriteLine($"katet= {a} gipotenuza= {c} vysota= {h} ploshad= {s}"); break;
                case 3:
                    Console.WriteLine("3-vysota= " + b); h = b; c = h * 2; a = c / Math.Sqrt(2); s = c * h / 2;
                    Console.WriteLine($"katet= {a} gipotenuza= {c} vysota= {h} ploshad= {s}"); break;
                case 4:
                    Console.WriteLine("ploshad= " + b); s = b; a = Math.Sqrt(s * 2); c = a * Math.Sqrt(2); h = c / 2;

                    Console.WriteLine($"katet= {a} gipotenuza= {c} vysota= {h} ploshad= {s}"); break;

            }

        }
        static void case14()
        {
            Console.Write("1-a, 2-c,3-h,4-s: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double a, r1, r2, s;
            switch (x)
            {
                case 1:
                    Console.WriteLine("1-kabyrga= " + b); a = b; r1 = a * Math.Sqrt(3) / 6; r2 = 2 * r1; s = a * a * Math.Sqrt(3) / 4;
                    Console.WriteLine($"kabyrga= {a} R1= {r1} R2= {r2} audany= {s}"); break;
                case 2:
                    Console.WriteLine("2-R1= " + b); r1 = b; a = r1 * 6 / Math.Sqrt(3); r2 = 2 * r1; s = a * a * Math.Sqrt(3) / 4;
                    Console.WriteLine($"kabyrga= {a} R1= {r1} R2= {r2} audany= {s}"); break;
                case 3:
                    Console.WriteLine("3-R2= " + b); r2 = b; r1 = r2 / 2; a = r1 * 6 / Math.Sqrt(3); s = a * a * Math.Sqrt(3) / 4;
                    Console.WriteLine($"kabyrga= {a} R1= {r1} R2= {r2} audany= {s}"); break;
                case 4:
                    Console.WriteLine("audany= " + b); s = b; a = Math.Sqrt(s * 4 / Math.Sqrt(3)); r1 = a * Math.Sqrt(3) / 6; r2 = 2 * r1;
                    Console.WriteLine($"kabyrga= {a} R1= {r1} R2= {r2} audany= {s}"); break;

            }
        }
        static void case15()
        {
            Console.Write("Масть карты 1-пики, 2-треф, 3-бубны,4-червы: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("6 < N < 14 номер карты: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 6: Console.Write("шестерка "); break;
                case 7: Console.Write("семерка "); break;
                case 8: Console.Write("восьмерка "); break;
                case 9: Console.Write("девятка "); break;
                case 10: Console.Write("десятка "); break;
                case 11: Console.Write("валет "); break;
                case 12: Console.Write("дама "); break;
                case 13: Console.Write("король\t"); break;
                case 14: Console.Write("туз "); break;
            }
            switch (m)
            {
                case 1: Console.WriteLine("пик "); break;
                case 2: Console.WriteLine("треф "); break;
                case 3: Console.WriteLine("бубен"); break;
                case 4: Console.WriteLine("червей"); break;
            }

        }
        static void case16()
        {
            int g;

            do
            {
                Console.Write("в диапазоне 20–69, определяющее возраст (в годах): ");
                g = Convert.ToInt32(Console.ReadLine());
                if (g <= 19 && g <= 70) Console.WriteLine("error");
            }
            while (g <= 19 && g <= 70);
            int des, edn;
            des = g / 10;
            edn = g % 10;

            switch (des)
            {
                case 2: Console.Write("Двадцать "); break;
                case 3: Console.Write("Тридцать "); break;
                case 4: Console.Write("Сорок "); break;
                case 5: Console.Write("Пятьдесят "); break;
                case 6: Console.Write("Шестдесят "); break;

            }
            switch (edn)
            {
                case 0: Console.Write("лет"); break;
                case 1: Console.Write("один год"); break;
                case 2: Console.Write("Два года"); break;
                case 3: Console.Write("Три года"); break;
                case 4: Console.Write("Четыре года"); break;
                case 5: Console.Write("Пять лет"); break;
                case 6: Console.Write("Шесть лет"); break;
                case 7: Console.Write("Семь лет"); break;
                case 8: Console.Write("Восемь лет"); break;
                case 9: Console.Write("Девять лет"); break;


            }

        }
        static void case17()
        {
            int g;

            do
            {
                Console.Write(" чиcло в диапазоне 10-40, : ");
                g = Convert.ToInt32(Console.ReadLine());
                if (g <= 9 && g <= 40) Console.WriteLine("error");
            }
            while (g <= 9 && g <= 40);
            int des, edn;
            des = g / 10;
            edn = g % 10;

            switch (g)
            {

                case 11: Console.WriteLine("одиннадцать учебных заданий"); break;
                case 12: Console.WriteLine("двенадцать учебных заданий"); break;
                case 13: Console.WriteLine("тринадцать учебных заданий"); break;
                case 14: Console.WriteLine("четырнадцать учебных заданий"); break;
                case 15: Console.WriteLine("пятнадцать учебных заданий"); break;
                case 16: Console.WriteLine("шестнадцать учебных заданий"); break;
                case 17: Console.WriteLine("семнадцать учебных заданий"); break;
                case 18: Console.WriteLine("восемнадцать учебных заданий"); break;
                case 19: Console.WriteLine("девятнадцать учебных заданий"); break;
            }
            switch (des)
            {
                case 1: Console.Write("Десять "); break;
                case 2: Console.Write("Двадцать "); break;
                case 3: Console.Write("Тридцать "); break;
                case 4: Console.Write("Сорок "); break;

            }
            switch (edn)
            {
                case 0: Console.WriteLine(" учебных заданий"); break;
                case 1: Console.WriteLine(" одно учебное задание"); break;
                case 2: Console.WriteLine(" два учебных задания"); break;
                case 3: Console.WriteLine("три учебных задания"); break;
                case 4: Console.WriteLine("четыре учебных задания "); break;
                case 5: Console.WriteLine("пять учебных заданий"); break;
                case 6: Console.WriteLine("шесть учебных заданий"); break;
                case 7: Console.WriteLine("семь учебных заданий"); break;
                case 8: Console.WriteLine("восемь учебных заданий"); break;
                case 9: Console.WriteLine("девять учебных заданий"); break;
            }

        }
        static void case18()
        {
            int n;
            do
            {
                Console.Write(" чиcло в диапазоне 100-999, : ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 100 && n < 999) Console.WriteLine("error");
            }
            while (n < 100 && n < 999);
            switch (n / 100)
            {
                case 1: Console.Write("сто"); break;
                case 2: Console.Write("двести"); break;
                case 3: Console.Write("Триста "); break;
                case 4: Console.Write("Четыреста "); break;
                case 5: Console.Write("Пятьсот "); break;
                case 6: Console.Write("Шестьсот "); break;
                case 7: Console.Write("Семьсот "); break;
                case 8: Console.Write("Восемьсот "); break;
                case 9: Console.Write("Девятьсот "); break;

            }

            switch (n / 10 % 10)
            {

                case 2: Console.Write("Двадцать "); break;
                case 3: Console.Write("Тридцать "); break;
                case 4: Console.Write("Сорок "); break;
                case 5: Console.Write("Пятьдесят "); break;
                case 6: Console.Write("Шестьдесят "); break;
                case 7: Console.Write("Семьдесят"); break;
                case 8: Console.Write("Восемьдесят "); break;
                case 9: Console.Write("Девяносто"); break;

            }
            switch (n % 10)
            {
                case 1: Console.Write("один "); break;
                case 2: Console.Write("Два "); break;
                case 3: Console.Write("Три "); break;
                case 4: Console.Write("Четыре "); break;
                case 5: Console.Write("Пять "); break;
                case 6: Console.Write("Шесть "); break;
                case 7: Console.Write("Семь"); break;
                case 8: Console.Write("Восемь "); break;
                case 9: Console.Write("Девять "); break;
            }
            switch (n % 100)
            {

                case 11: Console.WriteLine("одиннадцать "); break;
                case 12: Console.WriteLine("двенадцать "); break;
                case 13: Console.WriteLine("тринадцать "); break;
                case 14: Console.WriteLine("четырнадцать "); break;
                case 15: Console.WriteLine("пятнадцать "); break;
                case 16: Console.WriteLine("шестнадцать "); break;
                case 17: Console.WriteLine("семнадцать "); break;
                case 18: Console.WriteLine("восемнадцать "); break;
                case 19: Console.WriteLine("девятнадцать "); break;
            }
        }
        static void case19()
        {
            Console.Write("год: ");
            int x = Convert.ToInt32(Console.ReadLine());
;            switch (x % 1984 % 60 / 12)
            {
                case 0: Console.Write("год зален");break;
                case 1: Console.Write("год красн"); break;
                case 2: Console.Write("год желт"); break;
                case 3: Console.Write("год бел"); break;
                case 4: Console.Write("год черн"); break;
            }

            switch (x % 1984 % 60 % 12)
            {
                case 0: Console.WriteLine("ой крысы");break;
                case 1: Console.WriteLine("ой коровы"); break;
                case 2: Console.WriteLine("ого тигра"); break;
                case 3: Console.WriteLine("ого зайца"); break;
                case 4: Console.WriteLine("ого дракона"); break;
                case 5: Console.WriteLine("ой змеи"); break;
                case 6: Console.WriteLine("ой лошади"); break;
                case 7: Console.WriteLine("ой овцы"); break;
                case 8: Console.WriteLine("ой обезьяны"); break;
                case 9: Console.WriteLine("ой коровы"); break;
                case 10: Console.WriteLine("ой собаки"); break;
                case 11: Console.WriteLine("ой свиньи"); break;
               
            }
        }
        static void case20()
        {
            Console.Write("kun: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("ai: ");
            int m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                    if (d >= 20) Console.WriteLine("sukyigyw");
                    else Console.WriteLine("tauewki"); break;
                case 2:
                    if (d <= 19) Console.WriteLine("balyktar");
                    else Console.WriteLine("sukyigyw");
                    break;
                case 3:
                    if (d >= 21) Console.WriteLine("tokty");
                    else Console.WriteLine("balyktar");
                    break;
                case 4:
                    if (d >= 20) Console.WriteLine("torpak");
                    else Console.WriteLine("tokty"); break;
                case 5:
                    if (d >= 21) Console.WriteLine("egizder");
                    else Console.WriteLine("torpak"); break;
                case 6:
                    if (d >= 22) Console.WriteLine("rak");
                    else Console.WriteLine("egizder"); break;
                case 7:
                    if (d >= 23) Console.WriteLine("arystan");
                    else Console.WriteLine("rak"); break;
                case 8:
                    if (d >= 23) Console.WriteLine("bikew");
                    else Console.WriteLine("arystan"); break;
                case 9:
                    if (d >= 23) Console.WriteLine("tarazy");
                    else Console.WriteLine("bikew"); break;
                case 10:
                    if (d >= 23) Console.WriteLine("saryshaian");
                    else Console.WriteLine("tarazy"); break;
                case 11:
                    if (d >= 23) Console.WriteLine("mergen");
                    else Console.WriteLine("saryshaian"); break;
                case 12:
                    if (d >= 22) Console.WriteLine("tauewki");
                    else Console.WriteLine("sukyigyw"); break;

            }

        }
        static void Main(string[] args)
        {
            //Console.WriteLine(1994% 1984%60%12);
            case20();
            Console.ReadKey();

        }
    }
}
