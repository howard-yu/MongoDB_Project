using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System.Net;

using Newtonsoft.Json;
using MongoDB.Driver;
using MongoAppdemo;

namespace NewsJobs
{
    class Program
    {
        private static MongoClient _mongoClient;
        private static MongoDatabaseBase _mongoDatabaseBase;



        static void Main(string[] args)
        {
            Logmessage.WriteLog("Start Job by News Update");
            Logmessage.ReadLog(DateTime.Now.ToString("yyyy-MM-dd"));

            string[] Area = new string[] { "CN", "TW" };

            var newsApiClient = new NewsApiClient("7d413874ff4447e3bbaef43b932bb40b");

            List<string> urls = new List<string>();
            urls.Add("http://newsapi.org/v2/top-headlines?country=tw&category=business&apiKey=7d413874ff4447e3bbaef43b932bb40b");
            urls.Add("http://newsapi.org/v2/top-headlines?country=cn&category=business&apiKey=7d413874ff4447e3bbaef43b932bb40b");


            //var url = "http://newsapi.org/v2/top-headlines?country=tw&category=business&apiKey=7d413874ff4447e3bbaef43b932bb40b";
            foreach (var url in urls)
            {
                try
                {
                    getNews(url, "utf-8");
                }
                catch (Exception ex)
                {
                    Logmessage.WriteLog(ex.Message.ToString());
                    Logmessage.ReadLog(DateTime.Now.ToString("yyyy-MM-dd"));
                }
                
            }

            Console.WriteLine("write OK");
            //Console.ReadKey();

        }

        public static void getNews(string Url, string encoding)
        {
            string connectionString = "";
            _mongoClient = new MongoClient(connectionString);

            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.GetEncoding(encoding);


            var json = wc.DownloadString(Url);

            var jsonresult = JsonConvert.DeserializeObject<news>(json);

            //return jsonresult;

            var mdb = _mongoClient.GetDatabase("eChainVP");
            var collection = mdb.GetCollection<NewSource>("News");

            collection.InsertMany(jsonresult.articles);

            Logmessage.WriteLog("End Job by News Update");
            Logmessage.ReadLog(DateTime.Now.ToString("yyyy-MM-dd"));
        }

    }

    public struct news
    {
        public string status { get; set; }
        public string totalResults { get; set; }
        public List<NewSource> articles { get; set; }
    }

    public struct NewSource
    {
        public string country { get; set; }
        public Source source { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public string publishedAt { get; set; }
        public string content { get; set; }
    }

    public struct Source
    {
        public string id { get; set; }
        public string name { get; set; }
    }
}
