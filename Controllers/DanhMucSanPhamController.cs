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
        public async Task<IActionResult> Index(int slug)
        {
            var danhMucSanPham = _dataContext.DanhMucSanPhams.Where(c => c.MaDm == slug).FirstOrDefault();//lấy dữ liệu 
            if (danhMucSanPham == null) return RedirectToAction("Index");
            var sanPhamByDanhMucSan = _dataContext.SanPhams.Where(p => p.MaDm == danhMucSanPham.MaDm);
            return View(await sanPhamByDanhMucSan.OrderByDescending(p => p.MaDm).ToListAsync());
        }
    }
}
