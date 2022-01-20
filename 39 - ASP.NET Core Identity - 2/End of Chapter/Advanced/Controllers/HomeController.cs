using Advanced.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Advanced.Services;

namespace Advanced.Controllers {
    public class HomeController : Controller {
        private DataContext context;
        private ToggleService toggleService;

        public HomeController(DataContext dbContext, ToggleService ts) {
            context = dbContext;
            toggleService = ts;
        }

        public IActionResult Index([FromQuery] string selectedCity) {
            return View(new PeopleListViewModel {
                People = context.People
                    .Include(p => p.Department).Include(p => p.Location),
                Cities = context.Locations.Select(l => l.City).Distinct(),
                SelectedCity = selectedCity
            });
        }

        public string Toggle() => $"Enabled: { toggleService.ToggleComponents() }";
    }

    public class PeopleListViewModel {
        public IEnumerable<Person> People { get; set; } = Enumerable.Empty<Person>();
        public IEnumerable<string> Cities { get; set; } = Enumerable.Empty<string>();
        public string SelectedCity { get; set; } = String.Empty;

        public string GetClass(string? city) =>
            SelectedCity == city ? "bg-info text-white" : "";
    }
}
