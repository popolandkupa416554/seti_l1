using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static int poisk_max_stepeni(int[] arr)
        {
            int stepen = 0;
            for (int i = arr.Length - 1; i != -1; i--)
            {
                if (arr[i] != 0 && stepen == 0)
                {
                    stepen = i;
                }

            }
            return stepen;
        }
        static void print_arr(int[] arr)
        {
            int b = 0;
            for (int i = arr.Length - 1; i != -1; i--)
            {
                if (arr[i] != 0 && i != 0)
                {
                    b++;
                    if (b == 1)
                    {
                        Console.Write($"x^{i}");
                    }
                    else
                    {
                        Console.Write($"+x^{i}");
                    }


                }
                else
                {
                    if (i == 0 && arr[i] == 1)
                    {
                        Console.Write($"+{1}");
                    }
                }
            }
            Console.WriteLine();
        }
        static void delenie_mnogochlena(ref int[] delimoe, int[] delitel, int[] delitel1, int[] chastnoe)
        {
            int stepen_delimoe = poisk_max_stepeni(delimoe);
            int stepen_delitel = poisk_max_stepeni(delitel);
            int razniza = 0;
            int a = 3;

            Console.Write($"делимое - ");
            print_arr(delimoe);
            Console.Write($"делитель - ");
            print_arr(delitel);
            int lenght = stepen_delimoe - stepen_delitel;
            Console.Write($"максимальная степень делимого - {stepen_delimoe} ");
            Console.Write($"максимальная степень делителя - {stepen_delitel} ");
            while (stepen_delimoe > stepen_delitel)
            {

                stepen_delimoe = poisk_max_stepeni(delimoe);
                stepen_delitel = poisk_max_stepeni(delitel);
                lenght = stepen_delimoe - stepen_delitel;
                chastnoe[lenght] = 1;
                for (int i = 0; i != 10; i++)
                {
                    if (delitel[i] == 1)
                    {
                        delitel1[i + lenght] = 1;
                    }
                }
                Console.Write($"вычитаем из делимого - ");
                print_arr(delitel);
                Console.Write($" * ");
                print_arr(chastnoe);
                Console.Write($" = ");
                print_arr(delitel1);
                Console.WriteLine();
                for (int i = 0; i != 10; i++)
                {
                    if (delitel1[i] == 1)
                    {
                        if (delimoe[i] == 1)
                        {
                            delimoe[i] = 0;
                        }
                        else
                        {
                            delimoe[i] = 1;
                        }
                    }
                }
                Console.Write($"делимое после вычитания - ");
                print_arr(delimoe);
                for (int i = 0; i != 10; i++)
                {
                    delitel1[i] = 0;
                }

            }
        }
        static void print2(int x)
        {
            int[] a = new int[32];
            for (int i = 0; i != 32; i++)
            {
                a[i] = x % 2;
                x = x >> 1;

            }
            for (int i = 31; i != -1; i--)
            {
                Console.Write(a[i]);

            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            int m = 10;
            int a = 0;
            int g = 0;
            int e = 0;
            Console.WriteLine($"Ввкедите m - ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ввкедите g - ");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ввкедите e- ");
            e = Convert.ToInt32(Console.ReadLine());
            string g1;
            int[] delimoe = new int[10];
            int[] delitel = new int[10];
            int[] delitel1 = new int[10];
            int[] chastnoe = new int[10];
            int[] mnogoclen_m = new int[10];
            int[] mnogoclen_g = new int[10];
            int[] mnogoclen_a = new int[10];
            int[] mnogoclen_e = new int[10];
            int[] mnogoclen_b = new int[10];
            int[] mnogoclen_c1 = new int[10];
            int[] mnogoclen_c2 = new int[10];
            int[] mnogoclen_b1 = new int[10];
            int[] delimoe1 = new int[10];

            int[] delitel2 = new int[10];
            int[] chastnoe1 = new int[10];
            int[] mnogoclen_m1 = new int[10];
            int[] mnogoclen_m2 = new int[10];
            int[] mnogoclen_a1 = new int[10];







            for (int i = 0; i != 10; i++)
            {
                if (g % 10 == 1)
                {
                    mnogoclen_g[i] = 1;
                    g = g / 10;
                }
                else
                {
                    g = g / 10;
                }
            }
            print_arr(mnogoclen_g);

            for (int i = 0; i != 10; i++)
            {
                if (e % 10 == 1)
                {
                    mnogoclen_e[i] = 1;
                    e = e / 10;
                }
                else
                {
                    e = e / 10;
                }
            }
            print_arr(mnogoclen_g);

            Console.Write($"m={m} ");
            for (int i = 0; i != 10; i++)
            {
                if (m % 2 == 1)
                {
                    mnogoclen_m[i] = 1;
                    m = m >> 1;
                }
                else
                {
                    m = m >> 1;
                }
            }

            Console.WriteLine($"многочлен m - ");
            print_arr(mnogoclen_m);

            Console.WriteLine($"многочлен g - ");
            print_arr(mnogoclen_g);


            Console.WriteLine($"многочлен e - ");
            print_arr(mnogoclen_e);
            int stepen_g = poisk_max_stepeni(mnogoclen_g);
            for (int i = 9; i != -1; i--)
            {
                if (mnogoclen_m[i] == 1)
                {
                    delimoe[i + stepen_g] = 1;
                }
            }


            delenie_mnogochlena(ref delimoe,
            mnogoclen_g, delitel1, chastnoe);

            print_arr(delimoe);

            for (int i = 9; i != -1; i--)
            {
                if (mnogoclen_m[i] == 1)
                {
                    mnogoclen_a[i + stepen_g] = 1;
                }
            }
            for (int i = 9; i != -1; i--)
            {
                if (mnogoclen_a[i] == 1 && delimoe[i] == 1)
                {
                    mnogoclen_a[i] = 0;
                }
                else
                {
                    if (mnogoclen_a[i] == 1 && delimoe[i] == 0)
                    {
                        mnogoclen_a[i] = 1;
                    }
                    else
                    {
                        if (mnogoclen_a[i] == 0 && delimoe[i] == 1)
                        {
                            mnogoclen_a[i] = 1;
                        }
                    }

                }
            }
            print_arr(mnogoclen_a);

            for (int i = 9; i != -1; i--)
            {
                if (mnogoclen_a[i] == 1)
                {
                    a++;

                    if (i != 0)
                    {
                        a = a << 1;
                    }
                }
                else
                {
                    if (i != 0)
                    {
                        a = a << 1;
                    }
                }
            }
            Console.WriteLine($"зашифрованное сообщение a - ");
            print2(a);
            Console.WriteLine($"вектор ошибки e - ");
            print_arr(mnogoclen_e);

            for (int i = 0; i != 10; i++)
            {
                mnogoclen_b1[i] = mnogoclen_a[i];
            }

            for (int i = 9; i != -1; i--)
            {
                if (mnogoclen_a[i] == 1 && mnogoclen_e[i] == 1 || mnogoclen_a[i] == 0 && mnogoclen_e[i] == 0)
                {
                    mnogoclen_b[i] = 0;
                }
                else
                {
                    mnogoclen_b[i] = 1;
                }
            }


            for (int i = 0; i != 10; i++)
            {
                mnogoclen_b1[i] = mnogoclen_b[i];
            }

            Console.WriteLine($"принятое сообщение b - ");
            print_arr(mnogoclen_b);


            Console.WriteLine($"Проверка на ошибки ");

            delenie_mnogochlena(ref mnogoclen_b, mnogoclen_g, delitel1, chastnoe);

            for (int i = 9; i != -1; i--)
            {
                if (mnogoclen_b[i] == 1)
                {
                    Console.WriteLine($"Произошли ошибки ");
                    break;
                }
                if (i == 0 && mnogoclen_b[i] == 1)
                {
                    Console.WriteLine($"Ошибки не произошли");
                }
            }


            /// альтернативный метод
            ///
            Console.WriteLine("Альтернативный метод");
            mnogoclen_g[0] = 1;
            mnogoclen_g[1] = 1;
            mnogoclen_g[3] = 1;



            stepen_g = poisk_max_stepeni(mnogoclen_g);
            for (int i = 0; i != stepen_g; i++)
            {
                mnogoclen_c1[i] = mnogoclen_b1[i];
            }
            for (int i = 0; i != 6; i++)
            {
                mnogoclen_m1[i] = mnogoclen_b1[i + stepen_g];
            }
            Console.WriteLine($"многочлен m - ");
            print_arr(mnogoclen_m1);
            Console.WriteLine($"многочлен c - ");
            print_arr(mnogoclen_c1);

            for (int i = 9; i != -1; i--)
            {
                if (mnogoclen_m1[i] == 1)
                {
                    delimoe1[i + stepen_g] = 1;
                }
            }

            delenie_mnogochlena(ref delimoe1, mnogoclen_g, delitel2, chastnoe1);
            int proverka = 0;
            for (int i = 9; i != -1; i--)
            {
                if (mnogoclen_c1[i] != delimoe1[i])
                {
                    proverka++;
                }
                if (proverka == 1)
                {
                    Console.WriteLine($"Произошли ошибки ");
                    break;
                }

            }
            if (proverka == 0)
            {
                Console.WriteLine($"Ошибки не произошли ");

            }



            Console.ReadKey();
        }
    }
}
