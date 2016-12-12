using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_Data
{
    public class Journal
    {
        public int ID { get; set; }
        public Book Book { get; set; }
        public Shop Shop { get; set; }
        public int InStock { get; set; }
        public int Expected { get; set; }
    }
}
