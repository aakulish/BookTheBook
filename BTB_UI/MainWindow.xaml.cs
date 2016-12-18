using BTB_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;




namespace BTB_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        /* 

            Repository re = new Repository();
            re.NewlyReleased();
            DownloadCovers imgdownl = new DownloadCovers();
            imgdownl.DownloadImage(GetCoverUrls(re.ListOfBooks), dataGridView1, 100, 154);
          */  

        }

        public List<string> covers;

        public List<string> GetCoverUrls(List<Catalog> booksDisplayed)
        {
            covers = new List<string>();
            covers.Clear();
            foreach (Catalog b in booksDisplayed)
            {
                covers.Add(b.linktocover);

            }
            return covers;
        }
    }
}
