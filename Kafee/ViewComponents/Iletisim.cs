using Kafee.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Kafee.ViewComponents
{
    public class Iletisim:ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public Iletisim(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var iletisim = _db.İletisims.ToList();
            return View(iletisim);
        }
    }
}
