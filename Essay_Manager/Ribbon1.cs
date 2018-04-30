using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;


namespace Essay_Manager
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            ThisAddIn.sourceTaskPane.Visible = !ThisAddIn.sourceTaskPane.Visible;
        }

        private void addSourceButton_Click(object sender, RibbonControlEventArgs e)
        {
            NewSourceWindow window = new NewSourceWindow();
            window.Visible = true;
        }

        private void editSourceButton_Click(object sender, RibbonControlEventArgs e)
        {
            EditSourceStandAlone editSourceStandAlone = new EditSourceStandAlone();
            editSourceStandAlone.Visible = true;
        }

        private void removeSourceButton_Click(object sender, RibbonControlEventArgs e)
        {
            DeleteSourceStandAlone deleteSourceStandAlone = new DeleteSourceStandAlone();
            deleteSourceStandAlone.Visible = true;
        }

        private void loadBtton_Click(object sender, RibbonControlEventArgs e)
        {
            Utils.populatSourceListArray(XML.loadSourceArray(ThisAddIn.saveLocation));
            Utils.updateSources();
        }

        private void saveButton_Click(object sender, RibbonControlEventArgs e)
        {
            XML.saveData(ThisAddIn.sources, ThisAddIn.saveLocation);
        }
    }
}
