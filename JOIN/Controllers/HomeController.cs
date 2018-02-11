using Microsoft.AspNetCore.Mvc;

namespace JOIN.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/account/register");
        }


    }
}
