using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Crawler
{
    class Crawler
    {
        public Hashtable urls = new Hashtable();
        public int count = 0;

        //下载网页，返回网页内容
        public string getHtml(string url)
        {

            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string fileName = count.ToString();
            File.WriteAllText("/" + count + ".txt", html, Encoding.UTF8);
            return html;
        }

        public void Parse(string html, string URL)
        {
            Console.WriteLine("开始解析网页");
            string strRef = @"(href|HREF)=[""'].*[""']";
            //提取URL
            MatchCollection matches = new Regex(strRef).Matches(html);
            Console.WriteLine(matches.Count);
            foreach (Match match in matches)
            {
                //拿出网页地址
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\\', '#', ' ', '>');
                if (strRef.Length == 0) continue;
                //只有当爬取的是html/html/aspx/jsp等网页时，才解析并爬取下一级URL
                //if (!Regex.IsMatch(strRef, @"[html|aspx|jsp]$")) { continue; }
                if (!strRef.EndsWith("html")) continue;
                //相对地址(test/page.html, ./test/page.html, ../test2/page2.html, /test3/page.html)转成完整地址进行爬取
                string[] strs = URL.Split('/');
                int length = strs.Length;
                string currentdic = "";
                //currentdic表示当前目录
                for (int i = 0; i < length - 1; i++)
                {
                    currentdic += strs[i];
                    currentdic += @"/";
                }
                if (strRef.StartsWith(@"./"))
                {
                    string newurl = "";
                    newurl = currentdic + strRef.Substring(strRef.IndexOf('.') + 2);
                    if (urls[newurl] == null) urls[newurl] = false;
                }
                else if (strRef.StartsWith(@"../"))
                {
                    currentdic = "";
                    string newurl = "";
                    for (int i = 0; i < length - 2; i++)
                    {
                        currentdic += strs[i];
                        currentdic += @"/";
                    }
                    newurl = currentdic + strRef.Substring(strRef.IndexOf('.') + 3);
                    if (urls[newurl] == null) urls[newurl] = false;
                }
                else if (strRef.StartsWith(@"/"))
                {
                    currentdic = "";
                    for (int i = 0; i < 3; i++)
                    {
                        currentdic += strs[i];
                        currentdic += @"/";
                    }
                    string newurl = "";
                    newurl = currentdic + strRef.Substring(strRef.IndexOf('/') + 1);
                    if (urls[newurl] == null) urls[newurl] = false;
                }
                else if (!strRef.StartsWith("http"))
                {
                    string newurl = "";
                    newurl = currentdic + strRef;
                    if (urls[newurl] == null) urls[newurl] = false;
                }
                else
                {
                    if (urls[strRef] == null) urls[strRef] = false;
                }
            }
        }
        public void Crawl(string url1)
        {
            Console.WriteLine("开始爬...");
            //从url1获取home目录
            string home = url1.Substring(url1.IndexOf('/') + 2);
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count > 10) break;
                //不包含home则检查下一个网址
                if (!current.Contains(home)) continue;
                Console.WriteLine("爬取" + current + "页面!");
                string html = getHtml(current);
                urls[current] = true;
                count++;
                Parse(html, current);
            }
            Console.WriteLine("爬结束");
        }

    }
}
