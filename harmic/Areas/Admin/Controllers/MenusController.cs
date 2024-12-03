using Microsoft.AspNetCore.Mvc;

namespace harmic.Areas.Admin.Controllers
{
    public class MenusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
