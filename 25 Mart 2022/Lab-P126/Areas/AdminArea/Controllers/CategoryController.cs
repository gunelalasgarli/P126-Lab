using Lab_P126.Data;
using Lab_P126.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_P126.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> category = _context.Categories.ToList();
            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid) 
            {
                return View();
            }

            bool existProduct = _context.Categories.Any(m => m.Name.ToLower().Trim() == category.Name.ToLower().Trim());
            if(existProduct)
            {
                ModelState.AddModelError("Name", "Bu Movcuddur");
                return View();
            }
            _context.Categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
