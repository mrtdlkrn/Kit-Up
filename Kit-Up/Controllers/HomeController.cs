using Kit_Up.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Kit_Up.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Urunler.ToList();
            return View(urunler);
        }
        public ActionResult Kitap(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun kitap = _context.Urunler.Find(id);

            if (kitap == null)
            {
                return HttpNotFound();
            }

            return View(kitap);
        }
        public ActionResult Sepet()
        {
            return View();
        }

        public ActionResult KayitOl()
        {
            return View();
        }

    }
}