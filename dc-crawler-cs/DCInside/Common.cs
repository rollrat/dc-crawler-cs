/*************************************************************************

   Copyright (C) 2018. rollrat All Rights Reserved.

   Author: Jeong HyunJun

***************************************************************************/

using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dc_crawler_cs.DCInside
{
    public class Common
    {
        public static async Task<string> GetUrlTextAsync(string url)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            wc.Headers.Add(HttpRequestHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
            wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36");
            return await wc.DownloadStringTaskAsync(url);
        }

        public static string ReplaceEntity(string str)
        {
            string strs = str;
            string[] oj = {"&nbsp;", "&amp;", "&quot;", "&lt;",
                "&gt;", "&reg;", "&copy;", "&bull;", "&trade;", "&#39;" };
            string[] kj = { " ", "&", "\"", "<", ">", "Â®", "Â©", "â€¢", "â„¢", "'" };
            for (int i = 0; i <= oj.Length - 1; i++)
            {
                strs = strs.Replace(oj[i], kj[i]);
            }
            return strs;
        }
    }
}
