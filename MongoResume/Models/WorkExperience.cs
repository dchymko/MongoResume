using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization;

namespace AppHarborMongoDBDemo.Models
{
    [BsonIgnoreExtraElements]
    public class WorkExperience
    {
        public WorkExperience()
        { 

           
        }
        public string Company { get; set; }
        public uint YearsExperience { get; set; }
    }

}