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

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            UserControl = new SourceWindow();
            sourceTaskPane = this.CustomTaskPanes.Add(UserControl, "My Task Pane");
            sourceTaskPane.Width = 645;
           
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
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
