using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_Data
{
    public class Repository
    {
        public List<Catalog> ListOfBooks = new List<Catalog>();


        public List<Catalog> NewlyReleased(int start, int end)
        {
            ListOfBooks.Clear();
            Context context = new Context();
            var result = from b in context.Books
                         orderby b.DateOfRelease descending
                         select b;


            for (int i = start; i < end; i++)
            {
                var re = result.ToList()[i];
                var re1 = new Catalog(re.BookName, re.Author, re.Style, re.Category, re.DateOfRelease, re.Description, re.Price, re.LinkToCover);
                ListOfBooks.Add(re1);
            }

            return ListOfBooks;
        }

        public List<Catalog> BestSellers(int start, int end)
        {
            ListOfBooks.Clear();
            Context context = new Context();
            var result1 = from b in context.Journal
                          where b.InStock != 0
                          orderby b.InStock ascending
                          select b.Book;


            for (int i = start; i < end; i++)
            {
                var ren = result1.ToList()[i];
                var re2 = new Catalog(ren.BookName, ren.Author, ren.Style, ren.Category, ren.DateOfRelease, ren.Description, ren.Price, ren.LinkToCover);
                ListOfBooks.Add(re2);
            }

            return ListOfBooks;
        }
    }
}