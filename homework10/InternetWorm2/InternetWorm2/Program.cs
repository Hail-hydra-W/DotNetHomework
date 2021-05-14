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
using System.Collections.Concurrent;

namespace InternetWorm
{
    class SimpleCrawler
    {
        private readonly ConcurrentQueue<string> downloadqueue = new ConcurrentQueue<string>();
        private readonly BlockingCollection<string> downloadedUrls = new BlockingCollection<string>();
        private int count;
        private readonly string startUrl;

        public SimpleCrawler(string url)
        {
            startUrl = url;
            downloadqueue.Enqueue(startUrl);
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                downloadqueue.TryDequeue(out var current);
                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                var task = DownLoad(current); // 下载
                count++;
                var html = task.Result;
                downloadedUrls.Add(current);
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
                var fileName = count.ToString();
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
                if (!downloadedUrls.Contains(strRef)) downloadqueue.Enqueue(strRef); ;
            }
        }

        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler(@"https://www.cnblogs.com/");
            new Thread(myCrawler.Crawl).Start();
        }
    }
}