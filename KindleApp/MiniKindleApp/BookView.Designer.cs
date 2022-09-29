
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
            this.pageNumber = new System.Windows.Forms.TextBox();
            this.bookMark = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gotoPage = new System.Windows.Forms.TextBox();
            this.pageText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(22, 537);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(57, 62);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "<<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // removeMarkButton
            // 
            this.removeMarkButton.Location = new System.Drawing.Point(117, 537);
            this.removeMarkButton.Name = "removeMarkButton";
            this.removeMarkButton.Size = new System.Drawing.Size(96, 62);
            this.removeMarkButton.TabIndex = 1;
            this.removeMarkButton.Text = "Remove Bookmark";
            this.removeMarkButton.UseVisualStyleBackColor = true;
            this.removeMarkButton.Click += new System.EventHandler(this.removeMarkButton_Click);
            // 
            // goToPageButton
            // 
            this.goToPageButton.Location = new System.Drawing.Point(243, 537);
            this.goToPageButton.Name = "goToPageButton";
            this.goToPageButton.Size = new System.Drawing.Size(93, 32);
            this.goToPageButton.TabIndex = 2;
            this.goToPageButton.Text = "Go To Page";
            this.goToPageButton.UseVisualStyleBackColor = true;
            this.goToPageButton.Click += new System.EventHandler(this.goToPageButton_Click);
            // 
            // setMarkButton
            // 
            this.setMarkButton.Location = new System.Drawing.Point(370, 537);
            this.setMarkButton.Name = "setMarkButton";
            this.setMarkButton.Size = new System.Drawing.Size(90, 62);
            this.setMarkButton.TabIndex = 3;
            this.setMarkButton.Text = "Set Bookmark";
            this.setMarkButton.UseVisualStyleBackColor = true;
            this.setMarkButton.Click += new System.EventHandler(this.setMarkButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(504, 537);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(58, 62);
            this.nextPageButton.TabIndex = 4;
            this.nextPageButton.Text = ">>";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // pageNumber
            // 
            this.pageNumber.Enabled = false;
            this.pageNumber.Location = new System.Drawing.Point(222, 18);
            this.pageNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageNumber.Name = "pageNumber";
            this.pageNumber.Size = new System.Drawing.Size(219, 26);
            this.pageNumber.TabIndex = 6;
            // 
            // bookMark
            // 
            this.bookMark.Enabled = false;
            this.bookMark.Location = new System.Drawing.Point(222, 58);
            this.bookMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookMark.Name = "bookMark";
            this.bookMark.Size = new System.Drawing.Size(219, 26);
            this.bookMark.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(63, 18);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Page Number";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(63, 58);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 26);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Bookmark";
            // 
            // gotoPage
            // 
            this.gotoPage.Location = new System.Drawing.Point(243, 577);
            this.gotoPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gotoPage.Name = "gotoPage";
            this.gotoPage.Size = new System.Drawing.Size(91, 26);
            this.gotoPage.TabIndex = 10;
            // 
            // pageText
            // 
            this.pageText.Location = new System.Drawing.Point(86, 133);
            this.pageText.Multiline = true;
            this.pageText.Name = "pageText";
            this.pageText.Size = new System.Drawing.Size(413, 363);
            this.pageText.TabIndex = 11;
            this.pageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(63, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Title";
            // 
            // bookTitle
            // 
            this.bookTitle.Enabled = false;
            this.bookTitle.Location = new System.Drawing.Point(222, 92);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(219, 26);
            this.bookTitle.TabIndex = 13;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 622);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pageText);
            this.Controls.Add(this.gotoPage);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.bookMark);
            this.Controls.Add(this.pageNumber);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.setMarkButton);
            this.Controls.Add(this.goToPageButton);
            this.Controls.Add(this.removeMarkButton);
            this.Controls.Add(this.backButton);
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
        private System.Windows.Forms.TextBox pageNumber;
        private System.Windows.Forms.TextBox bookMark;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox gotoPage;
        private System.Windows.Forms.TextBox pageText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox bookTitle;
    }
}