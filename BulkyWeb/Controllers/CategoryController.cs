using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _dbContext;
        public CategoryController(ApplicationDbContext dbContext)
        {
			_dbContext = dbContext;	
        }
        public IActionResult Index()
		{
			List<Category> categories = _dbContext.categories.ToList(); 
			return View(categories);
		}
	}
}
