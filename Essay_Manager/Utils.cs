using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essay_Manager
{
    class Utils
    {
        public static string cleanWhiteSpace(string longString)
        {
            StringBuilder sb = new StringBuilder();
            bool lastWasSpace = true; // True to eliminate leading spaces

            for (int i = 0; i < longString.Length; i++)
            {
                if (Char.IsWhiteSpace(longString[i]) && lastWasSpace)
                {
                    continue;
                }

                lastWasSpace = Char.IsWhiteSpace(longString[i]);

                sb.Append(longString[i]);
            }



            return sb.ToString();
        }

        public static void updateSources()
        {
            SourceWindow.sourceListBox.Items.Clear();

            for (int i = 0; i < ThisAddIn.sources.Length; i++)
            {
                if (ThisAddIn.sources[i] != null)
                {
                    SourceWindow.sourceListBox.Items.Add(ThisAddIn.sources[i]);
                }
                else
                {
                    break;
                }
            }
        }

        public static void changeLableFrom(Label lable, String text1, String text2, Color color)
        {
            if (lable.Text == text1)
            {
                lable.Text = text2;
                lable.ForeColor = color;
            }
        }
    }
}
