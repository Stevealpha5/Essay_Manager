namespace Essay_Manager
{
    partial class DeleteConformation
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
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletedSourceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(45, 135);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(75, 22);
            this.yes.TabIndex = 0;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            this.yes.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.yes.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(149, 135);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(75, 22);
            this.no.TabIndex = 1;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            this.no.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.no.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(90, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Warning:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deletedSourceLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.yes);
            this.panel1.Controls.Add(this.no);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 168);
            this.panel1.TabIndex = 4;
            // 
            // deletedSourceLabel
            // 
            this.deletedSourceLabel.AutoSize = true;
            this.deletedSourceLabel.Location = new System.Drawing.Point(123, 79);
            this.deletedSourceLabel.Name = "deletedSourceLabel";
            this.deletedSourceLabel.Size = new System.Drawing.Size(35, 13);
            this.deletedSourceLabel.TabIndex = 5;
            this.deletedSourceLabel.Text = "label4";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "This action cannot be undone, are you sure you want to delete the fallowing sourc" +
    "e(s)?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DeleteConformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 168);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteConformation";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Conformation";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DeleteConformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label deletedSourceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}