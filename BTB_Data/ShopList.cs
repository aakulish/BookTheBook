using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_Data
{
    public class ShopList
    {
        public ShopList(string shopname,string address,int instock,int expected)
        {
            this.shopname = shopname;
            this.address = address;
            this.instock = instock;
            this.expected = expected;

        }

        public string shopname { get; set; }
        public string address { get; set; }
        public int instock { get; set; }
        public int expected { get; set; }
    }
}
