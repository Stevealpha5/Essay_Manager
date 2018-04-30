namespace Essay_Manager
{
    partial class DeleteSourceStandAlone
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
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sourceInfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.articalTitleLable = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.locationLable = new System.Windows.Forms.Label();
            this.publisherLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.authorNameLable = new System.Windows.Forms.Label();
            this.datePublishedLable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editSourceListBox = new System.Windows.Forms.ListBox();
            this.deleteSourceButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sourceInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(99, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // sourceInfoPanel
            // 
            this.sourceInfoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sourceInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceInfoPanel.Controls.Add(this.label1);
            this.sourceInfoPanel.Controls.Add(this.articalTitleLable);
            this.sourceInfoPanel.Controls.Add(this.label9);
            this.sourceInfoPanel.Controls.Add(this.locationLable);
            this.sourceInfoPanel.Controls.Add(this.publisherLable);
            this.sourceInfoPanel.Controls.Add(this.label3);
            this.sourceInfoPanel.Controls.Add(this.label7);
            this.sourceInfoPanel.Controls.Add(this.authorNameLable);
            this.sourceInfoPanel.Controls.Add(this.datePublishedLable);
            this.sourceInfoPanel.Controls.Add(this.label5);
            this.sourceInfoPanel.Location = new System.Drawing.Point(180, 12);
            this.sourceInfoPanel.Name = "sourceInfoPanel";
            this.sourceInfoPanel.Size = new System.Drawing.Size(305, 173);
            this.sourceInfoPanel.TabIndex = 20;
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
            this.articalTitleLable.AutoSize = true;
            this.articalTitleLable.ForeColor = System.Drawing.Color.Red;
            this.articalTitleLable.Location = new System.Drawing.Point(25, 41);
            this.articalTitleLable.Name = "articalTitleLable";
            this.articalTitleLable.Size = new System.Drawing.Size(75, 13);
            this.articalTitleLable.TabIndex = 6;
            this.articalTitleLable.Text = "No data found";
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
            // locationLable
            // 
            this.locationLable.AutoSize = true;
            this.locationLable.ForeColor = System.Drawing.Color.Red;
            this.locationLable.Location = new System.Drawing.Point(26, 95);
            this.locationLable.Name = "locationLable";
            this.locationLable.Size = new System.Drawing.Size(75, 13);
            this.locationLable.TabIndex = 7;
            this.locationLable.Text = "No data found";
            // 
            // publisherLable
            // 
            this.publisherLable.AutoSize = true;
            this.publisherLable.ForeColor = System.Drawing.Color.Red;
            this.publisherLable.Location = new System.Drawing.Point(160, 95);
            this.publisherLable.Name = "publisherLable";
            this.publisherLable.Size = new System.Drawing.Size(75, 13);
            this.publisherLable.TabIndex = 13;
            this.publisherLable.Text = "No data found";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Published";
            // 
            // authorNameLable
            // 
            this.authorNameLable.AutoSize = true;
            this.authorNameLable.ForeColor = System.Drawing.Color.Red;
            this.authorNameLable.Location = new System.Drawing.Point(25, 139);
            this.authorNameLable.Name = "authorNameLable";
            this.authorNameLable.Size = new System.Drawing.Size(75, 13);
            this.authorNameLable.TabIndex = 9;
            this.authorNameLable.Text = "No data found";
            // 
            // datePublishedLable
            // 
            this.datePublishedLable.AutoSize = true;
            this.datePublishedLable.ForeColor = System.Drawing.Color.Red;
            this.datePublishedLable.Location = new System.Drawing.Point(160, 41);
            this.datePublishedLable.Name = "datePublishedLable";
            this.datePublishedLable.Size = new System.Drawing.Size(75, 13);
            this.datePublishedLable.TabIndex = 11;
            this.datePublishedLable.Text = "No data found";
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
            // editSourceListBox
            // 
            this.editSourceListBox.FormattingEnabled = true;
            this.editSourceListBox.Location = new System.Drawing.Point(10, 12);
            this.editSourceListBox.Name = "editSourceListBox";
            this.editSourceListBox.Size = new System.Drawing.Size(164, 173);
            this.editSourceListBox.TabIndex = 19;
            this.editSourceListBox.SelectedIndexChanged += new System.EventHandler(this.editSourceListBox_SelectedIndexChanged);
            this.editSourceListBox.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.editSourceListBox.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // deleteSourceButton
            // 
            this.deleteSourceButton.Location = new System.Drawing.Point(10, 226);
            this.deleteSourceButton.Name = "deleteSourceButton";
            this.deleteSourceButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSourceButton.TabIndex = 21;
            this.deleteSourceButton.Text = "Delete";
            this.deleteSourceButton.UseVisualStyleBackColor = true;
            this.deleteSourceButton.Click += new System.EventHandler(this.deleteSourceButton_Click);
            this.deleteSourceButton.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.deleteSourceButton.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DeleteSourceStandAlone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 261);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sourceInfoPanel);
            this.Controls.Add(this.editSourceListBox);
            this.Controls.Add(this.deleteSourceButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteSourceStandAlone";
            this.ShowIcon = false;
            this.Text = "Delete Source ";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.DeleteSourceStandAlone_Activated);
            this.Load += new System.EventHandler(this.DeleteSourceStandAlone_Load);
            this.sourceInfoPanel.ResumeLayout(false);
            this.sourceInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel sourceInfoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label articalTitleLable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label locationLable;
        private System.Windows.Forms.Label publisherLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label authorNameLable;
        private System.Windows.Forms.Label datePublishedLable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox editSourceListBox;
        private System.Windows.Forms.Button deleteSourceButton;
        private System.Windows.Forms.Timer timer1;
    }
}