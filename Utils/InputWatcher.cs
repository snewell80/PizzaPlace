using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace PizzaPlace.Utils
{
    public class InputWatcher : ComponentBase
    {
        private EditContext editContext = default!;
        [CascadingParameter]
        public EditContext EditContext
        {
            get => editContext;
            set
            {
                editContext = value;
                EditContext.OnFieldChanged += async (sender, e) => { await FieldChanged.InvokeAsync(e.FieldIdentifier.FieldName); };
            }
        }
        [Parameter]
        public EventCallback<String> FieldChanged { get; set; }
        public bool Validate() => editContext?.Validate() ?? false;
    }
}
