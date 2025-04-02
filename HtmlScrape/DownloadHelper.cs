using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlScrape
{
    public class DownloadHelper
    {
        public static async Task<List<MediaOutlets>> GetValuesFromHtml(string url)
        {
            HttpClient client = new HttpClient();
            string html = await client.GetStringAsync(url);

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            List<HtmlNode> nodes = new List<HtmlNode>();
            var node = doc.DocumentNode.SelectSingleNode("//img[@alt='nytimes']");
            
            nodes.Add(node);


            List<MediaOutlets> list = new List<MediaOutlets>();
            //foreach(var item in node)
            //{
            //    MediaOutlets m = new MediaOutlets();
            //    list.Add(m);
            //}
           
            return list;
        }

    }
    
}
