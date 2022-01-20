using System.Linq.Expressions;

namespace Microsoft.AspNetCore.Authentication.Cookies {
    public static class CookieAuthenticationExtensions {

        public static void DisableRedirectForPath(
            this CookieAuthenticationEvents events,
            Expression<Func<CookieAuthenticationEvents,
                Func<RedirectContext<CookieAuthenticationOptions>, Task>>> expr,
            string path, int statuscode) {

            string propertyName = ((MemberExpression)expr.Body).Member.Name;
            var oldHandler = expr.Compile().Invoke(events);

            Func<RedirectContext<CookieAuthenticationOptions>, Task> newHandler
                    = context => {
                        if (context.Request.Path.StartsWithSegments(path)) {
                            context.Response.StatusCode = statuscode;
                        } else {
                            oldHandler(context);
                        }
                        return Task.CompletedTask;
                    };

            typeof(CookieAuthenticationEvents).GetProperty(propertyName)?
                .SetValue(events, newHandler);
        }
    }
}
