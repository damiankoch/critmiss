using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArmyViewer.Web.Utilities
{
    public class Utilities
    {
        public static string ProcessYouTubeLink(string Url)
        {
            // if a link is in the wrong format, use this function to convert it
            /* should be in this format: https://www.youtube.com/embed/{id} */

            int eqPos = Url.IndexOf("=");
            string videoId = Url.Substring(eqPos + 1, Url.Length - eqPos - 1);
            string newUrl = $"https://www.youtube.com/embed/{videoId}";

            return newUrl;
        }
    }
}