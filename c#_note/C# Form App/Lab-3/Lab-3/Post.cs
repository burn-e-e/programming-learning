using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Post
    {
        public string title;
        public string description;
        public DateTime dateTime;

        public void publish()
        {
            Console.Write("My post title is {0} \n", title);
            Console.WriteLine("Content: {0} \nPublished in: {1}", description, dateTime);

        }
    }
}
