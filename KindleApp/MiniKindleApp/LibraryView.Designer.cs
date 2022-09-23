
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
            this.synchronizeButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.bookListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // synchronizeButton
            // 
            this.synchronizeButton.Location = new System.Drawing.Point(67, 353);
            this.synchronizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.synchronizeButton.Name = "synchronizeButton";
            this.synchronizeButton.Size = new System.Drawing.Size(114, 49);
            this.synchronizeButton.TabIndex = 1;
            this.synchronizeButton.Text = "Synchronize";
            this.synchronizeButton.UseVisualStyleBackColor = true;
            this.synchronizeButton.Click += new System.EventHandler(this.synchronizeButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(229, 353);
            this.selectButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(105, 49);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // bookListView
            // 
            this.bookListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.bookListView.HideSelection = false;
            this.bookListView.Location = new System.Drawing.Point(29, 33);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(354, 290);
            this.bookListView.TabIndex = 3;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 435);
            this.Controls.Add(this.bookListView);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.synchronizeButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LibraryView";
            this.Text = "KindleApp";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button synchronizeButton;
        private System.Windows.Forms.Button selectButton;
        public System.Windows.Forms.ListView bookListView;
    }
}

