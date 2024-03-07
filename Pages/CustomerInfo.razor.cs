using Microsoft.AspNetCore.Components;
using PizzaPlace.Models;
using PizzaPlace.Utils;

namespace PizzaPlace.Pages
{
    public partial class CustomerInfo
    {
        [Parameter]
        public String Title { get; set; } = default!;
        [Parameter]
        public String ButtonTitle { get; set; } = default!;
        [Parameter]
        public String ButtonClass { get; set; } = default!;
        [Parameter]
        public Customer Customer { get; set; } = default!;
        [Parameter]
        public EventCallback ValidSubmit { get; set; } = default!;
        [Parameter]
        public EventCallback<Customer> CustomerChanged {get;set;}
        private void FieldChanged(string fieldName) 
        { 
            CustomerChanged.InvokeAsync(Customer);
            isInvalid = !inputWatcher.Validate();
        }
        private InputWatcher inputWatcher = default!;
        bool isInvalid = true;

    }
}
