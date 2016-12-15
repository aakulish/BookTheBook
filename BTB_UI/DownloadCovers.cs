using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;

namespace BTB_UI
{
    public class DownloadCovers
    {
        public Bitmap ImageRequest(string Url)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
            myRequest.Method = "GET";
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            Bitmap bmp = new Bitmap(myResponse.GetResponseStream());
            myResponse.Close();
            return bmp;
        }


        public void DownloadImage(List<string> Urls, System.Windows.Controls.DataGrid datagrid, int imageWidth, int imageHeight)
        {
            List<Bitmap> ImagesList = new List<Bitmap>();
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i <= (Urls.Count - 1); i++)
                {
                    Bitmap img = ImageRequest(Urls[i]);
                    ImagesList.Add(new Bitmap(img, new Size(imageWidth, imageHeight)));

                }
                datagrid.Dispatcher.BeginInvoke(new Action(delegate ()
                {
                    DataGridTemplateColumn imagecol1 = new DataGridTemplateColumn();
                    DataGridTemplateColumn imagecol2 = new DataGridTemplateColumn();
                    DataGridTemplateColumn imagecol3 = new DataGridTemplateColumn();
                    DataGridTemplateColumn imagecol4 = new DataGridTemplateColumn();

                    datagrid.Columns.Add(imagecol1);
                    datagrid.Columns.Add(imagecol2);
                    datagrid.Columns.Add(imagecol3);
                    datagrid.Columns.Add(imagecol4);
                    datagrid.Items.Clear();
                    datagrid.Items.Add(ImagesList[1]);
                    imagecol1.CellTemplate.Resources.Source = ImagesList[1];
                }));

            });

        }
    }
}
