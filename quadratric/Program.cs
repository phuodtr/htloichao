using System;

namespace XayDungLopQuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ CT ] Giai PT bac 2 (ax^2 + bx + x = 0)");
            Console.WriteLine("Nhap a :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c :");
            double c = double.Parse(Console.ReadLine());
            QuadraticEquation quadraticequation = new QuadraticEquation(a,b,c);

            if (quadraticequation.GetDiscriminant() > 0)
            {
                Console.WriteLine("PT co 2 nghiem !");
                Console.WriteLine("X1 = " + quadraticequation.GetRoot2x1());
                Console.WriteLine("X2 = " + quadraticequation.GetRoot2x2());
            }
            else if (quadraticequation.GetDiscriminant() == 0)
            {
                Console.WriteLine("PT co 1 nghiem duy nhat x = " + quadraticequation.GetRoot1());
            }
            else
                Console.WriteLine("PT vo nghiem !");
        }
    }
}
