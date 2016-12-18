namespace BTB_WF_UI
{
    partial class FormTEST
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CatGenreTabControl = new System.Windows.Forms.TabControl();
            this.CategoryPage = new System.Windows.Forms.TabPage();
            this.CategoryCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.GenrePage = new System.Windows.Forms.TabPage();
            this.GenreCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.WhatsNewGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CatGenreTabControl.SuspendLayout();
            this.CategoryPage.SuspendLayout();
            this.GenrePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WhatsNewGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(222, 15);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(623, 26);
            this.SearchTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(855, 14);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 28);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // CatGenreTabControl
            // 
            this.CatGenreTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CatGenreTabControl.Controls.Add(this.CategoryPage);
            this.CatGenreTabControl.Controls.Add(this.GenrePage);
            this.CatGenreTabControl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatGenreTabControl.ItemSize = new System.Drawing.Size(89, 25);
            this.CatGenreTabControl.Location = new System.Drawing.Point(14, 51);
            this.CatGenreTabControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CatGenreTabControl.Name = "CatGenreTabControl";
            this.CatGenreTabControl.SelectedIndex = 0;
            this.CatGenreTabControl.Size = new System.Drawing.Size(200, 499);
            this.CatGenreTabControl.TabIndex = 2;
            // 
            // CategoryPage
            // 
            this.CategoryPage.Controls.Add(this.CategoryCheckListBox);
            this.CategoryPage.Location = new System.Drawing.Point(4, 29);
            this.CategoryPage.Name = "CategoryPage";
            this.CategoryPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.CategoryPage.Size = new System.Drawing.Size(192, 466);
            this.CategoryPage.TabIndex = 0;
            this.CategoryPage.Text = "Categories";
            this.CategoryPage.UseVisualStyleBackColor = true;
            // 
            // CategoryCheckListBox
            // 
            this.CategoryCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryCheckListBox.FormattingEnabled = true;
            this.CategoryCheckListBox.Location = new System.Drawing.Point(0, 10);
            this.CategoryCheckListBox.Name = "CategoryCheckListBox";
            this.CategoryCheckListBox.Size = new System.Drawing.Size(192, 441);
            this.CategoryCheckListBox.TabIndex = 0;
            // 
            // GenrePage
            // 
            this.GenrePage.Controls.Add(this.GenreCheckListBox);
            this.GenrePage.Location = new System.Drawing.Point(4, 29);
            this.GenrePage.Name = "GenrePage";
            this.GenrePage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.GenrePage.Size = new System.Drawing.Size(192, 466);
            this.GenrePage.TabIndex = 1;
            this.GenrePage.Text = "Genres";
            this.GenrePage.UseVisualStyleBackColor = true;
            // 
            // GenreCheckListBox
            // 
            this.GenreCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenreCheckListBox.FormattingEnabled = true;
            this.GenreCheckListBox.Location = new System.Drawing.Point(0, 11);
            this.GenreCheckListBox.Name = "GenreCheckListBox";
            this.GenreCheckListBox.Size = new System.Drawing.Size(192, 441);
            this.GenreCheckListBox.TabIndex = 1;
            // 
            // WhatsNewGridView
            // 
            this.WhatsNewGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WhatsNewGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WhatsNewGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WhatsNewGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.WhatsNewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WhatsNewGridView.Location = new System.Drawing.Point(222, 80);
            this.WhatsNewGridView.Name = "WhatsNewGridView";
            this.WhatsNewGridView.RowHeadersVisible = false;
            this.WhatsNewGridView.Size = new System.Drawing.Size(708, 469);
            this.WhatsNewGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Releases";
            // 
            // FormTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WhatsNewGridView);
            this.Controls.Add(this.CatGenreTabControl);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "FormTEST";
            this.ShowIcon = false;
            this.Text = "BookTheBook";
            this.CatGenreTabControl.ResumeLayout(false);
            this.CategoryPage.ResumeLayout(false);
            this.GenrePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WhatsNewGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TabControl CatGenreTabControl;
        private System.Windows.Forms.TabPage CategoryPage;
        private System.Windows.Forms.TabPage GenrePage;
        private System.Windows.Forms.CheckedListBox CategoryCheckListBox;
        private System.Windows.Forms.CheckedListBox GenreCheckListBox;
        private System.Windows.Forms.DataGridView WhatsNewGridView;
        private System.Windows.Forms.Label label1;
    }
}