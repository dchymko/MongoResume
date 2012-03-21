using System.Web.Mvc;
using AppHarborMongoDBDemo.Models;
using MongoDB.Driver;



namespace AppHarborMongoDBDemo.Controllers
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
			return View(_collection.FindAll());
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
