using Microsoft.AspNetCore.Mvc;
using MVCProject2.Data;
using MVCProject2.Models;

namespace MVCProject2.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List <Category> catlistobj = _db.Categories.ToList();
            return View(catlistobj);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
		public IActionResult Create(Category obj)
		{
			_db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index","Category");
		}
	}
}
