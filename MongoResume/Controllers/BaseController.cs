using System.Configuration;
using System.Web.Mvc;
using MongoDB.Driver;

namespace MongoResume.Controllers
{
	public abstract class BaseController : Controller
	{
		public MongoDatabase Database
		{
			get
			{
				return MongoDatabase.Create(GetMongoDbConnectionString());
			}
		}


		private string GetMongoDbConnectionString()
		{
			return ConfigurationManager.AppSettings.Get("MONGOHQ_URL") ??
				ConfigurationManager.AppSettings.Get("MONGOLAB_URI") ??
				"mongodb://localhost/Things";
		}
	}
}
