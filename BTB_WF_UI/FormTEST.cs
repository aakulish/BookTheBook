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
    public partial class FormTEST : Form
    {
        public FormTEST()
        {
            InitializeComponent();

            // Populate the Category and Genre listboxes here


            // Populate the DataGridView with New Releases. Just add the pictures for now, I'll add some data after you do that.

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataGridViewHeaderLabel.Text = "Search Results";

            // Populate the DataGridView with Search Results, same as before, just the pictures for now. I suggest that the search goes through both the names and descriptions of books/journals etc.

        }
    }
}
