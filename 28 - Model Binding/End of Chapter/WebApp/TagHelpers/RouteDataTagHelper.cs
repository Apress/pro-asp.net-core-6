using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApp.TagHelpers {

    [HtmlTargetElement("div", Attributes = "[route-data=true]")]
    public class RouteDataTagHelper : TagHelper {

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext Context { get; set; } = new();

        public override void Process(TagHelperContext context,
                TagHelperOutput output) {

            output.Attributes.SetAttribute("class", "bg-primary m-2 p-2");

            TagBuilder list = new TagBuilder("ul");
            list.Attributes["class"] = "list-group";
            RouteValueDictionary rd = Context.RouteData.Values;
            if (rd.Count > 0) {
                foreach (var kvp in rd) {
                    TagBuilder item = new TagBuilder("li");
                    item.Attributes["class"] = "list-group-item";
                    item.InnerHtml.Append($"{kvp.Key}: {kvp.Value}");
                    list.InnerHtml.AppendHtml(item);
                }
                output.Content.AppendHtml(list);
            } else {
                output.Content.Append("No route data");
            }
        }
    }
}
