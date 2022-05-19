using System;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler crawler = new Crawler();
            string starUrl = @"http://www.cnblogs.com/dstang2000/";
            crawler.urls.Add(starUrl, false);
            crawler.Crawl(starUrl);
        }
    }
}
