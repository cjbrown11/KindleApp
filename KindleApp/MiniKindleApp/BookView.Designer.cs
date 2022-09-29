
namespace MiniKindleApp
{
    partial class BookView
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
            this.backButton = new System.Windows.Forms.Button();
            this.removeMarkButton = new System.Windows.Forms.Button();
            this.goToPageButton = new System.Windows.Forms.Button();
            this.setMarkButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.bookViewBox = new System.Windows.Forms.ListBox();
            this.pageNumber = new System.Windows.Forms.TextBox();
            this.bookMark = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gotoPage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(15, 349);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(38, 40);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "<<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // removeMarkButton
            // 
            this.removeMarkButton.Location = new System.Drawing.Point(78, 349);
            this.removeMarkButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeMarkButton.Name = "removeMarkButton";
            this.removeMarkButton.Size = new System.Drawing.Size(64, 40);
            this.removeMarkButton.TabIndex = 1;
            this.removeMarkButton.Text = "Remove Bookmark";
            this.removeMarkButton.UseVisualStyleBackColor = true;
            this.removeMarkButton.Click += new System.EventHandler(this.removeMarkButton_Click);
            // 
            // goToPageButton
            // 
            this.goToPageButton.Location = new System.Drawing.Point(162, 349);
            this.goToPageButton.Margin = new System.Windows.Forms.Padding(2);
            this.goToPageButton.Name = "goToPageButton";
            this.goToPageButton.Size = new System.Drawing.Size(62, 21);
            this.goToPageButton.TabIndex = 2;
            this.goToPageButton.Text = "Go To Page";
            this.goToPageButton.UseVisualStyleBackColor = true;
            this.goToPageButton.Click += new System.EventHandler(this.goToPageButton_Click);
            // 
            // setMarkButton
            // 
            this.setMarkButton.Location = new System.Drawing.Point(247, 349);
            this.setMarkButton.Margin = new System.Windows.Forms.Padding(2);
            this.setMarkButton.Name = "setMarkButton";
            this.setMarkButton.Size = new System.Drawing.Size(60, 40);
            this.setMarkButton.TabIndex = 3;
            this.setMarkButton.Text = "Set Bookmark";
            this.setMarkButton.UseVisualStyleBackColor = true;
            this.setMarkButton.Click += new System.EventHandler(this.setMarkButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(336, 349);
            this.nextPageButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(39, 40);
            this.nextPageButton.TabIndex = 4;
            this.nextPageButton.Text = ">>";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // bookViewBox
            // 
            this.bookViewBox.FormattingEnabled = true;
            this.bookViewBox.Location = new System.Drawing.Point(15, 71);
            this.bookViewBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookViewBox.Name = "bookViewBox";
            this.bookViewBox.Size = new System.Drawing.Size(358, 264);
            this.bookViewBox.TabIndex = 5;
            this.bookViewBox.SelectedIndexChanged += new System.EventHandler(this.bookViewBox_SelectedIndexChanged);
            // 
            // pageNumber
            // 
            this.pageNumber.Enabled = false;
            this.pageNumber.Location = new System.Drawing.Point(148, 12);
            this.pageNumber.Name = "pageNumber";
            this.pageNumber.Size = new System.Drawing.Size(100, 20);
            this.pageNumber.TabIndex = 6;
            this.pageNumber.TextChanged += new System.EventHandler(this.pageNumber_TextChanged);
            // 
            // bookMark
            // 
            this.bookMark.Enabled = false;
            this.bookMark.Location = new System.Drawing.Point(148, 38);
            this.bookMark.Name = "bookMark";
            this.bookMark.Size = new System.Drawing.Size(100, 20);
            this.bookMark.TabIndex = 7;
            this.bookMark.TextChanged += new System.EventHandler(this.bookMark_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(42, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Page Number";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(42, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "BookMark";
            // 
            // gotoPage
            // 
            this.gotoPage.Location = new System.Drawing.Point(162, 375);
            this.gotoPage.Name = "gotoPage";
            this.gotoPage.Size = new System.Drawing.Size(62, 20);
            this.gotoPage.TabIndex = 10;
            this.gotoPage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 404);
            this.Controls.Add(this.gotoPage);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.bookMark);
            this.Controls.Add(this.pageNumber);
            this.Controls.Add(this.bookViewBox);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.setMarkButton);
            this.Controls.Add(this.goToPageButton);
            this.Controls.Add(this.removeMarkButton);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookView";
            this.Text = "BookView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button removeMarkButton;
        private System.Windows.Forms.Button goToPageButton;
        private System.Windows.Forms.Button setMarkButton;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.ListBox bookViewBox;
        private System.Windows.Forms.TextBox pageNumber;
        private System.Windows.Forms.TextBox bookMark;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox gotoPage;
    }
}