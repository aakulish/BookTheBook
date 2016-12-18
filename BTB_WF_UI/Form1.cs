using BTB_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form1()
        {
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
            Repository repo = new Repository();            
            DownloadImages imagedownl = new DownloadImages();    
            repo.BestSellers(0, 4);
            imagedownl.DownloadImage(GetCoverUrls(repo.ListOfBooks), InsertingtoWindow2row, 100, 154);            
            repo.NewlyReleased(0, 4);
            imagedownl.DownloadImage(GetCoverUrls1(repo.ListOfBooks), InsertingtoWindow1row, 100, 154);

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
                pb[i+4].Invoke((MethodInvoker)(() => pb[i+4].Image = imagesbs[i]));
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
            int startimage=0;
            int endimage=0;
            if (timerCounter%3==0)
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

            Repository repo = new Repository();            
            DownloadImages imagedownl = new DownloadImages();
            repo.NewlyReleased(startimage, endimage);
            imagedownl.DownloadImage(GetCoverUrls(repo.ListOfBooks), InsertingtoWindow1row, 100, 154);
            repo.BestSellers(startimage, endimage);
            imagedownl.DownloadImage(GetCoverUrls1(repo.ListOfBooks), InsertingtoWindow2row, 100, 154);
        }

        
    }
}
