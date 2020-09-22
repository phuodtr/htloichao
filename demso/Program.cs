using System;
using System.Text;

namespace DemSoLanXuatHienKiTu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] s = { "a", "a", "b", "c", "c" };
            Console.WriteLine("Nhập kí tự bất kì có trong mảng: ");
            string x = Console.ReadLine();
            Console.WriteLine("Số lần xuất hiện của kí tự {0} là : ", x);
            count(s, x);

        }
        static void count(string[] z, string n)
        {
            int dem = 0;
            for (int i = 0; i < z.Length; i++)
            {
                if (z[i] == n)
                    dem++;

            }
            Console.WriteLine(dem);
        }
    }
}