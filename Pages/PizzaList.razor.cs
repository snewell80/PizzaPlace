using Microsoft.AspNetCore.Components;
using PizzaPlace.Enums;
using PizzaPlace.Models;

namespace PizzaPlace.Pages
{
    public partial class PizzaList
    {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Pizza> Pizzas { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Pizza> Selected { get; set; }
    }
}
