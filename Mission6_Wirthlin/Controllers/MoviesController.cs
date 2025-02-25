using System;
using Microsoft.AspNetCore.Mvc;
using Mission6_Wirthlin.Data;
using Mission6_Wirthlin.Models;

namespace Mission6_Wirthlin.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Returns the form view
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Movies.Add(movie);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                return View(movie);
            }
            catch (Exception ex)
            {
                // Log the exception or inspect ex.Message in the Developer Exception Page
                throw;
            }
        }
    }
}