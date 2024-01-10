using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Repository.Components
{
    public class DanhMucSanPhamsViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _dataContext;
        public DanhMucSanPhamsViewComponent (ApplicationDbContext context)
        {
            _dataContext = context;
        }
        public async Task<IViewComponentResult> InvokeAsync() => View(await _dataContext.DanhMucSanPhams.ToListAsync());
    }
}
