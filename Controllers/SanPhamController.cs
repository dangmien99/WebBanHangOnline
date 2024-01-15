using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly ApplicationDbContext _dataContext;
        private readonly ILogger<SanPhamController> _logger;
        public SanPhamController(ILogger<SanPhamController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _dataContext = context;
        }
        public IActionResult Index()
        {
            var product = _dataContext.SanPhams.Include("MaDmNavigation").Include("MaThNavigation").ToList();
            return View(product);
        }
        public async Task< IActionResult> Details( int slug) // chưa nhận được id
        {
            if (slug == null) return RedirectToAction("Index");
            var sanPhamById = _dataContext.SanPhams.Where(p => p.MaSp == slug).FirstOrDefault();
            return View(sanPhamById);

        }
    }
}
