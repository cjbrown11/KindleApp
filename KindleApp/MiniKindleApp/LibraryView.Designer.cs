
namespace MiniKindleApp
{
    partial class LibraryView
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
            this.bookListView = new System.Windows.Forms.ListBox();
            this.synchronizeButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookListView
            // 
            this.bookListView.FormattingEnabled = true;
            this.bookListView.ItemHeight = 25;
            this.bookListView.Location = new System.Drawing.Point(100, 83);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(400, 404);
            this.bookListView.TabIndex = 0;
            // 
            // synchronizeButton
            // 
            this.synchronizeButton.Location = new System.Drawing.Point(100, 552);
            this.synchronizeButton.Name = "synchronizeButton";
            this.synchronizeButton.Size = new System.Drawing.Size(171, 77);
            this.synchronizeButton.TabIndex = 1;
            this.synchronizeButton.Text = "Synchronize";
            this.synchronizeButton.UseVisualStyleBackColor = true;
            this.synchronizeButton.Click += new System.EventHandler(this.synchronizeButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(343, 552);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(157, 77);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 680);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.synchronizeButton);
            this.Controls.Add(this.bookListView);
            this.Name = "LibraryView";
            this.Text = "KindleApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookListView;
        private System.Windows.Forms.Button synchronizeButton;
        private System.Windows.Forms.Button selectButton;
    }
}

