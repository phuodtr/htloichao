using System;
namespace toantu
{
    class Program
    {
        public float tinh(float width, float height)
        {
            float area = width * height;
            Console.WriteLine("Area is: " + area);
            return area;
        }
        static void Main(string[] args)
        {
            float width, height, kq;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            Program n = new Program();
            kq = n.tinh(width, height);
        }
    }
}