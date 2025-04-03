using System;
using MediaOutlets.cs;

Console.WriteLine("Hello, World!");

// Add more code here...
List<MediaOutlets> list = new List<MediaOutlets>();
string url = "https://about.burbio.com/about-us";
List<MediaOutlets> outletslist = await DownloadHelper.GetValuesFromHtml(url);




