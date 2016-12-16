using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Interop;
using System.Windows;
using System.Windows.Media.Imaging;


namespace BTB_UI
{
    public class DownloadCovers
    {
       

      

        public void DownloadImage(List<string> Urls, System.Windows.Controls.DataGrid datagrid, int imageWidth, int imageHeight)
        {
            List<ImageSource> ImagesList = new List<ImageSource>();
            for (int i = 0; i <= (Urls.Count - 1); i++)
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Urls[i]);
                myRequest.Method = "GET";
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                Bitmap img = new Bitmap(myResponse.GetResponseStream());
                myResponse.Close();
                var renewimg = Imaging.CreateBitmapSourceFromHBitmap(img.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromWidthAndHeight(imageWidth, imageHeight));
                ImagesList.Add(renewimg);
            }

            datagrid.Items.Add(ImagesList[1]);



            /*List<ImageSource> ImagesList = new List<ImageSource>();
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i <= (Urls.Count - 1); i++)
                {
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Urls[i]);
                    myRequest.Method = "GET";
                    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                    Bitmap img = new Bitmap(myResponse.GetResponseStream());
                    myResponse.Close();
                    var renewimg = Imaging.CreateBitmapSourceFromHBitmap(img.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromWidthAndHeight(imageWidth, imageHeight));
                    ImagesList.Add(renewimg);
                }
                datagrid.Dispatcher.BeginInvoke(new Action(delegate ()
                {
                    
                    datagrid.Items.Add(ImagesList[0]);

                }));

            });
            */



        }

       
    }
}
