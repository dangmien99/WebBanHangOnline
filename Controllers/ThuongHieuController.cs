using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    public class ThuongHieuController : Controller
    {
        private readonly ApplicationDbContext _dataContext;
        public ThuongHieuController(ApplicationDbContext context)
        {
            _dataContext = context;
        }
        public async Task<IActionResult> Index(int code)
        {
            var ThuongHieu = _dataContext.ThuongHieus.Where(c => c.MaTh == code).FirstOrDefault();
            if (ThuongHieu == null) return RedirectToAction("Index");
            var SanPhamByThuongHieu = _dataContext.SanPhams.Where(p => p.MaTh == ThuongHieu.MaTh);
            return View(await SanPhamByThuongHieu.OrderByDescending(p => p.MaTh).ToListAsync());
        }
    }
}
