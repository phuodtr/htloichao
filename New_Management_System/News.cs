using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace New_Management_System
{
    class News:INews
    {
        int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        DateTime publishdate;
        public DateTime PublishDate
        {
            get
            {
                return publishdate;
            }
            set
            {
                publishdate = value;
            }
        }
        string author;
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        string content;
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        float averagerate;
        public float AverageRate
        {
            get { return averagerate; }
        }

        public void Display()
        {
            Console.WriteLine("Title:"+Title);
            Console.WriteLine("Publish date: "+PublishDate);
            Console.WriteLine("Author: "+Author);
            Console.WriteLine("Content: "+Content);
            Console.WriteLine("Averate rate: "+AverageRate);
        }
        int[] RateList = new int[3];
        public int this[int index] //Indexer
        {
            get
            {
                return RateList[index];
            }
            set
            {
                RateList[index] = value;
            }
        }
        public void Calculate(){
            averagerate= (float)(RateList[0]+RateList[1]+RateList[2])/3;
        }
    }
}