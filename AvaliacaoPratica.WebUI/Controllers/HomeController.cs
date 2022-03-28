using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoPratica.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
