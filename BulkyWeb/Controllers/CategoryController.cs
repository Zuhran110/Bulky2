using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db), "Database context is null");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
