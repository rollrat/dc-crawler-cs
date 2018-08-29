/*************************************************************************

   Copyright (C) 2018. rollrat All Rights Reserved.

   Author: Jeong HyunJun

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dc_crawler_cs.DCInside
{
    public class Gallery
    {
        public static string GetGalleryUrl(string id, string page) => $"http://gall.dcinside.com/board/lists/?id={id}&page={page}";

        public const string gallery_article = @"notice"" >(\d+)<[\s\S]*?middle;"">(.*?)</a>\s*?</td>[\s\S]*?user_id='(.*?)' user_name=""(.*?)""[\s\S]*?date"" title=""([\s\S]*?)"">.*?<[\s\S]*?hits"">(\d+)<[\s\S]*?hits"">(\d+)<";
        public const string gallery_last_page = @"&page=(\d+)"" class=""b_next""><span class=""arrow_2"">맨뒤";

        public static int GetLastPageFromId(string id)
        {
            foreach (var match in Regex.Matches(Common.GetUrlTextAsync(id).Result, gallery_last_page).OfType<Match>())
                return Convert.ToInt32(match.Groups[1].Value);
            return 1;
        }

        public struct DCMapStructure
        {
            public string notice;
            public string title;
            public int comments;
            public string author;
            public DateTime dates;
            public int clicks;
            public int star;
            public int level;
            public string userid;
        }

        public static async Task<List<DCMapStructure>> GetGalleryArticles(string id, string page)
        {
            string html = await Common.GetUrlTextAsync(GetGalleryUrl(id, page));
            return ParseGalleryArticles(html);
        }

        public static List<DCMapStructure> ParseGalleryArticles(string html)
        {
            List<DCMapStructure> result = new List<DCMapStructure>();
            foreach (var match in Regex.Matches(html, gallery_article).OfType<Match>())
            {
                DCMapStructure map = new DCMapStructure();

                map.notice = match.Groups[1].Value;
                map.title = match.Groups[2].Value;
                map.userid = match.Groups[3].Value;
                map.author = match.Groups[4].Value;
                map.dates = DateTime.Parse(match.Groups[5].Value);
                map.clicks = Convert.ToInt32(match.Groups[6].Value);
                map.star = Convert.ToInt32(match.Groups[7].Value);

                if (match.Groups[0].Value.Contains(@"<img src='http://wstatic.dcinside.com/gallery/skin/gallog/g_default.gif"))
                    map.level = 1;
                else if (match.Groups[0].Value.Contains(@"<img src='http://wstatic.dcinside.com/gallery/skin/gallog/g_fix.gif"))
                    map.level = 2;

                if (map.title.Contains("</a>"))
                {
                    map.comments = Convert.ToInt32(map.title.Split(new string[] { "<em>[" }, StringSplitOptions.None)[1].Split(']')[0].Split('/')[0]);
                    map.title = map.title.Split(new string[] { "</a>" }, StringSplitOptions.None)[0];
                }

                if (match.Groups[0].Value.Contains(@"class=""user_ip"">("))
                {
                    map.userid = match.Groups[0].Value.Split(new[] { @"class=""user_ip"">(" }, StringSplitOptions.None)[1].Split(')')[0];
                    map.author += $"({map.userid})";
                }

                result.Add(map);
            }
            return result;
        }

    }
}
