using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.TagHelpers {

    [HtmlTargetElement("tablehead")]
    public class TableHeadTagHelper : TagHelper {

        public string BgColor { get; set; } = "light";

        public override async Task ProcessAsync(TagHelperContext context,
                TagHelperOutput output) {

            output.TagName = "thead";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("class",
                $"bg-{BgColor} text-white text-center");

            string content = (await output.GetChildContentAsync()).GetContent();

            TagBuilder header = new TagBuilder("th");
            header.Attributes["colspan"] = "2";
            header.InnerHtml.Append(content);

            TagBuilder row = new TagBuilder("tr");
            row.InnerHtml.AppendHtml(header);

            output.Content.SetHtmlContent(row);
        }
    }
}
