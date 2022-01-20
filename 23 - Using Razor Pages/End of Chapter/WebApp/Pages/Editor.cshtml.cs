using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages {
    public class EditorModel : PageModel {
        private DataContext context;

        public Product? Product { get; set; }

        public EditorModel(DataContext ctx) {
            context = ctx;
        }

        public async Task OnGetAsync(long id) {
            Product = await context.Products.FindAsync(id);
        }

        public async Task<IActionResult> OnPostAsync(long id, decimal price) {
            Product? p = await context.Products.FindAsync(id);
            if (p != null) {
                p.Price = price;
            }
            await context.SaveChangesAsync();
            return RedirectToPage();
        }
    }
}
