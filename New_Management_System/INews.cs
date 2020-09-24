using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace New_Management_System
{
    interface INews
    {
        int ID { get; set; }
        string Title { get; set; }
        DateTime PublishDate { get; set; }
        string Author { get; set; }
        string Content { get; set; }
        float AverageRate { get; }
        void Display();
    }
}