using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using WebApp.Models;

namespace WebApp.Pages {

    [ViewComponent(Name = "CitiesPageHybrid")]
    public class CitiesModel : PageModel {

        public CitiesModel(CitiesData cdata) {
            Data = cdata;
        }

        public CitiesData? Data { get; set; }

        [ViewComponentContext]
        public ViewComponentContext Context { get; set; } = new();

        public IViewComponentResult Invoke() {
            return new ViewViewComponentResult() {
                ViewData = new ViewDataDictionary<CityViewModel>(
                    Context.ViewData,
                    new CityViewModel {
                        Cities = Data?.Cities.Count(),
                        Population = Data?.Cities.Sum(c => c.Population)
                    })
            };
        }
    }
}
