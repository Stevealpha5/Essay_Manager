using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Essay_Manager
{
    public class XML
    {
        public static void saveData(Object intput, string fileName)
        {
            File.Delete(fileName);

            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = Cursors.Default;

            XmlSerializer sr = new XmlSerializer(intput.GetType());
            TextWriter writer = new StreamWriter(File.Create(fileName));
            sr.Serialize(writer, intput);
            writer.Flush();

            writer.Close();
            
        }

        public static Source[] loadSourceArray(string fileName)
        {
            if (File.Exists(fileName))
            {
                XmlSerializer sr = new XmlSerializer(typeof(Source[]));
                FileStream read = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);              
                Source[] output = (Source[])sr.Deserialize(read);

                read.Close();
                return output;



            }
            return null;
         
        }
    }
}
