using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essay_Manager
{
    public partial class SourceWindow : UserControl
    {
        public SourceWindow()
        {
            InitializeComponent();
        }

        private void sourceWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (sourceListBox.SelectedItem != null)
            {
                int indexNumber = -1; 
                for (int i = 0; i < ThisAddIn.sources.Length; i++)
                {
                    if (sourceListBox.SelectedItem.ToString().Equals(ThisAddIn.sources[i].getDisplayName()))
                    {
                        indexNumber = i;
                        break;
                    }
                }

                if(indexNumber != -1)
                    sourceWebBrowser.Navigate(ThisAddIn.sources[indexNumber].url);
            }
        }

        private void SourceWindow_Load(object sender, EventArgs e)
        {

        }

        private void sourceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = sourceListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SourceWindow_Load_1(object sender, EventArgs e)
        {

        }
    }
}
