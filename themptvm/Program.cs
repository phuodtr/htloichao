  
using System;

namespace ThemPhanTuVaoMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = {4, 6, 7, 8, 1};
            int x,n;

            Console.WriteLine("Nhap x :");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap vi tri can chen :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mang truoc khi chen :");

            HienThi( arr, arr.Length - 1);
            Chen(arr, x, n);
            Console.WriteLine("Mang sau khi chen: ");
            HienThi(arr, arr.Length);

        }

        private static void Chen(int[] arr, int x, int n)
        {
            for (int i = arr.Length - 1; i > n; i--)
            {
                 arr[i] = arr[i - 1];
            }
            arr[n] = x;
        }

        private static void HienThi(int[] arr, int size)
        {
            for (int i = 0; i < size; i++ )
            {
                Console.Write(arr[i] + "");
            }
            Console.WriteLine();
        }
    }
}