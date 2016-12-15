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
            DataGridTemplateColumn imagecol1 = new DataGridTemplateColumn();
            DataGridTemplateColumn imagecol2 = new DataGridTemplateColumn();
            DataGridTemplateColumn imagecol3 = new DataGridTemplateColumn();
            DataGridTemplateColumn imagecol4 = new DataGridTemplateColumn();  
                    
            dataGridView1.Columns.Add(imagecol1);
            dataGridView1.Columns.Add(imagecol2);
            dataGridView1.Columns.Add(imagecol3);
            dataGridView1.Columns.Add(imagecol4);

            Repository re = new Repository();
            re.NewlyReleased();
            /*DownloadCovers imgdownl = new DownloadCovers();
            imgdownl.DownloadImage(GetCoverUrls(re.ListOfBooks), dataGridView1, 180, 252);
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

        private void OnDownloaded(List<Image> images)
        {

            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        List<>
    }
}
