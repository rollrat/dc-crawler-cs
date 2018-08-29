/*************************************************************************

   Copyright (C) 2018. rollrat All Rights Reserved.

   Author: Jeong HyunJun

***************************************************************************/

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dc_crawler_cs.DCInside
{
    public class GalleryList
    {
        public const string gallery_list1 = @"onmouseover=""gallery_view\('(\w+)'\);""\>[\s\S]*?\<.*?\>([\w\s]+)\<";
        public const string gallery_list2 = @"onmouseover\=""gallery_view\('(\w+)'\);""\>\s*([\w\s]+)\<";
        public const string gallery_list_url = "http://wstatic.dcinside.com/gallery/gallindex_iframe_new_gallery.html";

        public struct DCGallery
        {
            public string identification;
            public string name;
        }
        
        public static async Task<SortedDictionary<string, DCGallery>> GetGalleryListAsync()
        {
            SortedDictionary<string, DCGallery> dic = new SortedDictionary<string, DCGallery>();
            string src = await Common.GetUrlTextAsync(gallery_list_url);

            var parse = new List<Match>();
            parse.AddRange(Regex.Matches(src, gallery_list1).Cast<Match>().ToList());
            parse.AddRange(Regex.Matches(src, gallery_list2).Cast<Match>().ToList());
            foreach (var match in parse)
            {
                DCGallery dcg = new DCGallery();
                dcg.identification = match.Groups[1].Value;
                dcg.name = match.Groups[2].Value.Trim();

                if (!string.IsNullOrEmpty(dcg.name))
                {
                    if (dcg.name[0] == '-')
                        dcg.name = dcg.name.Remove(0, 1).Trim();
                    if (!dic.ContainsKey(dcg.name))
                        dic.Add(dcg.name, dcg);
                }
            }

            return dic;
        }

    }
}
