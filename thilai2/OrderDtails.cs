using System;
namespace thilai2
{
    public class OrderDetails
    {
        public string Name{get;set;}
        public long Price{get;set;}
        public int Count{get;set;}
        public long Total{get;set;}
        public void  CalculatorTotal(){
            Total = Price * Count;
        }
        public OrderDetails (string name, long price,int count,long total)
        {
            Name = name;
            Price = price;
            Count = count;
            Total = total;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name : ", Name);
            Console.WriteLine("Price : ", Price);
            Console.WriteLine("Count : ", Count);
            Console.WriteLine("Total : ", Total);
        }
}
}