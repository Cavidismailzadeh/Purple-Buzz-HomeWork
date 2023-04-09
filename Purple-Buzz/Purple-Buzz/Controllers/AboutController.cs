using Microsoft.AspNetCore.Mvc;
using Purple_Buzz.Data;
using Purple_Buzz.Models;
using Purple_Buzz.ViewModels;

namespace Purple_Buzz.Controllers
{
    public class AboutController : Controller
    {
        //private readonly AppDbContext _context;
        //public AboutController(AppDbContext context)
        //{
        //    _context = context;
        //}


        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
