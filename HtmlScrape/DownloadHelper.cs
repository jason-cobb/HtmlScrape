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

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);
          

            List<MediaOutlets> list = new List<MediaOutlets>();
            var logosDiv = document.DocumentNode.SelectSingleNode("//div[contains(@class, 'kl-logos')]");
            if (logosDiv != null)
            {
                var items = logosDiv.SelectNodes(".//div[contains(@class, 'kl-logos__item')]");
                Dictionary<string, string> logoValues = new Dictionary<string, string>();

                foreach (var item in items)
                {
                    var imgNode = item.SelectSingleNode(".//img[@alt]");
                    if (imgNode != null)
                    {
                        string altValue = imgNode.GetAttributeValue("alt", "");
                        logoValues[altValue] = item.GetAttributeValue("class", "kl-logos__item");
                    }
                }

                foreach (var entry in logoValues)
                {
                    Console.WriteLine($"Logo Name: {entry.Key}, Class Title: {entry.Value}");
                }
            }
            return list;
        }

    }
    
}
