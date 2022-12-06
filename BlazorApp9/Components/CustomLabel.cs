using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components;

namespace BlazorApp9.Components
{
    public class CustomLabel : ComponentBase
    {
        [Parameter] public string Id { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
                builder.OpenElement(1, "label");
                builder.AddAttribute(2, "for", Id);
                builder.AddAttribute(3, "class", "custom-css-classes-here");
                builder.AddContent(4, ChildContent);
                builder.CloseElement();
        }

    }
}
