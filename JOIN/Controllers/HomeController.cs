using Microsoft.AspNetCore.Mvc;

namespace JOIN.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => Redirect("/account/register");


    }
}
