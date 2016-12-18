using BTB_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BTB_WF_UI.Notifications
{
    public class SMS:INotify
    {
        public void Notify(List<Cart> listofitems, string recipient, int ordernum)
        {
            Execute(listofitems, recipient, ordernum);
        }
        static void Execute(List<Cart> listofitems,string recipient, int ordernum)
        {
                      
            string textofmessage = String.Format("Thanks for Your order:  {0}\n", ordernum);
            textofmessage = textofmessage + String.Format("\nIn Total: ${0}\n\n Best wishes, Your BooktheBook", OrderListClass.Intotal);
            string URL = String.Format("https://gate.smsaero.ru/send/?user=1kulish@mail.ru&password=andrey19&to={0}&text={1}&from=news",recipient,textofmessage);

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(URL);

        }
        
    }
}
