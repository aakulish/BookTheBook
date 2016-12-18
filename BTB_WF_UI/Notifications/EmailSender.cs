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
        public void Notify(List<Cart> listofitems, string recipient)
        {
            Execute(listofitems,recipient).Wait();
        }
        static async Task Execute(List<Cart> listofitems, string recipient)
        {
            string textofmessage = "Thanks for Your order \n \n You booked";
            string apiKey = "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";
            dynamic sg = new SendGridAPIClient(apiKey);
            SendGrid.Helpers.Mail.Email from = new Email("bookthebookshop@example.com");
            string subject = "Sending with SendGrid is Fun";
            Email to = new Email(recipient);
            CartForm cf = new CartForm();
            string availability;
            for (int i = 0; i < listofitems.Count; i++)
            {

                if (listofitems[i].instock > 0)
                    availability = "Now";
                else
                    availability = "1 Day";
                textofmessage = textofmessage + String.Format("\n {0,40}    {1,8}      {2,5}     {3,20}    {4,10}", listofitems[i].bookname, listofitems[i].price, cf.dataGridView1.Rows[i].Cells[2].Value, listofitems[i].shopname, availability);

            }
            textofmessage = textofmessage + "\n Best regards";
            Content content = new Content("text/plain", textofmessage);
            Mail mail = new Mail(from, subject, to, content);
            dynamic response = await sg.client.mail.send.post(requestBody: mail.Get());
        }
    }
}
