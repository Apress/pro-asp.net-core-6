using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApp.Validation {

    public static class ModelStateExtensions {

        public static void PromotePropertyErrors(this ModelStateDictionary modelState,
                string propertyName) {
            foreach (var err in modelState) {
                if (err.Key == propertyName &&
                        err.Value.ValidationState == ModelValidationState.Invalid) {
                    foreach (var e in err.Value.Errors) {
                        modelState.AddModelError(string.Empty, e.ErrorMessage);
                    }
                }
            }
        }
    }
}
