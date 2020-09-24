using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace studentsmanagementsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Program program = new Program();
            int choice;
            Console.WriteLine("1.Chèn Sinh viên mới");
            Console.WriteLine("2.Xem danh sách Học sinh");
            Console.WriteLine("3.Tìm kiếm sinh viên");
            Console.WriteLine("4. Thoát");
            do
            {
                Console.WriteLine("Select: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.addstudent();
                        break;
                    case 2:
                        program.viewstudent();
                        break;
                    case 3:
                        program.findstudent();
                        break;
                    case 4:

                        return;

                }

            }
            while (choice != 4);
        }

        int count = 0;
         Hashtable ListStudent = new Hashtable();
       // Dictionary<int,object> ListStudent = new Dictionary<int,object>();
        public void addstudent()
        {
            Student st = new Student();
            st.ID = count;
            Console.WriteLine("nhap FullName");
            st.FullName = Console.ReadLine();
            Console.WriteLine("nhap DateofBirth");
            st.DateofBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("nhap Native");
            st.Native = Console.ReadLine();
            Console.WriteLine("nhap Class");
            st.Class = Console.ReadLine();
            Console.WriteLine("nhap PhoneNo");
            st.PhoneNo = Console.ReadLine();
            Console.WriteLine("nhap Mobile");
            st.Mobile =Int32.Parse(Console.ReadLine());
            ListStudent.Add(count, st);
            count++;
        }

            public void viewstudent()
            {
            foreach (Student item in ListStudent.Values)
              {
                item.Display();
               }
            } 


        public void findstudent()
        {
            string name;
            Console.WriteLine(" nhap  tim kiem student:");
            name = Console.ReadLine();
            foreach (Student item in ListStudent.Values)
                if (item.FullName.Equals(name))
                    item.Display();
                else Console.WriteLine("khong tim thay ten");
        }



        }
    }