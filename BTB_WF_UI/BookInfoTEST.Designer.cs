namespace BTB_WF_UI
{
    partial class BookInfoTEST
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChooseShopLabel = new System.Windows.Forms.Label();
            this.ChooseShopDataGridView = new System.Windows.Forms.DataGridView();
            this.ShopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NowColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TomorrowColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseShopDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 154);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ChooseShopLabel
            // 
            this.ChooseShopLabel.AutoSize = true;
            this.ChooseShopLabel.Location = new System.Drawing.Point(118, 12);
            this.ChooseShopLabel.Name = "ChooseShopLabel";
            this.ChooseShopLabel.Size = new System.Drawing.Size(94, 20);
            this.ChooseShopLabel.TabIndex = 3;
            this.ChooseShopLabel.Text = "Choose shop:";
            // 
            // ChooseShopDataGridView
            // 
            this.ChooseShopDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseShopDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChooseShopDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChooseShopDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChooseShopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChooseShopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShopColumn,
            this.AddressColumn,
            this.NowColumn,
            this.TomorrowColumn});
            this.ChooseShopDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.ChooseShopDataGridView.Location = new System.Drawing.Point(122, 37);
            this.ChooseShopDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChooseShopDataGridView.Name = "ChooseShopDataGridView";
            this.ChooseShopDataGridView.RowHeadersVisible = false;
            this.ChooseShopDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseShopDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ChooseShopDataGridView.Size = new System.Drawing.Size(353, 129);
            this.ChooseShopDataGridView.TabIndex = 5;
            // 
            // ShopColumn
            // 
            this.ShopColumn.HeaderText = "Shop";
            this.ShopColumn.Name = "ShopColumn";
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            // 
            // NowColumn
            // 
            this.NowColumn.HeaderText = "Now";
            this.NowColumn.Name = "NowColumn";
            // 
            // TomorrowColumn
            // 
            this.TomorrowColumn.HeaderText = "Tomorrow";
            this.TomorrowColumn.Name = "TomorrowColumn";
            // 
            // BookInfoTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(488, 255);
            this.Controls.Add(this.ChooseShopDataGridView);
            this.Controls.Add(this.ChooseShopLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookInfoTEST";
            this.ShowIcon = false;
            this.Text = "Book Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseShopDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ChooseShopLabel;
        private System.Windows.Forms.DataGridView ChooseShopDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NowColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TomorrowColumn;
    }
}