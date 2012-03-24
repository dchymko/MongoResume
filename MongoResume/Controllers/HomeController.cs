using System.Web.Mvc;
using MongoResume.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace MongoResume.Controllers
{
	public class HomeController : BaseController
	{

        private MongoCollection<Resume<WorkExperience>> _collection;
		public HomeController()
		{
            _collection = Database.GetCollection<Resume<WorkExperience>>("resume");
		}

		public ActionResult Index()
		{
            Resume<WorkExperience> re = new Resume<WorkExperience>();
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

		public ActionResult Create( Resume<WorkExperience> resume)
		{
            string[] fields = {"one", "two"};
            //resume.fields = fields;
			_collection.Insert(resume);
			return RedirectToAction("Index");
		}
	}
}
