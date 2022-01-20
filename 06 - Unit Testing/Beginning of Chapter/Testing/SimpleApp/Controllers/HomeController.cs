using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;

namespace SimpleApp.Controllers {
    public class HomeController : Controller {

        public ViewResult Index() {
            return View(Product.GetProducts());
        }
    }
}
