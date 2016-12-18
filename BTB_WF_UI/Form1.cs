using BTB_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTB_WF_UI
{
    public partial class Form1 : Form
    {

        int timerCounter = 0;
        public List<string> covers = new List<string>();
        public List<string> covers1 = new List<string>();
        public List<PictureBox> pb = new List<PictureBox>();
        public List<Catalog> locallist1row = new List<Catalog>();
        public List<Catalog> locallist2row = new List<Catalog>();
        

        public Form1()
        {
            CallBackMy.callbackEventHandler = new CallBackMy.callbackEvent(this.Reload);
            InitializeComponent();
            pb.Add(pictureBox1);
            pb.Add(pictureBox2);
            pb.Add(pictureBox3);
            pb.Add(pictureBox4);
            pb.Add(pictureBox5);
            pb.Add(pictureBox6);
            pb.Add(pictureBox7);
            pb.Add(pictureBox8);
            timer1.Start();
            Repository re = new Repository();            
            MainWindowImages(0, 4);
            re.ListofCategoriesRequest();
            foreach(string str in re.ListofCategories)
            {
                CategoryListBox.Items.Add(str);
            }
        }

        private void InsertingtoWindow1row(List<Image> imagesna)
        {

            for (int i = 0; i < 4; i++)
            {
                pb[i].Invoke((MethodInvoker)(() => pb[i].Image = imagesna[i]));
            }
        }

        private void InsertingtoWindow2row(List<Image> imagesbs)
        {

            for (int i = 0; i < 4; i++)
            {
                pb[i + 4].Invoke((MethodInvoker)(() => pb[i + 4].Image = imagesbs[i]));
            }
        }

        private void InsertingtoDataGrid(List<Image> imagesbs)
        {

            for (int i = 0; i < imagesbs.Count(); i++)
            {


                MainFormDataGridView.Invoke((MethodInvoker)(() =>
                {
                    if (i % 4 == 0)
                        MainFormDataGridView.Rows.Add();
                    MainFormDataGridView.Rows[i / 4].Cells[i % 4].Value = imagesbs[i];
                }
                ));

            }
        }

        public List<string> GetCoverUrls(List<Catalog> booksDisplayed)
        {
            covers.Clear();
            foreach (Catalog b in booksDisplayed)
            {
                covers.Add(b.linktocover);

            }
            return covers;
        }

        public List<string> GetCoverUrls1(List<Catalog> booksDisplayed)
        {
            covers1.Clear();
            foreach (Catalog b in booksDisplayed)
            {
                covers1.Add(b.linktocover);

            }
            return covers1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++timerCounter;
            int startimage = 0;
            int endimage = 0;
            if (timerCounter % 3 == 0)
            {
                startimage = 0;
                endimage = 4;
            }

            else if (timerCounter % 3 == 1)
            {
                startimage = 4;
                endimage = 8;
            }
            else if (timerCounter % 3 == 2)
            {
                startimage = 8;
                endimage = 12;
            }

            MainWindowImages(startimage, endimage);
        }



        public void MainWindowImages(int s, int e)
        {
            Repository repo = new Repository();
            DownloadImages imagedownl = new DownloadImages();
            repo.NewlyReleased(s, e);
            imagedownl.DownloadImage(GetCoverUrls(repo.ListOfBooks), InsertingtoWindow1row, 100, 154);
            repo.BestSellers(s, e);
            imagedownl.DownloadImage(GetCoverUrls1(repo.ListOfBooks1), InsertingtoWindow2row, 100, 154);
            locallist1row.Clear();
            locallist2row.Clear();
            locallist1row = repo.ListOfBooks;
            locallist2row = repo.ListOfBooks1;
        }
        public void BookInfoWindowOpen(PictureBox pi1, int i)
        {
            BookInfo bi = new BookInfo();
            bi.pictureBox1.Image = pi1.Image;
            if (pi1 == pictureBox1 || pi1 == pictureBox2 || pi1 == pictureBox3 || pi1 == pictureBox4)
            {
                bi.label1.Text = locallist1row[i].bookname;
                bi.label2.Text = locallist1row[i].author;
                bi.label3.Text = locallist1row[i].style;
                bi.button1.Text = locallist1row[i].category.category;
                bi.label4.Text = locallist1row[i].dateofrelease.ToShortDateString();
                bi.label5.Text = locallist1row[i].description;
                bi.button2.Text = "$" + locallist1row[i].price.ToString();

            }
            else
            {
                bi.label1.Text = locallist2row[i].bookname;
                bi.label2.Text = locallist2row[i].author;
                bi.label3.Text = locallist2row[i].style;
                bi.button1.Text = locallist2row[i].category.category;
                bi.label4.Text = locallist2row[i].dateofrelease.ToShortDateString();
                bi.label5.Text = locallist2row[i].description;
                bi.button2.Text = "$" + locallist2row[i].price.ToString();

            }

            bi.Show();
        }


        public void ShowBooksfromCategory(string cat)
        {
            Repository re = new Repository();
            DownloadImages imagedownl = new DownloadImages();
            re.CategoryBook(cat);
            ShowHideSearchTable(false);
            imagedownl.DownloadImage(GetCoverUrls(re.ListOfBooks1), InsertingtoDataGrid, 100, 154);
            locallist1row.Clear();
            locallist1row = re.ListOfBooks1;
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            BookInfoWindowOpen(pictureBox1, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BookInfoWindowOpen(pictureBox2, 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BookInfoWindowOpen(pictureBox3, 2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BookInfoWindowOpen(pictureBox4, 3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BookInfoWindowOpen(pictureBox5, 0);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            BookInfoWindowOpen(pictureBox6, 1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            BookInfoWindowOpen(pictureBox7, 2);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            BookInfoWindowOpen(pictureBox8, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DownloadImages imagedownl = new DownloadImages();
            Repository re = new Repository();
            ShowHideSearchTable(false);           
            re.Search(SearchTextBox.Text);            
            imagedownl.DownloadImage(GetCoverUrls(re.ListOfBooks), InsertingtoDataGrid, 100, 154);
            locallist1row.Clear();
            locallist1row = re.ListOfBooks;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowHideSearchTable(true);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = MainFormDataGridView.CurrentCell.ColumnIndex + MainFormDataGridView.CurrentCell.RowIndex*4;
            BookInfo bi = new BookInfo();
            bi.pictureBox1.Image = BitmapToImage((Bitmap)MainFormDataGridView.CurrentCell.Value);
            bi.label1.Text = locallist1row[i].bookname;
            bi.label2.Text = locallist1row[i].author;
            bi.label3.Text = locallist1row[i].style;
            bi.button1.Text= locallist1row[i].category.category;
            bi.label4.Text = locallist1row[i].dateofrelease.ToShortDateString();
            bi.label5.Text = locallist1row[i].description;
            bi.button2.Text = "$" + locallist1row[i].price.ToString();
            bi.Show();
        }
        public Image BitmapToImage(Bitmap map)
        {
            Stream imageStream = new MemoryStream();
            map.Save(imageStream, ImageFormat.Png);
            return Image.FromStream(imageStream);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ShowBooksfromCategory(CategoryListBox.SelectedItem.ToString());
        }
        public void ShowHideSearchTable(bool val)
        {
            if (val==false)
            {
                timer1.Stop();
                MainFormDataGridView.Rows.Clear();
            }
            else
            {
                timer1.Start();
            }
                       
            pictureBox1.Visible = val;
            pictureBox2.Visible = val;
            pictureBox3.Visible = val;
            pictureBox4.Visible = val;
            pictureBox5.Visible = val;
            pictureBox6.Visible = val;
            pictureBox7.Visible = val;
            pictureBox8.Visible = val;
            NewlyReleasedLabel.Visible = val;
            BestSellersLabel.Visible = val;
            BackButton.Visible = !val;  
            MainFormDataGridView.Visible = !val;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CartForm cf = new CartForm();
            string availability;
            foreach (Cart cart in OrderListClass.Value)
            {
                if (cart.instock > 0)
                    availability = "Now";
                else
                    availability = "1 Day";
                cf.dataGridView1.Rows.Add(cart.bookname, cart.price,1,cart.shopname,availability);
            }
            
            cf.Show();
            cf.OverAllMoney();
            cf.label2.Text = cf.cash.ToString();

        }

       
        void Reload(string param)
        {
            ShowBooksfromCategory(param);
            
        }
    }
}
