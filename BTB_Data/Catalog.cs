using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_Data
{
    public class Catalog
    {
        public Catalog(string bookname, string author, string style, Category category, DateTime dateofrelease, string description, double price, string linktocover)
        {
            this.bookname = bookname;
            this.author = author;
            this.style = style;
            this.category = category;
            this.dateofrelease = dateofrelease;
            this.description = description;
            this.price = price;
            this.linktocover = linktocover;        

        }

        public string bookname { get; set; }
        public string author { get; set; }
        public string style { get; set; }
        public Category category { get; set; }
        public DateTime dateofrelease { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string linktocover { get; set; }
        public string shopname { get; set; }
        public string address { get; set; }
        public int instock { get; set; }
        public int expected { get; set; }


    }
}
