using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace Advanced.Pages {

    [Authorize(Roles = "Admins")]
    public class AdminPageModel : PageModel {

    }
}
