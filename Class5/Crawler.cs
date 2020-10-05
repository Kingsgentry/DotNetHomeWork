using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Class5
{

    public class Crawler
    {


        public Action<string> CrawlinglEvent;

        private Hashtable urls = new Hashtable();
        private int count = 0;
        private string startUrl = "";

        private List<URL> validUrlList = new List<URL>();
        public List<URL> ValidUrlList { get { return validUrlList; } }

        private List<URL> invalidUrlList = new List<URL>();
        public List<URL> InvallidUrList { get { return invalidUrlList; } }

        public Crawler(string input)
        {
            if (input != null)
                startUrl = input;
            else
                startUrl = "https://www.cnblogs.com";

            this.urls.Add(startUrl, false);
        }

        async public void Crawl()
        {
            Console.WriteLine("Start Crawling");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 50) break;

                string html = await DownLoad(current);
                

                urls[current] = true;
                count++;

                Parse(html,current);

            }

            Console.WriteLine("End Crawling");
            Console.WriteLine("Total Count:" + count.ToString());
            Console.ReadLine();
     
        }

        async Task<string> DownLoad(string url)
        {
            try
            {
                HttpClient searchEngineClient = new HttpClient();
                Task<Stream> task = searchEngineClient.GetStreamAsync(url);
                StreamReader sr = new StreamReader(await task);
                string contents = sr.ReadToEnd();
                sr.Close();
                validUrlList.Add(new URL(validUrlList.Count, url));
                CrawlinglEvent(url);
                return contents;
            }
            catch(Exception ex)
            {
                invalidUrlList.Add(new URL(invalidUrlList.Count, url));
                CrawlinglEvent(url);
                Console.WriteLine(ex.Message);
                return "";
            }

        }

        /*
        private string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);

                return html;
            }
            catch (Exception ex)
            {
              
            }
        }
        */

        private void Parse(string html, string baseUrl)
        {
            //string strRef = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']\.(html|htm|jsp|aspx|php)";
            string strRef = @"(href|HREF)=[^<>]*\.(html|htm|jsp|aspx|php)";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ' ','>');
                if (!Regex.IsMatch(strRef, @".*(http|https)"))
                {
                    strRef = ToAbsolutePath(baseUrl, strRef);
                }

                if (strRef.Length == 0) continue;

                if (urls[strRef] == null)
                { 
                    urls[strRef] = false;
                } 
            }
        }

        private string ToAbsolutePath(string basePath, string relativePath)
        {
            return new Uri(new Uri(basePath), relativePath).ToString();
        }
    }
}
