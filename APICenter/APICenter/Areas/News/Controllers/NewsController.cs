using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using APICenter.Areas.News.Models;
using MongoDB.Driver;

namespace APICenter.Areas.News.Controllers
{
    public class NewsController : ApiController
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult getNews(NewsPara para)
        {

            MongoHelper<Models.News>  NewsHelper = new MongoHelper<Models.News>();
            List<Models.News> newslist = new List<Models.News>();
            if (string.IsNullOrEmpty(para.value))
            {
                newslist = NewsHelper.Queryable.Select(s => s).ToList();
            }
            else
            {
                var notificationLogBuilder = Builders<Models.News>.IndexKeys;
                var indexModel = new CreateIndexModel<Models.News>(notificationLogBuilder.Text(x => x.title));
                NewsHelper.Collection.Indexes.CreateOne(indexModel);

                newslist = NewsHelper.Collection.Find(Builders<Models.News>.Filter.Where(w => w.title.Contains(para.value) || w.description.Contains(para.value))).ToList();
            }

            int total = newslist.Count();

            return Ok(new
            {
                total,
                data = newslist,
            });
        }
    }

    public struct NewsPara
    {
        public string value { get; set; }
    }
}
