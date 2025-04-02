using System.Net.Http;
using HtmlAgilityPack;
using HtmlScrape;

public class Program
{
    public static async Task Main(string[] args)
    {

        List<MediaOutlets> list = new List<MediaOutlets>();
        string url = "https://about.burbio.com/about-us";
        List<MediaOutlets> outletslist = await DownloadHelper.GetValuesFromHtml(url);


    }

}

