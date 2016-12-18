using BTB_Data;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_WF_UI
{
    public class EmailSender:INotify
    {
        public void Notify(List<Cart> listofitems, string recipient, int ordernum)
        {
            Execute(listofitems,recipient,ordernum).Wait();
        }
        static async Task Execute(List<Cart> listofitems, string recipient,int ordernum)
        {
            string textofmessage = "Thanks for Your order! \n \n You booked\n";
            string apiKey = "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";
            dynamic sg = new SendGridAPIClient(apiKey);
            SendGrid.Helpers.Mail.Email from = new Email("bookthebookshop@example.com");            
            string subject = String.Format("BookTheBook New Order:  {0}",ordernum);
            Email to = new Email(recipient);                    
            string availability;
            for (int i = 0; i < listofitems.Count; i++)
            {
                string bookn;
                if (listofitems[i].instock > 0)
                    availability = "Now";
                else
                    availability = "1 Day";
                if (listofitems[i].bookname.Length >= 34)
                    bookn = listofitems[i].bookname.Remove(35);
                else
                    bookn = listofitems[i].bookname.ToString();

                textofmessage = textofmessage + String.Format("\n {0,-50}    {1,-8}      {2,-5}     {3,-20}    {4,-10}", bookn, listofitems[i].price, 1, listofitems[i].shopname, availability);

            }
            textofmessage = textofmessage + String.Format("\n In Total: ${0}\n\n Best wishes Your BooktheBook", OrderListClass.Intotal);
            Content content = new Content("text/plain", textofmessage);
            Mail mail = new Mail(from, subject, to, content);
            dynamic response = await sg.client.mail.send.post(requestBody: mail.Get());
        }
    }
}
