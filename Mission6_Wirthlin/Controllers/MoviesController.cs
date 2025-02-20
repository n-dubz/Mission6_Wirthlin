using Microsoft.AspNetCore.Mvc;
using Mission6_Wirthlin.Models;
using Mission6_Wirthlin.Data;

namespace Mission6_Wirthlin.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }
        
        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(movie);
        }
    }
}