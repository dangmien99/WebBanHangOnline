using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    public class DanhMucSanPhamController : Controller
    {
        private readonly ApplicationDbContext _dataContext;
        public DanhMucSanPhamController(ApplicationDbContext context)
        {
            _dataContext = context;
        }
        public async Task<IActionResult> Index(int code)
        {
            var danhMucSanPham = _dataContext.DanhMucSanPhams.Where(c => c.MaDm == code).FirstOrDefault();
            if (danhMucSanPham == null) return RedirectToAction("Index");
            var SanPhamByDanhMucSan = _dataContext.SanPhams.Where(p => p.MaDm == danhMucSanPham.MaDm);
            return View(await SanPhamByDanhMucSan.OrderByDescending(p => p.MaDm).ToListAsync());
        }
    }
}
