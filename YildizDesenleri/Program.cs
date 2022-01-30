using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizDesenleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

        input:
            try
            {
                Console.WriteLine("Şekiller için satır sayısı giriniz.");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("1 den büyük sayı girmelisiniz.");
                    goto input;
                }

                // Şekil - 1
                Console.WriteLine("\r\nŞekil - 1");
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }

                // Şekil - 2

                Console.WriteLine("\r\nŞekil - 2");
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i <= j; i++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }

                // Şekil - 3

                Console.WriteLine("\r\nŞekil - 3");
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i <= j; i++)
                    {
                        Console.Write('*');
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }

                // Şekil - 4
                Console.WriteLine("\r\nŞekil - 4");
                Console.WriteLine();
                for (int i = 1; i <= n; i++)
                {
                    for (int j = n - i; j > 0; j--)
                    {
                        Console.Write(' ');
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                // Şekil - 5 
                Console.WriteLine("\r\nŞekil - 5");
                Console.WriteLine();
                for (int i = 1; i <= n; i++)
                {
                    for (int j = n - i; j > 0; j--)
                    {
                        Console.Write(' ');
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    for (int m = 1; m < i; m++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                // Şekil - 6 
                Console.WriteLine("\r\nŞekil - 6");
                Console.WriteLine();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                // Şekil - 7
                Console.WriteLine("\r\nŞekil - 7");
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                // Şekil - 8
                Console.WriteLine("\r\nŞekil - 8");
                Console.WriteLine();
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int j = (n - i * 2) - 2; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
                if (n % 2 != 0)
                {
                    for (int i = 0; i < (n - 1) / 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int i = (n - 1) / 2; i < n; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    for (int j = i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int j = 0; j < (n - (i * 2) - 2); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }



                // Şekil - 9
                Console.WriteLine("\r\nŞekil - 9");
                Console.WriteLine();
                for (int i = n - 1; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("*");
                    for (int j = 0; j < n - 2; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
                for (int i = n - 1; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();


                // Şekil - 10
                Console.WriteLine("\r\nŞekil - 10");
                Console.WriteLine();
                if (n % 2 == 0)
                {
                    for (int i = 1; i <= n / 2; i++)
                    {
                        for (int j = n - i; j > n / 2; j--)
                        {
                            Console.Write(' ');
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("*");
                        }
                        for (int m = 1; m < i; m++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    for (int i = n / 2; i > 0; i--)
                    {
                        for (int j = n - i; j > n / 2; j--)
                        {
                            Console.Write(' ');
                        }
                        for (int k = i; k >= 1; k--)
                        {
                            Console.Write("*");
                        }
                        for (int m = 1; m < i; m++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();

                    }
                }
                else
                {
                    for (int i = 1; i <= (n - 1) / 2; i++)
                    {
                        for (int j = n - i; j > (n - 1) / 2; j--)
                        {
                            Console.Write(' ');
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("*");
                        }
                        for (int m = 1; m < i; m++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    for (int i = (n - 1) / 2; i > 0; i--)
                    {
                        for (int j = n - i; j > (n - 1) / 2; j--)
                        {
                            Console.Write(' ');
                        }
                        for (int k = i; k >= 1; k--)
                        {
                            Console.Write("*");
                        }
                        for (int m = 1; m < i; m++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();

                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Sadece sayı girmelisiniz.");
                goto input;
            }

            Console.WriteLine("\r\nÇıkış için space, Bir üst menü için ESC, Yeniden hesaplama yapmak için Enter'a basınız...");
            var response = Console.ReadKey(true).Key;
            if (response != ConsoleKey.Escape)
            {
                if (response == ConsoleKey.Spacebar)
                    Environment.Exit(0);
                goto input;
            }
        }
    }
}
