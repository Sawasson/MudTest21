using Microsoft.AspNetCore.Components;

namespace BlazorApp9.Components
{
    public partial class ARSelectItem<TValue>
    {
        [Parameter] public TValue Value { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }

    }
}
