using System;

namespace ThaoTacVoiMang
{
    class Program
    {
        static void Main(string[] args)
        {
            // khai báo mảng kiểu int, kích thước mảng là 5 phần tử
            int[] numbers = new int[5];

            // sử dụng đoạn mã sau đây để thêm giá trị vào mảng bằng cách chèn vào các vị trí
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;

            // sử dụng đoạn mã sau đây in ra một vài giá trị của mảng
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            // để tính tổng các phần tử của mảng, chúng ta sử dụng vòng lặp.
            Console.WriteLine("Tong cua mang la : {0}", tongMang(numbers));

        }

        static int tongMang(int[] a)
        {
            // gán biến tổng = 0
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong = tong + a[i];
            }
            return tong;
        }
    }
}