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
        public List<PictureBox> pb = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            Repository re = new Repository();
            re.NewlyReleased(0,4);
            DownloadImages imgdownl = new DownloadImages();
            imgdownl.DownloadImage(GetCoverUrls(re.ListOfBooks), InsertingtoWindow, 100, 154);
            pb.Add(pictureBox1);
            pb.Add(pictureBox2);
            pb.Add(pictureBox3);
            pb.Add(pictureBox4);            
            timer1.Start();


        }

        private void InsertingtoWindow(List<Image> images)
        {
            
            for (int i = 0; i < 4; i++)
            {                
                pictureBox1.Invoke((MethodInvoker)(() => pb[i].Image = images[i]));
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

            Repository re = new Repository();
            re.NewlyReleased(startimage, endimage);
            DownloadImages imgdownl = new DownloadImages();
            imgdownl.DownloadImage(GetCoverUrls(re.ListOfBooks), InsertingtoWindow, 100, 154);
        }
    }
}
