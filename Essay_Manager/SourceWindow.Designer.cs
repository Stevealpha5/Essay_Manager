namespace Essay_Manager
{
    partial class SourceWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sourceListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sourceWebBrowser
            // 
            this.sourceWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.sourceWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.sourceWebBrowser.Name = "sourceWebBrowser";
            this.sourceWebBrowser.Size = new System.Drawing.Size(633, 359);
            this.sourceWebBrowser.TabIndex = 0;
            this.sourceWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.sourceWebBrowser_DocumentCompleted);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(3, 491);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Engage";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sourceListBox
            // 
            this.sourceListBox.FormattingEnabled = true;
            this.sourceListBox.Location = new System.Drawing.Point(3, 366);
            this.sourceListBox.Name = "sourceListBox";
            this.sourceListBox.Size = new System.Drawing.Size(627, 121);
            this.sourceListBox.TabIndex = 2;
            this.sourceListBox.SelectedIndexChanged += new System.EventHandler(this.sourceListBox_SelectedIndexChanged);
            // 
            // SourceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sourceListBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.sourceWebBrowser);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SourceWindow";
            this.Size = new System.Drawing.Size(633, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser sourceWebBrowser;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox sourceListBox;
    }
}
