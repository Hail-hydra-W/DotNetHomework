using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace InternetWorm
{
    class SimpleCrawler
    {
        private readonly Hashtable urls = new Hashtable();
        private int count;
        private readonly string startUrl;

        public SimpleCrawler(string url)
        {
            startUrl = url;
            urls.Add(startUrl, false);
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)//找到一个还没有下载过的链接
                {
                    if ((bool)urls[url]) continue;//已经下载过的，不再下载
                    current = url;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                var task = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                var html = task.Result;
                Parse(html);//解析,并加入新的链接
            }
            Console.WriteLine("爬行结束");
        }

        public async Task<string> DownLoad(string url)
        {
            try
            {
                var webClient = new WebClient { Encoding = Encoding.UTF8 };
                var task = webClient.DownloadStringTaskAsync(url);
                string fileName = count.ToString();
                var result = await task;
                File.WriteAllText(fileName, result, Encoding.UTF8);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(jsp|html|aspx)[""']";
            var matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (!strRef.StartsWith(startUrl)) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler(@"https://www.runoob.com/");
            new Thread(myCrawler.Crawl).Start();
        }
    }
}