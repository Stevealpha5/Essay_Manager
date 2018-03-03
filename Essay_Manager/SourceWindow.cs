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
            string url = "www.google.com";

            for (int i = 0; i < ThisAddIn.sources.Length; i++)
            {
                if (ThisAddIn.sources[i] != null)
                {
                    url = ThisAddIn.sources[i].getURL();
                    break;
                }
            }

            sourceListBox.Items.Add(url);
            

            sourceWebBrowser.Navigate(sourceListBox.SelectedIndex.ToString());
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
    }
}
