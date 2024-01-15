using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.ViewModel;
using WebBanHangOnline.Repository;

namespace WebBanHangOnline.Controllers
{
    public class GioHangController : Controller
    {
        private readonly ApplicationDbContext _dataContext;
        public GioHangController(ApplicationDbContext context)
        {

            _dataContext = context;
        }
        public IActionResult Index()
        {
            List<GioHang> gioHangs = HttpContext.Session.GetJson<List<GioHang>>("GioHang") ?? new List<GioHang>();
            GioHangViewModel GioHangVM = new()
            {
                GioHangs = gioHangs,
                GrandTotal = gioHangs.Sum(x => x.Sl * x.GiaThanh)
            };
            return View(GioHangVM);
        }
        public async Task<IActionResult> Add(int Id)
        {
            SanPham sanPham = await _dataContext.SanPhams.FindAsync(Id);
            List<GioHang> gioHangs = HttpContext.Session.GetJson<List<GioHang>>("GioHang") ?? new List<GioHang>();

            GioHang gioHang = gioHangs.FirstOrDefault(c => c.MaSp == Id);

            if (gioHang == null)
            {
                gioHangs.Add(new GioHang(sanPham));
            }
            else
            {
                gioHang.Sl += 1;
            }

            HttpContext.Session.SetJson("GioHang", gioHangs);

            // Redirect back to the previous page
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public async Task<IActionResult> Decrease(int Id)
        {
            List<GioHang> gioHangs = HttpContext.Session.GetJson<List<GioHang>>("GioHang");
            GioHang gioHang = gioHangs.Where(c => c.MaSp == Id).FirstOrDefault();

            if (gioHang != null)
            {
                if (gioHang.Sl > 1)
                {
                    --gioHang.Sl;
                }
                else
                {
                    gioHangs.RemoveAll(p => p.MaSp == Id);
                }

                if (gioHangs.Count == 0)
                {
                    HttpContext.Session.Remove("GioHang");
                }
                else
                {
                    HttpContext.Session.SetJson("GioHang", gioHangs);
                }
            }

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Increase(int Id)
        {
            List<GioHang> gioHangs = HttpContext.Session.GetJson<List<GioHang>>("GioHang");
            GioHang gioHang = gioHangs.Where(c => c.MaSp == Id).FirstOrDefault();

            if (gioHang != null)
            {
                if (gioHang.Sl >= 1)
                {
                    ++gioHang.Sl;
                }
                else
                {
                    gioHangs.RemoveAll(p => p.MaSp == Id);
                }

                if (gioHangs.Count == 0)
                {
                    HttpContext.Session.Remove("GioHang");
                }
                else
                {
                    HttpContext.Session.SetJson("GioHang", gioHangs);
                }
            }

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Remove(int Id)
        {
            List<GioHang> gioHangs = HttpContext.Session.GetJson<List<GioHang>>("GioHang");

            gioHangs.RemoveAll(p => p.MaSp == Id);

            if (gioHangs.Count == 0)
            {
                HttpContext.Session.Remove("GioHang");
            }
            else
            {
                HttpContext.Session.SetJson("GioHang", gioHangs);
            }
            return RedirectToAction("Index");
        }
        //public ActionResult ThanhToan()
        //{
        //    return View();
        //}
    }
}
