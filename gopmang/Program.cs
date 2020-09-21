using System;
using System.Text;

namespace GopMang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int s1, s2, s3;
            int i, j, k;
            Console.Write("Nhập số lượng phần tử mảng 1: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < s1; i++)
            {
                Console.Write("Phần tử [{0}]: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Nhập số lượng phần tử mảng 2: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < s2; i++)
            {
                Console.Write("Phần tử [{0}]: ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            s3 = s1 + s2;
            for (i = 0; i < s1; i++)
            {
                arr3[i] = arr1[i];
            }
            for (j = 0; j < s2; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }
            
             for (i = 0; i < s3; i++)
            {
                for (k = 0; k < s3 - 1; k++)
                {
                    if (arr3[k] >= arr3[k + 1])
                    {
                        j = arr3[k + 1];
                        arr3[k + 1] = arr3[k];
                        arr3[k] = j;
                    }
                }
            }
             */
            Console.WriteLine("Mảng thứ 3 là : ");
            for (i = 0; i < s3; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}