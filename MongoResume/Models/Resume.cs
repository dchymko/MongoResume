using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoResume.Models
{
    [BsonIgnoreExtraElements]
    public class Resume<K>
    {
        public Resume(K message)
        {
            this.updatedTime = DateTime.Now;
            this.Message = message;
        }
        public Resume()
        {
            this.updatedTime = DateTime.Now;
        }
        public K Message { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        public DateTime updatedTime { get; set; }
        public string resumeCode { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string jobTitle { get; set; }
        public string profile { get; set; }
    }
}
