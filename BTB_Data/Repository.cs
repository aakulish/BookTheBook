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
        public List<Catalog> ListOfBooks1 = new List<Catalog>();
        public List<ShopList> ListOfShops = new List<ShopList>();
        public List<string> ListofCategories = new List<string>();


        public List<Catalog> NewlyReleased(int start,int end)
        {
            ListOfBooks.Clear();
            Context context = new Context();
            var result = from b in context.Books                         
                         orderby b.DateOfRelease descending
                         select b;
            var resultwithcategory = from b in result
                                     select b.Category;

            for (int i=start;i<end; i++)
            {
                var re = result.ToList()[i];
                var cat = resultwithcategory.ToList()[i];
                var re1 = new Catalog(re.BookName, re.Author, re.Style, cat, re.DateOfRelease, re.Description, re.Price, re.LinkToCover);
                ListOfBooks.Add(re1);
            }
           
            return ListOfBooks;
        }

        public List<Catalog> BestSellers(int start, int end)
        {
            ListOfBooks1.Clear();
            Context context = new Context();
            var result = from b in context.Journal
                         where b.InStock!=0
                         orderby b.InStock ascending
                         select b.Book;

            var resultwithcategory = from b in result
                      select b.Category;
                    
            for (int i = start; i < end; i++)
            {
                var re = result.ToList()[i];
                var cat = resultwithcategory.ToList()[i];
                var re2 = new Catalog(re.BookName, re.Author, re.Style, cat, re.DateOfRelease, re.Description, re.Price, re.LinkToCover);
                ListOfBooks1.Add(re2);
            }

            return ListOfBooks1;
        }

        public List<ShopList> AvailableBook(string nameofbook)
        {
            ListOfShops.Clear();
            Context context = new Context();
            var result = from b in context.Journal
                         where b.Book.BookName == nameofbook
                         orderby b.InStock descending
                         select b;

            var resultwithshop = from b in result
                                     select b.Shop;


            for (int i = 0; i < result.Count(); i++)
            {
                var re = result.ToList()[i];
                var re1 = resultwithshop.ToList()[i];
                ShopList j = new ShopList(re1.ShopName,re1.Address,re.InStock,re.Expected);                
                ListOfShops.Add(j);
            }

            return ListOfShops;
        }

        public List<Catalog> Search(string searchquery)
        {
            ListOfBooks.Clear();
            Context context = new Context();
            var result1 = from b in context.Books
                          where b.BookName.Contains(searchquery) || b.Description.Contains(searchquery) || b.Author.Contains(searchquery) || b.Style.Contains(searchquery)
                          select b;
            var resultwithcategory = from b in result1
                                     select b.Category;

            for (int i = 0; i < result1.Count(); i++)
            {
                var ren = result1.ToList()[i];
                var cat = resultwithcategory.ToList()[i];
                var re2 = new Catalog(ren.BookName, ren.Author, ren.Style, cat, ren.DateOfRelease, ren.Description, ren.Price, ren.LinkToCover);
                ListOfBooks.Add(re2);
            }

            return ListOfBooks;
        }

        public List<string> ListofCategoriesRequest()
        {
            ListofCategories.Clear();
            Context context = new Context();
            var result1 = from b in context.Category
                          select b.category;
            

            foreach(string str in result1)
            {
                ListofCategories.Add(str);
            }

            return ListofCategories;
        }


        public List<Catalog> CategoryBook(string searchcategory)
        {
            ListOfBooks1.Clear();
            Context context = new Context();
            var result1 = from b in context.Books
                          where b.Category.category== searchcategory
                          select b;
            var resultwithcategory = from b in result1
                                     select b.Category;

            for (int i = 0; i < result1.Count(); i++)
            {
                var ren = result1.ToList()[i];
                var cat = resultwithcategory.ToList()[i];
                var re2 = new Catalog(ren.BookName, ren.Author, ren.Style, cat, ren.DateOfRelease, ren.Description, ren.Price, ren.LinkToCover);
                ListOfBooks1.Add(re2);
            }

            return ListOfBooks1;
        }
    }
}
