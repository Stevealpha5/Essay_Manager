using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essay_Manager
{
    public class Source
    {
        public string url = "";
        public string title = "";

        public string authorFirst = "";
        public string authorMiddle = "";
        public string authorLast = "";

        public string day = "";
        public string month = "";
        public string year = "";

        public string publisher; 


        public Source()
        {
          
        }

        public override string ToString()
        {

            if (title != "")
                return title;

            if (url != "")
                return url;

            if (publisher != "")
                return publisher;

            if (authorFirst + authorMiddle + authorLast != "" + "" + "")
                return Utils.cleanWhiteSpace(authorLast + " " + authorFirst + " " + authorMiddle);

            if (day + month + year != "" + "" + "")
                return Utils.cleanWhiteSpace(day + " " + month + " " + year);

            return null;
        }


    }
}
