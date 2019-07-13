using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BubityHub.src
{
    class BubityAppLoader
    {
        private static List<BubityApp> bubityApps = new List<BubityApp>();
        public static void LoadBubityApps()
        {
            WebClient wclient = new WebClient();
            String jsonString = wclient.DownloadString("http://www.programistazpolski.ct8.pl/apps.json");
            JObject json = JObject.Parse(jsonString);
            foreach(JToken tokens in json["apps"])
            {
                JToken token = tokens.First();
                bubityApps.Add(new BubityApp(token.SelectToken("displayName") + "", 
                    token.SelectToken("author") + "",
                    token.SelectToken("downloadLink") + "",
                    token.SelectToken("imageLink") + "", 
                    (token.SelectToken("isDLC").ToString().Equals("true")) ? true : false,
                    (token.SelectToken("gameDLC") == null) ? null : token.SelectToken("gameDLC").ToString()));
            }
        }
        public static List<BubityApp> GetBubityApps()
        {
            return bubityApps;
        }

    }
}
