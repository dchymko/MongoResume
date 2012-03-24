using System.Web.Mvc;
using MongoResume.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System;

namespace MongoResume.Controllers
{
	public class ResumeController : BaseController
	{

        private MongoCollection<Resume> _collection;
		public ResumeController()
		{
            _collection = Database.GetCollection<Resume>("resume");
		}

		public ActionResult Index()
		{
            Resume re = new Resume();
            QueryDocument query = new QueryDocument("resumeCode", "darylchymko1");
            re = _collection.FindOne(query);
            return View("Resume", re);

		}

        public ActionResult Index2()
        {
            return View("Index", _collection.FindAll());
        }


		public ActionResult New()
		{
			return View();
		}


        public JsonResult Json()
        {
            return Json(_collection.FindAll(),JsonRequestBehavior.AllowGet);
        }

		public ActionResult Create(Resume resume)
		{
            string[] fields = {"one", "two"};
            List<WorkExperience> workexp = new List<WorkExperience>();

            workexp.Add(new WorkExperience("Contracted Developer", "Universal Mind", "2011-09-30", ""));
            resume.workExp = workexp;

            //resume.fields = fields;
			_collection.Insert(resume);
			return RedirectToAction("Index");
		}
	}


}
