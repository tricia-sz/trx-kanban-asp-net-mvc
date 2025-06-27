using Microsoft.AspNetCore.Mvc;


namespace TrxKanban.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
    }
}
