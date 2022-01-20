using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApp.Filters {

    public class SimpleCacheAttribute : Attribute, IAsyncResourceFilter {
        private Dictionary<PathString, IActionResult> CachedResponses
            = new Dictionary<PathString, IActionResult>();

        public async Task OnResourceExecutionAsync(ResourceExecutingContext context,
                ResourceExecutionDelegate next) {
            PathString path = context.HttpContext.Request.Path;
            if (CachedResponses.ContainsKey(path)) {
                context.Result = CachedResponses[path];
                CachedResponses.Remove(path);
            } else {
                ResourceExecutedContext execContext = await next();
                if (execContext.Result != null) {
                    CachedResponses.Add(context.HttpContext.Request.Path,
                        execContext.Result);
                }
            }
        }
    }
}
