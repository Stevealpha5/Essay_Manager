using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essay_Manager
{
    public class Source
    {
        string url;
        string title;
        string author;

        public Source(string url)
        {
            this.url = url;
        }

        public string getURL()
        {
            return url;
        }
    }
}
