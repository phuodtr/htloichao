using System;

namespace songuyentonhohon100
{
    class Program
    {
        public static void sntnhohon100()
        {
            int a = 2;
            while (a < 100)
            {
                bool n = true;

                if (a < 2)
                {
                    n = false;
                }
                else
                {
                    int i = 2;

                    while (i <= Math.Sqrt(a))
                    {
                        if (a % i == 0)
                        {
                            n = false;
                            break;
                        }
                        i = i + 1;
                    }
                }
                if (n)
                    Console.Write("{0} ", a);
                a++;

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("cac so nguyen to nho hon 100 la: ");
            sntnhohon100();
        }
    }
}