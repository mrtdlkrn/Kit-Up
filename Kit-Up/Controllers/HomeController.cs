using Kit_Up.Models;
using System.Linq;
using System.Web.Mvc;

namespace Kit_Up.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Urunler.ToList());
        }
    }
}