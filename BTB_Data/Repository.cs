using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_Data
{
    public class Repository
    {
        public List<Catalog> ListOfBooks= new List<Catalog>();
        public List<Catalog> NewlyReleased()
        {
            ListOfBooks.Clear();
            Context context = new Context();
            var result = from b in context.Books
                         orderby b.DateOfRelease descending
                         select b;

            
                         
            for(int i=0; i<8; i++)
            {
               
            }

            return ListOfBooks;
        }
    }
}
