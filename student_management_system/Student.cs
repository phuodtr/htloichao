using System;
using System.Collections.Generic;
using System.Text;

namespace studentsmanagementsystem
{
    class Student : IStudent
    {

        public string FullName { get; set; }
        public int ID { get; set; }
        public DateTime DateofBirth { get; set; }

        public string Native { get; set; }
        public string Class { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }
        public void Display()
        {
            Console.WriteLine($"{FullName}  {ID} {DateofBirth}  {Native}  {Class}  {PhoneNo}  {Mobile} ");
        }

    }
}