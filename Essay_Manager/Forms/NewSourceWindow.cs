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


        private void addSourceButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ThisAddIn.sources.Length; i++)
            {
                if (ThisAddIn.sources[i] == null)
                {
                    ThisAddIn.sources[i] = new Source();

                    ThisAddIn.sources[i].url = UrlField.Text;
                    ThisAddIn.sources[i].title = articalTitle.Text;

                    ThisAddIn.sources[i].authorFirst = authorFirst.Text;
                    ThisAddIn.sources[i].authorLast = authorLast.Text;
                    ThisAddIn.sources[i].authorMiddle = authorMiddle.Text;

                    ThisAddIn.sources[i].day = datePublishedDay.Text;
                    ThisAddIn.sources[i].month = datePublishedMonth.Text;
                    ThisAddIn.sources[i].year = datePublishedYear.Text;

                    ThisAddIn.sources[i].publisher = publisher.Text;

                    if (ThisAddIn.sources[i].ToString() == null)
                        ThisAddIn.sources[i] = null;

                    break;
                }
            }

            Utils.updateSources();

            this.Close();
        }


        private void NewSourceWindow_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
