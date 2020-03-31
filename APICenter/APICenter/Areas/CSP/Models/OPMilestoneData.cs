using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICenter.Areas.CSP.Models
{
    [BsonIgnoreExtraElements]
    public class OPMilestoneData
    {
        //public MongoDB.Bson.ObjectId _id { get; set; }
        public int ID { get; set; }
        public string PL { get; set; }
        public string KeyValue { get; set; }
        public Nullable<int> MilestoneID { get; set; }
        public Nullable<System.DateTime> DateValue { get; set; }
        public Nullable<System.DateTime> UTCTime { get; set; }
        public string MilestoneName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UTCOffSet { get; set; }
    }
}