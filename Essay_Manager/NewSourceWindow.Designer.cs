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
            this.SuspendLayout();
            // 
            // UrlField
            // 
            this.UrlField.Location = new System.Drawing.Point(13, 116);
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
            // NewSourceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.addSourceButton);
            this.Controls.Add(this.UrlField);
            this.Name = "NewSourceWindow";
            this.Text = "Add a Source";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlField;
        private System.Windows.Forms.Button addSourceButton;
    }
}