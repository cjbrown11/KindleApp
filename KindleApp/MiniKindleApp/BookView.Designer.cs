
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
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(30, 672);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(77, 76);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "<<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // removeMarkButton
            // 
            this.removeMarkButton.Location = new System.Drawing.Point(155, 672);
            this.removeMarkButton.Name = "removeMarkButton";
            this.removeMarkButton.Size = new System.Drawing.Size(127, 76);
            this.removeMarkButton.TabIndex = 1;
            this.removeMarkButton.Text = "Remove Bookmark";
            this.removeMarkButton.UseVisualStyleBackColor = true;
            this.removeMarkButton.Click += new System.EventHandler(this.removeMarkButton_Click);
            // 
            // goToPageButton
            // 
            this.goToPageButton.Location = new System.Drawing.Point(324, 672);
            this.goToPageButton.Name = "goToPageButton";
            this.goToPageButton.Size = new System.Drawing.Size(124, 76);
            this.goToPageButton.TabIndex = 2;
            this.goToPageButton.Text = "Go To Page";
            this.goToPageButton.UseVisualStyleBackColor = true;
            this.goToPageButton.Click += new System.EventHandler(this.goToPageButton_Click);
            // 
            // setMarkButton
            // 
            this.setMarkButton.Location = new System.Drawing.Point(494, 672);
            this.setMarkButton.Name = "setMarkButton";
            this.setMarkButton.Size = new System.Drawing.Size(121, 76);
            this.setMarkButton.TabIndex = 3;
            this.setMarkButton.Text = "Set Bookmark";
            this.setMarkButton.UseVisualStyleBackColor = true;
            this.setMarkButton.Click += new System.EventHandler(this.setMarkButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(672, 672);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(78, 76);
            this.nextPageButton.TabIndex = 4;
            this.nextPageButton.Text = ">>";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // bookViewBox
            // 
            this.bookViewBox.FormattingEnabled = true;
            this.bookViewBox.ItemHeight = 25;
            this.bookViewBox.Location = new System.Drawing.Point(30, 37);
            this.bookViewBox.Name = "bookViewBox";
            this.bookViewBox.Size = new System.Drawing.Size(712, 604);
            this.bookViewBox.TabIndex = 5;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 777);
            this.Controls.Add(this.bookViewBox);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.setMarkButton);
            this.Controls.Add(this.goToPageButton);
            this.Controls.Add(this.removeMarkButton);
            this.Controls.Add(this.backButton);
            this.Name = "BookView";
            this.Text = "BookView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button removeMarkButton;
        private System.Windows.Forms.Button goToPageButton;
        private System.Windows.Forms.Button setMarkButton;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.ListBox bookViewBox;
    }
}