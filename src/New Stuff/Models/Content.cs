using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stuff.Models
{
    public static class EmailDefaults
    {
        public static string DefaultRecipient = "elindie@gmail.com";

        public static string DebugRecipient = "elindie@gmail.com";

        public static string DefaultTitle = "A Cup For One";
    }

    public static class EmailTemplates
    {
        public static string DefaultBodyTemplate = "<div class=\"font-family: sans-serif; color: #53bc93;\">{0} <br/> <hr/> <br/> {1}</div>";

        public static string DefaultHeaderTemplate = "<h1>{0}</h1>";

        public static string DefaultListTemplate = "<ul>{0}</ul>";

        public static string DefaultLineTemplate = "<li class=\"list-style: none;\">{0}: {1}</li>";
    }

}
