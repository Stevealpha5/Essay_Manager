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
    public partial class DeleteConformation : Form
    {
        Source deletedSources;
        ListBox listBox;

        public DeleteConformation(Source deletedSources, ListBox listBox)
        {
            InitializeComponent();
            this.deletedSources = deletedSources;
            this.listBox = listBox;
        }

        private void DeleteConformation_Load(object sender, EventArgs e)
        {
            deletedSourceLabel.Text = deletedSources.ToString();
            timer1.Start();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ThisAddIn.sources.Length; i++)
            {
                if (ThisAddIn.sources[i] == deletedSources)
                {
                    ThisAddIn.sources[i] = null;
                    removeNullSpaces(ThisAddIn.sources, i);
                    break;
                }  
            }

            Utils.updateSources();
            Utils.updateSources(listBox);

            this.Close();
        }

        private void removeNullSpaces(Source[] sources, int deletedIndex)
        {
            for (int i = deletedIndex; i < sources.Length; i++)
            {
                if (sources[i + 1] != null)
                {
                    sources[i] = sources[i + 1];
                }
                else
                {
                    sources[i] = null;
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
