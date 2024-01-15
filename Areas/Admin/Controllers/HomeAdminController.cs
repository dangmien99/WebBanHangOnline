using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;
using X.PagedList;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeAdmin")]
    public class HomeAdminController : Controller
    {
        private readonly ApplicationDbContext _dataContext;
        private readonly ILogger<HomeAdminController> _logger;

        public HomeAdminController(ILogger<HomeAdminController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _dataContext = context;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("danhmucsanpham")]
        public IActionResult DanhMucSanPham()
        {
            var lstDMSanPham = _dataContext.DanhMucSanPhams.ToList();
            return View(lstDMSanPham);
        }
        [Route("sanpham")]
        public IActionResult SanPham(int? page)
        {
            int pageSize = 10;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstSanPham = _dataContext.SanPhams.Include("MaDmNavigation").Include("MaThNavigation").AsNoTracking().OrderBy(a => a.MaSp);
            IPagedList<SanPham> pagedList = lstSanPham.ToPagedList(pageNumber, pageSize);
            return View(pagedList);
        }
    }
}
