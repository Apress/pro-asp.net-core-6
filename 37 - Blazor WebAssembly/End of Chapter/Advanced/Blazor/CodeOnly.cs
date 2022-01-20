using Advanced.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

namespace Advanced.Blazor {

    public class CodeOnly : ComponentBase {

        [Inject]
        public DataContext? Context { get; set; }

        public IEnumerable<string> Names => Context?.People.Select(p => p.Firstname)
            ?? Enumerable.Empty<string>();

        public bool Ascending { get; set; } = false;

        protected override void BuildRenderTree(RenderTreeBuilder builder) {
            IEnumerable<string> data = Ascending
                ? Names.OrderBy(n => n) : Names.OrderByDescending(n => n);

            builder.OpenElement(1, "button");
            builder.AddAttribute(2, "class", "btn btn-primary mb-2");
            builder.AddAttribute(3, "onclick",
                EventCallback.Factory.Create<MouseEventArgs>(this,
                    () => Ascending = !Ascending));
            builder.AddContent(4, new MarkupString("Toggle"));
            builder.CloseElement();

            builder.OpenElement(5, "ul");
            builder.AddAttribute(6, "class", "list-group");
            foreach (string name in data) {
                builder.OpenElement(7, "li");
                builder.AddAttribute(8, "class", "list-group-item");
                builder.AddContent(9, new MarkupString(name));
                builder.CloseElement();
            }
            builder.CloseElement();
        }
    }
}
