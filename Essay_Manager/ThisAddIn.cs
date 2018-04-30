using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace Essay_Manager
{
    public partial class ThisAddIn
    {
        private SourceWindow UserControl;
        public static Microsoft.Office.Tools.CustomTaskPane sourceTaskPane;

        public static Source[] sources = new Source[250];
        public static string saveLocation = "test.xml";
        
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            UserControl = new SourceWindow();
            sourceTaskPane = this.CustomTaskPanes.Add(UserControl, "Source Window");
            sourceTaskPane.Width = 645;

            Utils.populatSourceListArray(XML.loadSourceArray(ThisAddIn.saveLocation));
            Utils.updateSources();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            XML.saveData(ThisAddIn.sources, ThisAddIn.saveLocation);
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
