using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApp.TagHelpers {

    [HtmlTargetElement("tr", Attributes = "for")]
    public class ModelRowTagHelper : TagHelper {

        public string Format { get; set; } = "";
        public ModelExpression? For { get; set; }

        public override void Process(TagHelperContext context,
                TagHelperOutput output) {

            output.TagMode = TagMode.StartTagAndEndTag;

            TagBuilder th = new TagBuilder("th");
            th.InnerHtml.Append(For?.Name.Split(".").Last() ?? String.Empty);
            output.Content.AppendHtml(th);

            TagBuilder td = new TagBuilder("td");
            if (Format != null && For?.Metadata.ModelType == typeof(decimal)) {
                td.InnerHtml.Append(((decimal)For.Model).ToString(Format));
            } else {
                td.InnerHtml.Append(For?.Model.ToString() ?? String.Empty);
            }
            output.Content.AppendHtml(td);
        }
    }
}
