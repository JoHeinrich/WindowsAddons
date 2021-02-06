using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Windows.Forms;
using WindowsInput;

namespace VoiceControl
{
    public class SearchController : ICommandControllerDefinition
    {
        public void Build(ICommandBuilder builder)
        {
            builder.AddCommand("Google text(en-GB)", v => SearchOnGoogle(v))
                .AddCommand("Youtube text(en-GB)", v => SearchOnYoutube(v))
                .AddCommand("Windows text(en-GB)", v => SearchOnWindows(v));
        }
        public static void SearchOnWindows(string keyword)
        {
            InputSimulator inputSimulator = new InputSimulator();
            SendKeys.SendWait("^{ESC}"+keyword);
        }
        public static void SearchOnGoogle(string keyword)
        {
            var content = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "q", keyword}
            });

            var uri = new UriBuilder("http://www.google.com/search");
            uri.Query += content.ReadAsStringAsync().Result;
            var u = uri.ToString();
            Process.Start(uri.ToString());
        }
        public static string SearchOnYoutubeQuerry(string keyword)
        {
            var content = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "search_query", keyword}
            });

            var uri = new UriBuilder("https://www.youtube.com/results");
            uri.Port = -1;
            uri.Query += content.ReadAsStringAsync().Result;
            return uri.ToString();

        }
        public static void SearchOnYoutube(string keyword)
        {
            Process.Start(SearchOnYoutubeQuerry(keyword));
        }
    }
    public class AdvancedTextController : ICommandControllerDefinition
    {

        public void Build(ICommandBuilder builder)
        {
            builder.AddCommand("German text(de-de)", v => SendKeys.SendWait(v))
               .AddCommand("English text(en-us)", v => SendKeys.SendWait(v));

        }




    }
}
