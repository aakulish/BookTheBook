using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_Data
{
    public class Book
    {

        public int ID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Style { get; set; }
        public DateTime DateOfRelease { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string LinkToCover { get; set; }
        
    }
}
