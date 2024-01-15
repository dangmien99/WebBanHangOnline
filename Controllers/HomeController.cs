using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dataContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , ApplicationDbContext context)
        {
            _logger = logger;
            _dataContext = context;
        }
        public IActionResult Index()
        {
            var products = _dataContext.SanPhams.Include("MaDmNavigation").Include("MaThNavigation").Take(6).ToList();
            return View(products);
        }
//public AcceptedResult Home()
//        {
//            ApplicationDbContext context = new ApplicationDbContext();
//            var data = context.TaiKhoans;

//            var data2 = ApplicationDbContext.TaiKhoan1;
//            return View();
//        }
      
       
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
