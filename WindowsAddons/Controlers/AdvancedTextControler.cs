using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Windows.Forms;

namespace VoiceControl
{
    public class AdvancedTextController : ICommandControllerDefinition
    {

        public void Build(ICommandBuilder builder)
        {
            builder.AddCommand("German text(de-de)", v => SendKeys.SendWait(v))
               .AddCommand("English text(en-us)", v => SendKeys.SendWait(v))
               .AddCommand("Find text(en-us)", v => SearchOnGoogle(v));
        }

        public void SearchOnGoogle(string keywordString)
        {
            var content = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "q", keywordString}
            });

            var uri = new UriBuilder("http://www.google.com/search");
            uri.Query += content.ReadAsStringAsync().Result;
            var u = uri.ToString();
            Process.Start(uri.ToString());
        }
       
 
    }
}
