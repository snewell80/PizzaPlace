using Microsoft.AspNetCore.Components;

namespace PizzaPlace.Pages
{
    public partial class DismissibleAlert
    {
        [Parameter]
        public bool Show
        { 
            get => Show;
            set
            {
                if(value != Show)
                {
                    Show = value;
                    ShowChanged?.Invoke(Show);
                }
            } 
        }
        [Parameter]
        public Action<bool> ShowChanged { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; } = default!;
        public void Dismiss() => Show = false;
    }
}
