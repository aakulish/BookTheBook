namespace BTB_Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<BTB_Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BTB_Data.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            string[] str, splittedstring;
            char[] splitter = new char[] { ';' };

            str = File.ReadAllLines(@"BTB_UI\base1.csv", Encoding.GetEncoding("UTF-8"));
            for (int i = 0; i < str.Length; i++)
            {
                splittedstring = str[i].Split(splitter);

                string cat = splittedstring[2];
                var g = context.Category.Local.FirstOrDefault(c => c.category == cat);

                if (g != null)
                {

                }
                else
                {

                    g = new Category { category=splittedstring[2] };
                    context.Category.AddOrUpdate(c => c.category, g);
                }

                string k = splittedstring[0];
                var b = context.Books.Local.FirstOrDefault(c => c.BookName == k);

                if (b != null)
                {

                }
                else
                {

                    b = new Book { BookName = splittedstring[0], Author = splittedstring[1], Category = context.Category.Local.FirstOrDefault(l => l.category == g.category), Style = splittedstring[3], DateOfRelease = Convert.ToDateTime(splittedstring[4]), Description = splittedstring[5], Price = Convert.ToDouble(splittedstring[6]), LinkToCover = splittedstring[7] };
                    context.Books.AddOrUpdate(c => c.BookName, b);
                }






                string sn = splittedstring[8];
                var s = context.Shops.Local.FirstOrDefault(c => c.ShopName == sn);
                if (s != null)
                {

                }
                else
                {

                    s = new Shop { ShopName = splittedstring[8], Address = splittedstring[9] };
                    context.Shops.AddOrUpdate(c => c.ShopName, s);
                }


                context.Journal.AddOrUpdate(new Journal { Book = context.Books.Local.FirstOrDefault(m => m.BookName == b.BookName), Shop = context.Shops.Local.FirstOrDefault(r => r.ShopName == s.ShopName), InStock = Convert.ToInt16(splittedstring[10]), Expected = Convert.ToInt16(splittedstring[11]) });




            }
            
        }
    }
}
