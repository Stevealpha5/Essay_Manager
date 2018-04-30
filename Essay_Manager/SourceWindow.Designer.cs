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
            this.components = new System.ComponentModel.Container();
            this.sourceWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            sourceListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SourceListLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.articalTitleLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationLable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.authorNameLable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datePublishedLable = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.publisherLable = new System.Windows.Forms.Label();
            this.sourceInfoPanel = new System.Windows.Forms.Panel();
            this.deleteSourceButton = new System.Windows.Forms.Button();
            this.editSourceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceWebBrowser
            // 
            this.sourceWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.sourceWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.sourceWebBrowser.Name = "sourceWebBrowser";
            this.sourceWebBrowser.Size = new System.Drawing.Size(640, 475);
            this.sourceWebBrowser.TabIndex = 0;
            this.sourceWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.sourceWebBrowser_DocumentCompleted);
            this.sourceWebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.sourceWebBrowser_Navigated);
            this.sourceWebBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.sourceWebBrowser_Navigating);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(6, 725);
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
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sourceListBox
            // 
            sourceListBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            sourceListBox.FormattingEnabled = true;
            sourceListBox.Location = new System.Drawing.Point(6, 506);
            sourceListBox.Name = "sourceListBox";
            sourceListBox.Size = new System.Drawing.Size(228, 173);
            sourceListBox.TabIndex = 2;
            sourceListBox.Click += new System.EventHandler(this.sourceListBox_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SourceListLable
            // 
            this.SourceListLable.AutoSize = true;
            this.SourceListLable.Location = new System.Drawing.Point(3, 490);
            this.SourceListLable.Name = "SourceListLable";
            this.SourceListLable.Size = new System.Drawing.Size(60, 13);
            this.SourceListLable.TabIndex = 4;
            this.SourceListLable.Text = "Source List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Artical Title";
            // 
            // articalTitleLable
            // 
            this.articalTitleLable.ForeColor = System.Drawing.Color.Red;
            this.articalTitleLable.Location = new System.Drawing.Point(25, 41);
            this.articalTitleLable.Name = "articalTitleLable";
            this.articalTitleLable.Size = new System.Drawing.Size(129, 13);
            this.articalTitleLable.TabIndex = 6;
            this.articalTitleLable.Text = "No data found";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Location";
            // 
            // locationLable
            // 
            this.locationLable.ForeColor = System.Drawing.Color.Red;
            this.locationLable.Location = new System.Drawing.Point(26, 95);
            this.locationLable.Name = "locationLable";
            this.locationLable.Size = new System.Drawing.Size(128, 13);
            this.locationLable.TabIndex = 7;
            this.locationLable.Text = "No data found";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Author";
            // 
            // authorNameLable
            // 
            this.authorNameLable.ForeColor = System.Drawing.Color.Red;
            this.authorNameLable.Location = new System.Drawing.Point(26, 139);
            this.authorNameLable.Name = "authorNameLable";
            this.authorNameLable.Size = new System.Drawing.Size(112, 13);
            this.authorNameLable.TabIndex = 9;
            this.authorNameLable.Text = "No data found";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Published";
            // 
            // datePublishedLable
            // 
            this.datePublishedLable.ForeColor = System.Drawing.Color.Red;
            this.datePublishedLable.Location = new System.Drawing.Point(160, 41);
            this.datePublishedLable.Name = "datePublishedLable";
            this.datePublishedLable.Size = new System.Drawing.Size(140, 13);
            this.datePublishedLable.TabIndex = 11;
            this.datePublishedLable.Text = "No data found";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Publisher";
            // 
            // publisherLable
            // 
            this.publisherLable.ForeColor = System.Drawing.Color.Red;
            this.publisherLable.Location = new System.Drawing.Point(160, 95);
            this.publisherLable.Name = "publisherLable";
            this.publisherLable.Size = new System.Drawing.Size(140, 13);
            this.publisherLable.TabIndex = 13;
            this.publisherLable.Text = "No data found";
            // 
            // sourceInfoPanel
            // 
            this.sourceInfoPanel.AutoScroll = true;
            this.sourceInfoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sourceInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceInfoPanel.Controls.Add(this.deleteSourceButton);
            this.sourceInfoPanel.Controls.Add(this.label1);
            this.sourceInfoPanel.Controls.Add(this.editSourceButton);
            this.sourceInfoPanel.Controls.Add(this.articalTitleLable);
            this.sourceInfoPanel.Controls.Add(this.label9);
            this.sourceInfoPanel.Controls.Add(this.locationLable);
            this.sourceInfoPanel.Controls.Add(this.publisherLable);
            this.sourceInfoPanel.Controls.Add(this.label3);
            this.sourceInfoPanel.Controls.Add(this.label7);
            this.sourceInfoPanel.Controls.Add(this.authorNameLable);
            this.sourceInfoPanel.Controls.Add(this.datePublishedLable);
            this.sourceInfoPanel.Controls.Add(this.label5);
            this.sourceInfoPanel.Location = new System.Drawing.Point(240, 506);
            this.sourceInfoPanel.Name = "sourceInfoPanel";
            this.sourceInfoPanel.Size = new System.Drawing.Size(305, 173);
            this.sourceInfoPanel.TabIndex = 15;
            // 
            // deleteSourceButton
            // 
            this.deleteSourceButton.Location = new System.Drawing.Point(225, 134);
            this.deleteSourceButton.Name = "deleteSourceButton";
            this.deleteSourceButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSourceButton.TabIndex = 18;
            this.deleteSourceButton.Text = "Delete";
            this.deleteSourceButton.UseVisualStyleBackColor = true;
            this.deleteSourceButton.Click += new System.EventHandler(this.deleteSourceButton_Click);
            // 
            // editSourceButton
            // 
            this.editSourceButton.Location = new System.Drawing.Point(144, 134);
            this.editSourceButton.Name = "editSourceButton";
            this.editSourceButton.Size = new System.Drawing.Size(75, 23);
            this.editSourceButton.TabIndex = 17;
            this.editSourceButton.Text = "Edit";
            this.editSourceButton.UseVisualStyleBackColor = true;
            this.editSourceButton.Click += new System.EventHandler(this.editSourceButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Source Information";
            // 
            // SourceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceInfoPanel);
            this.Controls.Add(this.SourceListLable);
            this.Controls.Add(sourceListBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.sourceWebBrowser);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "SourceWindow";
            this.Size = new System.Drawing.Size(643, 781);
            this.Resize += new System.EventHandler(this.SourceWindow_Resize);
            this.sourceInfoPanel.ResumeLayout(false);
            this.sourceInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser sourceWebBrowser;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label SourceListLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label articalTitleLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label locationLable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label authorNameLable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label datePublishedLable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label publisherLable;
        private System.Windows.Forms.Panel sourceInfoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteSourceButton;
        private System.Windows.Forms.Button editSourceButton;
        public static System.Windows.Forms.ListBox sourceListBox;
    }
}
