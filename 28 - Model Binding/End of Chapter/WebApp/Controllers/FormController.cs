using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Controllers {

    [AutoValidateAntiforgeryToken]
    public class FormController : Controller {
        private DataContext context;

        public FormController(DataContext dbContext) {
            context = dbContext;
        }

        public async Task<IActionResult> Index([FromQuery] long? id) {
            ViewBag.Categories
                = new SelectList(context.Categories, "CategoryId", "Name");
            return View("Form", await context.Products.Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(p => id == null || p.ProductId == id));
        }

        [HttpPost]
        public IActionResult SubmitForm([Bind("Name", "Category")] Product product) {
            TempData["name"] = product.Name;
            TempData["price"] = product.Price.ToString();
            TempData["category name"] = product.Category?.Name;
            return RedirectToAction(nameof(Results));
        }

        public IActionResult Results() {
            return View();
        }

        public string Header([FromHeader(Name = "Accept-Language")] string accept) {
            return $"Header: {accept}";
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public Product Body([FromBody] Product model) {
            return model;
        }
    }
}
