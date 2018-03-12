using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essay_Manager
{
    public partial class NewSourceWindow : Form
    { 

        public NewSourceWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addSourceButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ThisAddIn.sources.Length; i++)
            {
                if (ThisAddIn.sources[i] == null)
                {
                    ThisAddIn.sources[i] = new Source(UrlField.Text);
                    break;
                }
            }

            SourceWindow.sourceListBox.Items.Clear();

            for (int i = 0; i < ThisAddIn.sources.Length; i++)
            {
                if (ThisAddIn.sources[i] != null)
                {
                    SourceWindow.sourceListBox.Items.Add(ThisAddIn.sources[i].getURL());
                }
                else
                {
                    break;
                }
            }

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewSourceWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
