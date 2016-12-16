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


        public List<Catalog> NewlyReleased(int start,int end)
        {
            ListOfBooks.Clear();
            Context context = new Context();
            var result = from b in context.Books
                         orderby b.DateOfRelease descending
                         select b;
                       
                         
            for(int i=start;i<end; i++)
            {
                var re = result.ToList()[i];
                var re1 = new Catalog(re.BookName, re.Author, re.Style, re.Category, re.DateOfRelease, re.Description, re.Price, re.LinkToCover);
                ListOfBooks.Add(re1);
            }

            return ListOfBooks;
        }
    }
}
