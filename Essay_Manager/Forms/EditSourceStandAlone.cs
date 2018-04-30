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
    public partial class EditSourceStandAlone : Form
    {
        bool isOnlyWindow = true;
        public EditSourceStandAlone()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void EditSourceStandAlone_Load(object sender, EventArgs e)
        {
            editSourceListBox.Items.Clear();

            for (int i = 0; i < ThisAddIn.sources.Length; i++)
            {
                if (ThisAddIn.sources[i] != null)
                {
                    editSourceListBox.Items.Add(ThisAddIn.sources[i]);
                }
                else
                {
                    break;
                }
            }
        }

        private void editSourceListBox_Click(object sender, EventArgs e)
        {
            if (editSourceListBox.SelectedItem != null)
            {

                if (editSourceListBox.SelectedItem.ToString().Length != 0)

                {
                    if (editSourceListBox.SelectedItem != null)
                    {
                        Source source = (Source)editSourceListBox.SelectedItem;
                        populateSourceInfo(source);
                    }
                }
            }
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
            isOnlyWindow = false;
            this.TopMost = false;

            if (editSourceListBox.SelectedItem == null)
            {
                MessageBox.Show("Error: Please select a source");
                return;
            }

            EditSourceWindow editSourceWindow = new EditSourceWindow((Source)editSourceListBox.SelectedItem, editSourceListBox);
            editSourceWindow.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isOnlyWindow)
                this.Focus();
        }

        private void EditSourceStandAlone_Activated(object sender, EventArgs e)
        {
            isOnlyWindow = true;
            this.TopMost = true;
        }
    }
}
