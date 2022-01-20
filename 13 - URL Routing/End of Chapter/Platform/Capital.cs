namespace Platform {

    public class Capital {

        public static async Task Endpoint(HttpContext context) {
            string? capital = null;
            string? country = context.Request.RouteValues["country"] as string;
            switch ((country ?? "").ToLower()) {
                case "uk":
                    capital = "London";
                    break;
                case "france":
                    capital = "Paris";
                    break;
                case "monaco":
                    LinkGenerator? generator =
                        context.RequestServices.GetService<LinkGenerator>();
                    string? url = generator?.GetPathByRouteValues(context,
                        "population", new { city = country });
                    if (url != null) {
                        context.Response.Redirect(url);
                    }
                    return;
            }
            if (capital != null) {
                await context.Response
                    .WriteAsync($"{capital} is the capital of {country}");
            } else {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
            }
        }
    }
}
