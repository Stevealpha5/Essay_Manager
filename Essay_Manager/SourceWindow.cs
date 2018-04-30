using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            Utils.updateSources();
        }
        
      
        private void SourceWindow_Resize(object sender, EventArgs e)
        {
            sourceWebBrowser.Width = this.Width;
     
        }

        public void populateSourceInfo(Source source)
        {
            sourceInfoPanel.Visible = true;
       
            authorNameLable.ForeColor = Color.Green;
            locationLable.ForeColor = Color.Green;
            articalTitleLable.ForeColor = Color.Green;
            datePublishedLable.ForeColor = Color.Green;
            publisherLable.ForeColor = Color.Green;

            authorNameLable.Text = Utils.cleanWhiteSpace(source.authorFirst + " " + source.authorMiddle + " " + source.authorLast);
            locationLable.Text = source.url;
            articalTitleLable.Text = source.title;
            datePublishedLable.Text = Utils.cleanWhiteSpace(source.day + " " + source.month + " " + source.year);
            publisherLable.Text = source.publisher;

            Utils.changeLableFrom(authorNameLable, "", "No data found", Color.Red);
            Utils.changeLableFrom(locationLable, "", "No data found", Color.Red);
            Utils.changeLableFrom(articalTitleLable, "", "No data found", Color.Red);
            Utils.changeLableFrom(datePublishedLable, "", "No data found", Color.Red);
            Utils.changeLableFrom(publisherLable, "", "No data found", Color.Red);
        }
        

        private void editSourceButton_Click(object sender, EventArgs e)
        {

            if (sourceListBox.SelectedItem == null)
            {
                MessageBox.Show("Error: Please select a source");
                return;
            }

            EditSourceWindow editSourceWindow = new EditSourceWindow((Source)sourceListBox.SelectedItem, sourceListBox);
            editSourceWindow.Visible = true;
        }

        private void sourceListBox_Click(object sender, EventArgs e)
        {
            if (sourceListBox.SelectedItem != null)
            {

                if (sourceListBox.SelectedItem.ToString().Length != 0)

                {
                    if (sourceListBox.SelectedItem != null)
                    {
                        Source source = (Source)sourceListBox.SelectedItem;
                        sourceWebBrowser.Navigate(source.url);
                        populateSourceInfo(source);
                    }
                }
            }
        }

        private void sourceWebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
        }

        private void sourceWebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void deleteSourceButton_Click(object sender, EventArgs e)
        {
            if (sourceListBox.SelectedItem == null)
            {
                MessageBox.Show("Error: Please select a source");
                return;
            }

            DeleteConformation confermation = new DeleteConformation((Source)sourceListBox.SelectedItem, sourceListBox);
            confermation.Visible = true;
            confermation.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
