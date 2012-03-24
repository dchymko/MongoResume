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
    public class Resume
    {

        public Resume()
        {
            this.updatedTime = DateTime.Now;
        }
        [BsonId]
        public ObjectId Id { get; set; }
        public DateTime updatedTime { get; set; }
        public string resumeName { get; set; }
        public string resumeCode { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string jobTitle { get; set; }
        public string profile { get; set; }
        public List<WorkExperience> workExp { get; set; }
        public List<SkillGroup> skillGroups { get; set; }
    }

    public class WorkExperience
    {
        public WorkExperience(string jobTitle, string company, string startDate, string endDate) {
            this.jobTitle = jobTitle;
            this.company = company;
            this.startDate = startDate;
            this.endDate = endDate;
            tasks = new string[] {"one", "two"};
        }
        public WorkExperience() { }
        public string jobTitle { get; set; }
        public string company { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string[] tasks { get; set; }
        
    }

    public class SkillGroup
    {
        public string groupName { get; set; }
        public string[] skillList { get; set; }
    }

}
