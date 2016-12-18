using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_Data
{
    public class Cart
    {
        public Cart(string bookname,double price,string shopname, int instock, int expected)
        {
            this.bookname = bookname;
            this.price = price;
            this.shopname = shopname;            
            this.instock = instock;
            this.expected = expected;

        }
        public Cart(string bookname, double price, string shopname, int needed)
        {
            this.bookname = bookname;
            this.price = price;
            this.shopname = shopname;
            this.needed = needed;

        }
        public string bookname { get; set; }
        public string shopname { get; set; }        
        public int instock { get; set; }
        public int expected { get; set; }
        public double price { get; set; }
        public int needed { get; set; }
    }
}
