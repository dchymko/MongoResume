using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AppHarborMongoDBDemo.Models
{
    [BsonIgnoreExtraElements]
    public class Resume<K>
    {
        public Resume(K message)
        {
            this.Time = DateTime.Now;
            this.Message = message;
        }
        public Resume()
        {
            this.Time = DateTime.Now;
        }
        public K Message { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public DateTime Time { get; set; }
        public string ResumeName { get; set; }
        //public string[] fields { get; set; } 
    }
}
