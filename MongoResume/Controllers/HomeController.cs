using System.Web.Mvc;
using AppHarborMongoDBDemo.Models;
using MongoDB.Driver;
using Rotativa;


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
			return View("Resume", _collection.FindAll());
		}

        public ActionResult Index2()
        {
            return View("Index", _collection.FindAll());
        }

        public ActionResult PrintResume(int invoiceId= 0)
        {
            return new ActionAsPdf(
                           "Index",
                           null) { FileName = "Invoice.pdf" };
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
