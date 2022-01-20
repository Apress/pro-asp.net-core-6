using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers {

    public class HomeController : Controller {

        public IActionResult Index() {
            return View("Message",
                "This is the Index action on the Home controller");
        }
    }
}
