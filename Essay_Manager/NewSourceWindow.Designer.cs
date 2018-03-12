namespace Essay_Manager
{
    partial class NewSourceWindow
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
            this.UrlField = new System.Windows.Forms.TextBox();
            this.addSourceButton = new System.Windows.Forms.Button();
            this.publisher = new System.Windows.Forms.MaskedTextBox();
            this.authorFirst = new System.Windows.Forms.TextBox();
            this.authorMiddle = new System.Windows.Forms.TextBox();
            this.authorLast = new System.Windows.Forms.TextBox();
            this.datePublishedDay = new System.Windows.Forms.TextBox();
            this.datePublishedMonth = new System.Windows.Forms.TextBox();
            this.datePublishedYear = new System.Windows.Forms.TextBox();
            this.articalTitle = new System.Windows.Forms.TextBox();
            this.authorNameLable = new System.Windows.Forms.Label();
            this.datePublishedLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UrlField
            // 
            this.UrlField.Location = new System.Drawing.Point(12, 64);
            this.UrlField.Name = "UrlField";
            this.UrlField.Size = new System.Drawing.Size(241, 20);
            this.UrlField.TabIndex = 0;
            this.UrlField.Text = "Please enter a URL";
            this.UrlField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addSourceButton
            // 
            this.addSourceButton.Location = new System.Drawing.Point(13, 226);
            this.addSourceButton.Name = "addSourceButton";
            this.addSourceButton.Size = new System.Drawing.Size(75, 23);
            this.addSourceButton.TabIndex = 1;
            this.addSourceButton.Text = "Add Source";
            this.addSourceButton.UseVisualStyleBackColor = true;
            this.addSourceButton.Click += new System.EventHandler(this.addSourceButton_Click);
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(12, 182);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(241, 20);
            this.publisher.TabIndex = 2;
            this.publisher.Text = "Publisher";
            // 
            // authorFirst
            // 
            this.authorFirst.Location = new System.Drawing.Point(13, 108);
            this.authorFirst.Name = "authorFirst";
            this.authorFirst.Size = new System.Drawing.Size(75, 20);
            this.authorFirst.TabIndex = 3;
            this.authorFirst.Text = "First";
            // 
            // authorMiddle
            // 
            this.authorMiddle.Location = new System.Drawing.Point(94, 108);
            this.authorMiddle.Name = "authorMiddle";
            this.authorMiddle.Size = new System.Drawing.Size(48, 20);
            this.authorMiddle.TabIndex = 4;
            this.authorMiddle.Text = "Middle";
            // 
            // authorLast
            // 
            this.authorLast.Location = new System.Drawing.Point(148, 108);
            this.authorLast.Name = "authorLast";
            this.authorLast.Size = new System.Drawing.Size(105, 20);
            this.authorLast.TabIndex = 5;
            this.authorLast.Text = "Last";
            // 
            // datePublishedDay
            // 
            this.datePublishedDay.Location = new System.Drawing.Point(12, 156);
            this.datePublishedDay.Name = "datePublishedDay";
            this.datePublishedDay.Size = new System.Drawing.Size(49, 20);
            this.datePublishedDay.TabIndex = 6;
            this.datePublishedDay.Text = "Day";
            // 
            // datePublishedMonth
            // 
            this.datePublishedMonth.Location = new System.Drawing.Point(68, 156);
            this.datePublishedMonth.Name = "datePublishedMonth";
            this.datePublishedMonth.Size = new System.Drawing.Size(74, 20);
            this.datePublishedMonth.TabIndex = 7;
            this.datePublishedMonth.Text = "Month";
            // 
            // datePublishedYear
            // 
            this.datePublishedYear.Location = new System.Drawing.Point(148, 156);
            this.datePublishedYear.Name = "datePublishedYear";
            this.datePublishedYear.Size = new System.Drawing.Size(105, 20);
            this.datePublishedYear.TabIndex = 8;
            this.datePublishedYear.Text = "Year";
            // 
            // articalTitle
            // 
            this.articalTitle.Location = new System.Drawing.Point(13, 38);
            this.articalTitle.Name = "articalTitle";
            this.articalTitle.Size = new System.Drawing.Size(241, 20);
            this.articalTitle.TabIndex = 9;
            this.articalTitle.Text = "Artical Title";
            // 
            // authorNameLable
            // 
            this.authorNameLable.AutoSize = true;
            this.authorNameLable.Location = new System.Drawing.Point(13, 89);
            this.authorNameLable.Name = "authorNameLable";
            this.authorNameLable.Size = new System.Drawing.Size(69, 13);
            this.authorNameLable.TabIndex = 10;
            this.authorNameLable.Text = "Author Name";
            this.authorNameLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // datePublishedLable
            // 
            this.datePublishedLable.AutoSize = true;
            this.datePublishedLable.Location = new System.Drawing.Point(12, 140);
            this.datePublishedLable.Name = "datePublishedLable";
            this.datePublishedLable.Size = new System.Drawing.Size(79, 13);
            this.datePublishedLable.TabIndex = 11;
            this.datePublishedLable.Text = "Date Published";
            // 
            // NewSourceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 261);
            this.Controls.Add(this.datePublishedLable);
            this.Controls.Add(this.authorNameLable);
            this.Controls.Add(this.articalTitle);
            this.Controls.Add(this.datePublishedYear);
            this.Controls.Add(this.datePublishedMonth);
            this.Controls.Add(this.datePublishedDay);
            this.Controls.Add(this.authorLast);
            this.Controls.Add(this.authorMiddle);
            this.Controls.Add(this.authorFirst);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.addSourceButton);
            this.Controls.Add(this.UrlField);
            this.Name = "NewSourceWindow";
            this.Text = "Add Source";
            this.Load += new System.EventHandler(this.NewSourceWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlField;
        private System.Windows.Forms.Button addSourceButton;
        private System.Windows.Forms.MaskedTextBox publisher;
        private System.Windows.Forms.TextBox authorFirst;
        private System.Windows.Forms.TextBox authorMiddle;
        private System.Windows.Forms.TextBox authorLast;
        private System.Windows.Forms.TextBox datePublishedDay;
        private System.Windows.Forms.TextBox datePublishedMonth;
        private System.Windows.Forms.TextBox datePublishedYear;
        private System.Windows.Forms.TextBox articalTitle;
        private System.Windows.Forms.Label authorNameLable;
        private System.Windows.Forms.Label datePublishedLable;
    }
}