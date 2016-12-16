using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BTB_WF_UI
{
    class DownloadImages
    {
        


        public void DownloadImage(List<string> Urls, Action<List<Image>> onReady, int imageWidth, int imageHeight)
        {
            List<Image> ImagesList = new List<Image>();
            
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i <= (Urls.Count - 1); i++)
                {
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Urls[i]);
                    myRequest.Method = "GET";
                    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                    System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                    myResponse.Close();                    
                    ImagesList.Add((Image)(new Bitmap(bmp, new Size(imageWidth, imageHeight))));
                }
                onReady(ImagesList);
            });
        }
    }
}
