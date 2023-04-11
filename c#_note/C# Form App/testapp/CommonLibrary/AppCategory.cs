using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
   public class AppCategory
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryInfo { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        //constructor method uusgetsgeeye
        public AppCategory()
        {
            id = 0;
            CategoryName = "";
            CategoryInfo = "";
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }

    }
}
