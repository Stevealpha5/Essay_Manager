namespace Essay_Manager
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.opneSourcesWindowButton = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.addSourceButton = this.Factory.CreateRibbonButton();
            this.editSourceButton = this.Factory.CreateRibbonButton();
            this.removeSourceButton = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.loadButton = this.Factory.CreateRibbonButton();
            this.saveButton = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "Essay Manager ";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.opneSourcesWindowButton);
            this.group1.Label = "Sources Window";
            this.group1.Name = "group1";
            // 
            // opneSourcesWindowButton
            // 
            this.opneSourcesWindowButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.opneSourcesWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("opneSourcesWindowButton.Image")));
            this.opneSourcesWindowButton.Label = "Open Sources Window";
            this.opneSourcesWindowButton.Name = "opneSourcesWindowButton";
            this.opneSourcesWindowButton.ShowImage = true;
            this.opneSourcesWindowButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.addSourceButton);
            this.group2.Items.Add(this.editSourceButton);
            this.group2.Items.Add(this.removeSourceButton);
            this.group2.Label = "Source Managment";
            this.group2.Name = "group2";
            // 
            // addSourceButton
            // 
            this.addSourceButton.Image = ((System.Drawing.Image)(resources.GetObject("addSourceButton.Image")));
            this.addSourceButton.Label = "Add Source";
            this.addSourceButton.Name = "addSourceButton";
            this.addSourceButton.ShowImage = true;
            this.addSourceButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.addSourceButton_Click);
            // 
            // editSourceButton
            // 
            this.editSourceButton.Image = ((System.Drawing.Image)(resources.GetObject("editSourceButton.Image")));
            this.editSourceButton.Label = "Edit Source";
            this.editSourceButton.Name = "editSourceButton";
            this.editSourceButton.ShowImage = true;
            this.editSourceButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editSourceButton_Click);
            // 
            // removeSourceButton
            // 
            this.removeSourceButton.Image = ((System.Drawing.Image)(resources.GetObject("removeSourceButton.Image")));
            this.removeSourceButton.Label = "Remove Sources";
            this.removeSourceButton.Name = "removeSourceButton";
            this.removeSourceButton.ShowImage = true;
            this.removeSourceButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.removeSourceButton_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.loadButton);
            this.group3.Items.Add(this.saveButton);
            this.group3.Items.Add(this.button4);
            this.group3.Label = "Options";
            this.group3.Name = "group3";
            // 
            // loadButton
            // 
            this.loadButton.Image = ((System.Drawing.Image)(resources.GetObject("loadButton.Image")));
            this.loadButton.Label = "Load Sources";
            this.loadButton.Name = "loadButton";
            this.loadButton.ScreenTip = "Force loads sources from the disk";
            this.loadButton.ShowImage = true;
            this.loadButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.loadBtton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Label = "Save Sources";
            this.saveButton.Name = "saveButton";
            this.saveButton.ScreenTip = "Forces saves sources to disk";
            this.saveButton.ShowImage = true;
            this.saveButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.saveButton_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Label = "Advanced Options";
            this.button4.Name = "button4";
            this.button4.ShowImage = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton opneSourcesWindowButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton addSourceButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton removeSourceButton;
        private System.Windows.Forms.PrintDialog printDialog1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton editSourceButton;
        private System.Windows.Forms.ImageList imageList1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton loadButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton saveButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
