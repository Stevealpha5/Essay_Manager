namespace Essay_Manager
{
    partial class EditSourceWindow
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
            this.datePublishedLable = new System.Windows.Forms.Label();
            this.authorNameLable = new System.Windows.Forms.Label();
            this.addSourceButton = new System.Windows.Forms.Button();
            this.publisher = new Essay_Manager.PlaceHolderTextBox();
            this.datePublishedYear = new Essay_Manager.PlaceHolderTextBox();
            this.datePublishedMonth = new Essay_Manager.PlaceHolderTextBox();
            this.datePublishedDay = new Essay_Manager.PlaceHolderTextBox();
            this.authorLast = new Essay_Manager.PlaceHolderTextBox();
            this.authorMiddle = new Essay_Manager.PlaceHolderTextBox();
            this.authorFirst = new Essay_Manager.PlaceHolderTextBox();
            this.UrlField = new Essay_Manager.PlaceHolderTextBox();
            this.articalTitle = new Essay_Manager.PlaceHolderTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // datePublishedLable
            // 
            this.datePublishedLable.AutoSize = true;
            this.datePublishedLable.Location = new System.Drawing.Point(21, 127);
            this.datePublishedLable.Name = "datePublishedLable";
            this.datePublishedLable.Size = new System.Drawing.Size(79, 13);
            this.datePublishedLable.TabIndex = 23;
            this.datePublishedLable.Text = "Date Published";
            // 
            // authorNameLable
            // 
            this.authorNameLable.AutoSize = true;
            this.authorNameLable.Location = new System.Drawing.Point(22, 76);
            this.authorNameLable.Name = "authorNameLable";
            this.authorNameLable.Size = new System.Drawing.Size(69, 13);
            this.authorNameLable.TabIndex = 22;
            this.authorNameLable.Text = "Author Name";
            // 
            // addSourceButton
            // 
            this.addSourceButton.Location = new System.Drawing.Point(22, 213);
            this.addSourceButton.Name = "addSourceButton";
            this.addSourceButton.Size = new System.Drawing.Size(241, 23);
            this.addSourceButton.TabIndex = 10;
            this.addSourceButton.Text = "Update Source";
            this.addSourceButton.UseVisualStyleBackColor = true;
            this.addSourceButton.Click += new System.EventHandler(this.addSourceButton_Click);
            this.addSourceButton.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.addSourceButton.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // publisher
            // 
            this.publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.publisher.ForeColor = System.Drawing.Color.Gray;
            this.publisher.Location = new System.Drawing.Point(21, 187);
            this.publisher.Name = "publisher";
            this.publisher.PlaceHolderText = "Publisher";
            this.publisher.Size = new System.Drawing.Size(241, 20);
            this.publisher.TabIndex = 9;
            this.publisher.Text = "Publisher";
            // 
            // datePublishedYear
            // 
            this.datePublishedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.datePublishedYear.ForeColor = System.Drawing.Color.Gray;
            this.datePublishedYear.Location = new System.Drawing.Point(157, 143);
            this.datePublishedYear.Name = "datePublishedYear";
            this.datePublishedYear.PlaceHolderText = "Year";
            this.datePublishedYear.Size = new System.Drawing.Size(105, 20);
            this.datePublishedYear.TabIndex = 8;
            this.datePublishedYear.Text = "Year";
            // 
            // datePublishedMonth
            // 
            this.datePublishedMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.datePublishedMonth.ForeColor = System.Drawing.Color.Gray;
            this.datePublishedMonth.Location = new System.Drawing.Point(77, 143);
            this.datePublishedMonth.Name = "datePublishedMonth";
            this.datePublishedMonth.PlaceHolderText = "Month";
            this.datePublishedMonth.Size = new System.Drawing.Size(74, 20);
            this.datePublishedMonth.TabIndex = 7;
            this.datePublishedMonth.Text = "Month";
            // 
            // datePublishedDay
            // 
            this.datePublishedDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.datePublishedDay.ForeColor = System.Drawing.Color.Gray;
            this.datePublishedDay.Location = new System.Drawing.Point(21, 143);
            this.datePublishedDay.Name = "datePublishedDay";
            this.datePublishedDay.PlaceHolderText = "Day";
            this.datePublishedDay.Size = new System.Drawing.Size(52, 20);
            this.datePublishedDay.TabIndex = 6;
            this.datePublishedDay.Text = "Day";
            // 
            // authorLast
            // 
            this.authorLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.authorLast.ForeColor = System.Drawing.Color.Gray;
            this.authorLast.Location = new System.Drawing.Point(157, 95);
            this.authorLast.Name = "authorLast";
            this.authorLast.PlaceHolderText = "Last";
            this.authorLast.Size = new System.Drawing.Size(106, 20);
            this.authorLast.TabIndex = 5;
            this.authorLast.Text = "Last";
            // 
            // authorMiddle
            // 
            this.authorMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.authorMiddle.ForeColor = System.Drawing.Color.Gray;
            this.authorMiddle.Location = new System.Drawing.Point(103, 95);
            this.authorMiddle.Name = "authorMiddle";
            this.authorMiddle.PlaceHolderText = "Middle";
            this.authorMiddle.Size = new System.Drawing.Size(48, 20);
            this.authorMiddle.TabIndex = 4;
            this.authorMiddle.Text = "Middle";
            // 
            // authorFirst
            // 
            this.authorFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.authorFirst.ForeColor = System.Drawing.Color.Gray;
            this.authorFirst.Location = new System.Drawing.Point(21, 95);
            this.authorFirst.Name = "authorFirst";
            this.authorFirst.PlaceHolderText = "First";
            this.authorFirst.Size = new System.Drawing.Size(76, 20);
            this.authorFirst.TabIndex = 3;
            this.authorFirst.Text = "First";
            // 
            // UrlField
            // 
            this.UrlField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.UrlField.ForeColor = System.Drawing.Color.Gray;
            this.UrlField.Location = new System.Drawing.Point(22, 51);
            this.UrlField.Name = "UrlField";
            this.UrlField.PlaceHolderText = "Please Enter a URL";
            this.UrlField.Size = new System.Drawing.Size(241, 20);
            this.UrlField.TabIndex = 2;
            this.UrlField.Text = "Please Enter a URL";
            // 
            // articalTitle
            // 
            this.articalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.articalTitle.ForeColor = System.Drawing.Color.Gray;
            this.articalTitle.Location = new System.Drawing.Point(21, 25);
            this.articalTitle.Name = "articalTitle";
            this.articalTitle.PlaceHolderText = "Artical Title";
            this.articalTitle.Size = new System.Drawing.Size(242, 20);
            this.articalTitle.TabIndex = 1;
            this.articalTitle.Text = "Artical Title";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EditSourceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSourceWindow";
            this.ShowIcon = false;
            this.Text = "Edit Source";
            this.Load += new System.EventHandler(this.EditSourceWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceHolderTextBox publisher;
        private PlaceHolderTextBox datePublishedYear;
        private PlaceHolderTextBox datePublishedMonth;
        private PlaceHolderTextBox datePublishedDay;
        private PlaceHolderTextBox authorLast;
        private PlaceHolderTextBox authorMiddle;
        private PlaceHolderTextBox authorFirst;
        private PlaceHolderTextBox UrlField;
        private PlaceHolderTextBox articalTitle;
        private System.Windows.Forms.Label datePublishedLable;
        private System.Windows.Forms.Label authorNameLable;
        private System.Windows.Forms.Button addSourceButton;
        private System.Windows.Forms.Timer timer1;
    }
}