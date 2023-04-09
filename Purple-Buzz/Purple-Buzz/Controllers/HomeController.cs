using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Purple_Buzz.Data;
using Purple_Buzz.Models;
using Purple_Buzz.ViewModels;

namespace Purple_Buzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {

            List<HomeSlider> homeSliders = await _context.HomeSliders.ToListAsync();
            List<HomeServices> homeServices = await _context.HomeServices.ToListAsync();
            List<Recents> recents = await _context.Recents.ToListAsync();

            HomeVM model = new() {

                HomeSliders= homeSliders,
                HomeServices = homeServices,
                Recents= recents
            };

            return View(model);
        }

        
    }
}