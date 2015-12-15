using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stuff.Models
{
    public class EmailModel
    {
        public EmailModel ()
        {
            ListItems = new List<string>();
        }

        public string To { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string Header { get; set; }

        public string List { get; set; }

        public IList<string> ListItems { get; set; }
    }
}
