using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Bson;
using MongoDB.Driver;

using static MongoDB.Bson.Serialization.BsonDeserializationContext;

namespace APICenter
{
    public class MongoBase
    {
        private static string _connStr = "";
        private static string _dbName = "eChainVP";

        private static MongoUrl url = new MongoUrl(_connStr);
        private static MongoClient client = new MongoClient(url);
        public static IMongoDatabase db = client.GetDatabase(_dbName);
    }

    public class MongoHelper<TEntity>
    {
        public string Name => typeof(TEntity).Name;
        public IMongoCollection<TEntity> Collection => MongoBase.db.GetCollection<TEntity>(Name);
        public List<TEntity> Queryable => Collection.AsQueryable().ToList();

        public FilterDefinitionBuilder<TEntity> Filter => Builders<TEntity>.Filter;

        public UpdateDefinitionBuilder<TEntity> Update => Builders<TEntity>.Update;
    }
}