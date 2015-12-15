using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using New_Stuff.Models;

namespace New_Stuff
{
    public static class EmailBuilder
    {
        public static string Content { get; private set; }

        public static EmailModel Construct(string recipient, string header, IEnumerable<Tuple<string, string>> lineItems)
        {
            EmailModel model = new EmailModel();

            model.To = recipient;

            BuildLines(lineItems, ref model);
            BuildList(ref model);
            BuildHeader(header, ref model);
            BuildBody(ref model);

            return model;
        }

        public static void BuildBody(ref EmailModel model)
        {
            model.Body = string.Format(EmailTemplates.DefaultBodyTemplate, model.Header, model.List);
        }
        
        public static void BuildHeader(string header, ref EmailModel model)
        {
            if(string.IsNullOrEmpty(header))
            {
                return;
            }

            model.Header = string.Format(EmailTemplates.DefaultHeaderTemplate, header);
        }

        public static void BuildList(ref EmailModel model)
        {
            if (!model.ListItems.Any())
            {
                return;
            }

            string combinedLines = string.Join("", model.ListItems);

            model.List = string.Format(EmailTemplates.DefaultListTemplate, combinedLines);
        }

        public static void BuildLines(IEnumerable<Tuple<string,string>> vals, ref EmailModel model)
        {
            if(!vals.Any())
            {
                return;
            }

            foreach(Tuple<string, string> val in vals)
            {
                model.ListItems.Add(string.Format(EmailTemplates.DefaultLineTemplate, val.Item1, val.Item2));
            }
        }
    }
}
