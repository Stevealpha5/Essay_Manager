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
            this.addSourceButton = new System.Windows.Forms.Button();
            this.authorNameLable = new System.Windows.Forms.Label();
            this.datePublishedLable = new System.Windows.Forms.Label();
            this.articalTitle = new Essay_Manager.PlaceHolderTextBox();
            this.UrlField = new Essay_Manager.PlaceHolderTextBox();
            this.authorFirst = new Essay_Manager.PlaceHolderTextBox();
            this.authorMiddle = new Essay_Manager.PlaceHolderTextBox();
            this.authorLast = new Essay_Manager.PlaceHolderTextBox();
            this.datePublishedDay = new Essay_Manager.PlaceHolderTextBox();
            this.datePublishedMonth = new Essay_Manager.PlaceHolderTextBox();
            this.datePublishedYear = new Essay_Manager.PlaceHolderTextBox();
            this.publisher = new Essay_Manager.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // addSourceButton
            // 
            this.addSourceButton.Location = new System.Drawing.Point(13, 226);
            this.addSourceButton.Name = "addSourceButton";
            this.addSourceButton.Size = new System.Drawing.Size(75, 23);
            this.addSourceButton.TabIndex = 9;
            this.addSourceButton.Text = "Add Source";
            this.addSourceButton.UseVisualStyleBackColor = true;
            this.addSourceButton.Click += new System.EventHandler(this.addSourceButton_Click);
            // 
            // authorNameLable
            // 
            this.authorNameLable.AutoSize = true;
            this.authorNameLable.Location = new System.Drawing.Point(13, 89);
            this.authorNameLable.Name = "authorNameLable";
            this.authorNameLable.Size = new System.Drawing.Size(69, 13);
            this.authorNameLable.TabIndex = 10;
            this.authorNameLable.Text = "Author Name";
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
            // articalTitle
            // 
            this.articalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.articalTitle.ForeColor = System.Drawing.Color.Gray;
            this.articalTitle.Location = new System.Drawing.Point(12, 38);
            this.articalTitle.Name = "articalTitle";
            this.articalTitle.PlaceHolderText = "test";
            this.articalTitle.Size = new System.Drawing.Size(242, 20);
            this.articalTitle.TabIndex = 0;
            this.articalTitle.Text = "Artical Title";
            // 
            // UrlField
            // 
            this.UrlField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.UrlField.ForeColor = System.Drawing.Color.Gray;
            this.UrlField.Location = new System.Drawing.Point(13, 64);
            this.UrlField.Name = "UrlField";
            this.UrlField.PlaceHolderText = "Please Enter a URL";
            this.UrlField.Size = new System.Drawing.Size(241, 20);
            this.UrlField.TabIndex = 1;
            this.UrlField.Text = "Please Enter a URL";
            // 
            // authorFirst
            // 
            this.authorFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.authorFirst.ForeColor = System.Drawing.Color.Gray;
            this.authorFirst.Location = new System.Drawing.Point(12, 108);
            this.authorFirst.Name = "authorFirst";
            this.authorFirst.PlaceHolderText = "First";
            this.authorFirst.Size = new System.Drawing.Size(76, 20);
            this.authorFirst.TabIndex = 2;
            this.authorFirst.Text = "First";
            // 
            // authorMiddle
            // 
            this.authorMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.authorMiddle.ForeColor = System.Drawing.Color.Gray;
            this.authorMiddle.Location = new System.Drawing.Point(94, 108);
            this.authorMiddle.Name = "authorMiddle";
            this.authorMiddle.PlaceHolderText = "Middle";
            this.authorMiddle.Size = new System.Drawing.Size(48, 20);
            this.authorMiddle.TabIndex = 3;
            this.authorMiddle.Text = "Middle";
            // 
            // authorLast
            // 
            this.authorLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.authorLast.ForeColor = System.Drawing.Color.Gray;
            this.authorLast.Location = new System.Drawing.Point(148, 108);
            this.authorLast.Name = "authorLast";
            this.authorLast.PlaceHolderText = "Last";
            this.authorLast.Size = new System.Drawing.Size(106, 20);
            this.authorLast.TabIndex = 4;
            this.authorLast.Text = "Last";
            // 
            // datePublishedDay
            // 
            this.datePublishedDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.datePublishedDay.ForeColor = System.Drawing.Color.Gray;
            this.datePublishedDay.Location = new System.Drawing.Point(12, 156);
            this.datePublishedDay.Name = "datePublishedDay";
            this.datePublishedDay.PlaceHolderText = "Day";
            this.datePublishedDay.Size = new System.Drawing.Size(52, 20);
            this.datePublishedDay.TabIndex = 5;
            this.datePublishedDay.Text = "Day";
            // 
            // datePublishedMonth
            // 
            this.datePublishedMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.datePublishedMonth.ForeColor = System.Drawing.Color.Gray;
            this.datePublishedMonth.Location = new System.Drawing.Point(68, 156);
            this.datePublishedMonth.Name = "datePublishedMonth";
            this.datePublishedMonth.PlaceHolderText = "Month";
            this.datePublishedMonth.Size = new System.Drawing.Size(74, 20);
            this.datePublishedMonth.TabIndex = 6;
            this.datePublishedMonth.Text = "Month";
            // 
            // datePublishedYear
            // 
            this.datePublishedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.datePublishedYear.ForeColor = System.Drawing.Color.Gray;
            this.datePublishedYear.Location = new System.Drawing.Point(148, 156);
            this.datePublishedYear.Name = "datePublishedYear";
            this.datePublishedYear.PlaceHolderText = "Year";
            this.datePublishedYear.Size = new System.Drawing.Size(105, 20);
            this.datePublishedYear.TabIndex = 7;
            this.datePublishedYear.Text = "Year";
            // 
            // publisher
            // 
            this.publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.publisher.ForeColor = System.Drawing.Color.Gray;
            this.publisher.Location = new System.Drawing.Point(12, 200);
            this.publisher.Name = "publisher";
            this.publisher.PlaceHolderText = "Publisher";
            this.publisher.Size = new System.Drawing.Size(241, 20);
            this.publisher.TabIndex = 8;
            this.publisher.Text = "Publisher";
            // 
            // NewSourceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 261);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.datePublishedYear);
            this.Controls.Add(this.datePublishedMonth);
            this.Controls.Add(this.datePublishedDay);
            this.Controls.Add(this.authorLast);
            this.Controls.Add(this.authorMiddle);
            this.Controls.Add(this.authorFirst);
            this.Controls.Add(this.UrlField);
            this.Controls.Add(this.articalTitle);
            this.Controls.Add(this.datePublishedLable);
            this.Controls.Add(this.authorNameLable);
            this.Controls.Add(this.addSourceButton);
            this.Name = "NewSourceWindow";
            this.Text = "Add Source";
            this.Load += new System.EventHandler(this.NewSourceWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addSourceButton;
        private System.Windows.Forms.Label authorNameLable;
        private System.Windows.Forms.Label datePublishedLable;
        private PlaceHolderTextBox articalTitle;
        private PlaceHolderTextBox UrlField;
        private PlaceHolderTextBox authorFirst;
        private PlaceHolderTextBox authorMiddle;
        private PlaceHolderTextBox authorLast;
        private PlaceHolderTextBox datePublishedDay;
        private PlaceHolderTextBox datePublishedMonth;
        private PlaceHolderTextBox datePublishedYear;
        private PlaceHolderTextBox publisher;
    }
}