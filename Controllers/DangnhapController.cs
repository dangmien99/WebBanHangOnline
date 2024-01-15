using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    public class DangnhapController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DangnhapController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //     ViewBag.ThongBao = thongbao;
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(TaiKhoan taikhoan)
        {
            if (taikhoan == null || string.IsNullOrEmpty(taikhoan.TaiKhoan1) || string.IsNullOrEmpty(taikhoan.MatKhau))
            {
                return RedirectToAction("Index", new { thongBao = "Tài khoản không chính xác" });
            }

            List<TaiKhoan> listTaiKhoan = _context.TaiKhoans.ToList();
            var taikhoandangnhap = listTaiKhoan.Where(tk => tk.TaiKhoan1.ToUpper().Equals(taikhoan.TaiKhoan1.ToUpper()) && tk.MatKhau.ToUpper().Equals(taikhoan.MatKhau.ToUpper())).FirstOrDefault();
            if (taikhoandangnhap != null)
            {
                var nv = _context.NhanViens.FirstOrDefault(a => a.MaNd == taikhoandangnhap.MaNd);
                //var kh = _context.KhachHangs.FirstOrDefault(a => a.m == taikhoandangnhap.MaNd);
                if (nv == null)
                {
                    return RedirectToAction("","");
                }
                else
                {
                    // nếu là nhân viên 
                    return RedirectToAction("","Admin");
                }
            }
            else
            {
                return RedirectToAction("Index", new { thongBao = "" });
            }
            //return null;
        }


    }
}
