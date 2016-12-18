namespace BTB_WF_UI
{
    partial class CartFormTEST
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
            this.CartGridView = new System.Windows.Forms.DataGridView();
            this.BookColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailiableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalContentLabel = new System.Windows.Forms.Label();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.ConfirmOrderButton = new System.Windows.Forms.Button();
            this.DeleteBookRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CartGridView
            // 
            this.CartGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CartGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CartGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookColumn,
            this.PriceColumn,
            this.QuantityColumn,
            this.ShopColumn,
            this.AvailiableColumn});
            this.CartGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.CartGridView.Location = new System.Drawing.Point(16, 18);
            this.CartGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.RowHeadersVisible = false;
            this.CartGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CartGridView.Size = new System.Drawing.Size(422, 50);
            this.CartGridView.TabIndex = 4;
            // 
            // BookColumn
            // 
            this.BookColumn.HeaderText = "Book";
            this.BookColumn.Name = "BookColumn";
            this.BookColumn.ReadOnly = true;
            this.BookColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ShopColumn
            // 
            this.ShopColumn.HeaderText = "Shop";
            this.ShopColumn.Name = "ShopColumn";
            this.ShopColumn.ReadOnly = true;
            this.ShopColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AvailiableColumn
            // 
            this.AvailiableColumn.HeaderText = "Availiable";
            this.AvailiableColumn.Name = "AvailiableColumn";
            this.AvailiableColumn.ReadOnly = true;
            this.AvailiableColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(19, 129);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(41, 20);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalContentLabel
            // 
            this.TotalContentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalContentLabel.AutoSize = true;
            this.TotalContentLabel.Location = new System.Drawing.Point(55, 129);
            this.TotalContentLabel.Name = "TotalContentLabel";
            this.TotalContentLabel.Size = new System.Drawing.Size(45, 20);
            this.TotalContentLabel.TabIndex = 6;
            this.TotalContentLabel.Text = "label2";
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(363, 125);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(75, 28);
            this.ClearCartButton.TabIndex = 7;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmOrderButton.Location = new System.Drawing.Point(257, 125);
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.Size = new System.Drawing.Size(100, 28);
            this.ConfirmOrderButton.TabIndex = 8;
            this.ConfirmOrderButton.Text = "Confirm Order";
            this.ConfirmOrderButton.UseVisualStyleBackColor = true;
            // 
            // DeleteBookRowButton
            // 
            this.DeleteBookRowButton.Location = new System.Drawing.Point(17, 79);
            this.DeleteBookRowButton.Name = "DeleteBookRowButton";
            this.DeleteBookRowButton.Size = new System.Drawing.Size(93, 28);
            this.DeleteBookRowButton.TabIndex = 9;
            this.DeleteBookRowButton.Text = "Delete Book";
            this.DeleteBookRowButton.UseVisualStyleBackColor = true;
            // 
            // CartFormTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(454, 173);
            this.Controls.Add(this.DeleteBookRowButton);
            this.Controls.Add(this.ConfirmOrderButton);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.TotalContentLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.CartGridView);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(470, 180);
            this.Name = "CartFormTEST";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Your Cart";
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CartGridView;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailiableColumn;
        private System.Windows.Forms.Label TotalContentLabel;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button ConfirmOrderButton;
        private System.Windows.Forms.Button DeleteBookRowButton;
    }
}