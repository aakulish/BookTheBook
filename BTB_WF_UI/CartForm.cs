
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
        public string cash;
        public string OverAllMoney()
        {
            double cs = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cs = cs + (Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value) * Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value));
            }

            return cash = cs.ToString();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            OverAllMoney();
            label2.Text = cash;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmailSender es = new EmailSender();
            es.Notify(OrderListClass.Value, textBox1.Text);

        }
        
    }
}
