using Lab_P126.Data;
using Lab_P126.Models;
using Lab_P126.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_P126.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            List<Slider> slider = _context.Sliders.ToList();
            List<Product> product = _context.Products.ToList();
            List<Service> service = _context.Services.ToList();
            List<Banner> banner = _context.Banners.ToList();


            HomeVM homeVM = new HomeVM
            {
                Sliders = slider,
                Products=product,
                Services=service,
                Banners=banner
            };

            return View(homeVM);
        }

    }
}
