using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_Data
{
    public class Context : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Journal> Journal { get; set; }



        public Context() : base("testbase4")
        {
        }
    }
}
