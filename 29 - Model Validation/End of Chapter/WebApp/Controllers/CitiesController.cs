using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using WebApp.Models;

namespace WebApp.Controllers {

    [ViewComponent(Name = "CitiesControllerHybrid")]
    public class CitiesController : Controller {
        private CitiesData data;

        public CitiesController(CitiesData cdata) {
            data = cdata;
        }

        public IActionResult Index() {
            return View(data.Cities);
        }

        public IViewComponentResult Invoke() {
            return new ViewViewComponentResult() {
                ViewData = new ViewDataDictionary<CityViewModel>(
                    ViewData,
                    new CityViewModel {
                        Cities = data.Cities.Count(),
                        Population = data.Cities.Sum(c => c.Population)
                    })
            };
        }
    }
}
