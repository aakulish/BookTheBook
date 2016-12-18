
using BTB_Data;
using BTB_WF_UI.Notifications;
using SendGrid;
using SendGrid.Helpers.Mail;
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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();

        }
        public double cash;
        public double OverAllMoney()
        {
            double cs = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cs = cs + (Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value) * Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value));
            }

            return cash = cs;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                OverAllMoney();
                label2.Text = cash.ToString(); ;
                OrderListClass.Intotal = cash;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int order = (int)rnd.Next(10000, 99999);
            EmailSender es = new EmailSender();
            SMS sms = new SMS();
            es.Notify(OrderListClass.Value, textBox1.Text,order);
            sms.Notify(OrderListClass.Value, textBox1.Text, order);
            this.Close();
            


        }
        
    }
}
