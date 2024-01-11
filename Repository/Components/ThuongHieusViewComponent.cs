using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Repository.Components
{
    public class ThuongHieusViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _dataContext;
        public ThuongHieusViewComponent(ApplicationDbContext context)
        {
            _dataContext = context;
        }
        public async Task<IViewComponentResult> InvokeAsync() => View(await _dataContext.ThuongHieus.ToListAsync());
    }
}
