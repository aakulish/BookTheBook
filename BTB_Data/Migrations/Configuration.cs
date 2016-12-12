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

            str = File.ReadAllLines(@"base.csv", Encoding.GetEncoding("UTF-8"));
            for (int i = 0; i < str.Length; i++)
            {
                splittedstring = str[i].Split(splitter);

                string k = splittedstring[0];
                var b = context.Books.Local.FirstOrDefault(c => c.BookName == k);

                if (b != null)
                {

                }
                else
                {

                    b = new Book { BookName = splittedstring[0],Author= splittedstring[1],Style= splittedstring[2],DateOfRelease= Convert.ToDateTime(splittedstring[3]),Description= splittedstring[4],Price=Convert.ToDouble(splittedstring[5]),LinkToCover= splittedstring[6] };
                    context.Books.AddOrUpdate(c => c.BookName, b);
                }


                string sn = splittedstring[2];
                var s = context.Shops.Local.FirstOrDefault(c => c.ShopName == sn);
                if (s != null)
                {

                }
                else
                {

                    s = new Shop { ShopName = splittedstring[7], Address = splittedstring[8] };
                    context.Shops.AddOrUpdate(c => c.ShopName, s);
                }


                context.Journal.AddOrUpdate(new Journal { Book = context.Books.Local.FirstOrDefault(m => m.BookName == b.BookName), Shop = context.Shops.Local.FirstOrDefault(r => r.ShopName == s.ShopName), InStock = Convert.ToInt16(splittedstring[9]), Expected = Convert.ToInt16(splittedstring[10]) });




            }
        }
    }
}
