using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubityHub.src
{
    class BubityApp
    {
        public string displayName;
        public string author;
        public string downloadLink;
        public string imageLink;
        public bool isDLC;
        public string gameDLC;

        public BubityApp(string displayName, string author, string downloadLink, string imageLink, bool isDLC, string gameDLC)
        {
            this.displayName = displayName;
            this.author = author;
            this.downloadLink = downloadLink;
            this.imageLink = imageLink;
            this.isDLC = isDLC;
            this.gameDLC = gameDLC;
        }
    }
}
