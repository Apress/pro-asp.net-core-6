using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers {

    public class HomeController : Controller {
        private DataContext context;

        public HomeController(DataContext ctx) {
            context = ctx;
        }

        public async Task<IActionResult> Index(long id = 1) {
            Product? prod = await context.Products.FindAsync(id);
            if (prod?.CategoryId == 1) {
                return View("Watersports", prod);
            } else {
                return View(prod);
            }
        }

        public IActionResult Common() {
            return View();
        }

        public IActionResult List() {
            return View(context.Products);
        }
    }
}
