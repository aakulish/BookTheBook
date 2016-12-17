using BTB_Data;
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
    public partial class BookInfo : Form
    {
        

        public BookInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            button1.Visible = false;            
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            dataGridView1.Visible = true;
            Repository re = new Repository();
            re.AvailableBook(label1.Text);
            foreach (ShopList jr in re.ListOfShops)
            {
                string sh = jr.shopname;
                string ad = jr.address;
                string ins = jr.instock.ToString();
                string ex = jr.expected.ToString();
                string[] items = {sh,ad,ins,ex};
                dataGridView1.Rows.Add(items);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;            
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            dataGridView1.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cart addtocart = new Cart(label1.Text,Convert.ToDouble(button2.Text.Remove(0,1)), dataGridView1.SelectedCells[0].Value.ToString(), Convert.ToInt32(dataGridView1.SelectedCells[2].Value), Convert.ToInt32(dataGridView1.SelectedCells[3].Value));
                OrderListClass cw = new OrderListClass();
                cw.OrderCart.Add(addtocart);
                
            }            
        }
    }
}
