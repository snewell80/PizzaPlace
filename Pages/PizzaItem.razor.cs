using Microsoft.AspNetCore.Components;
using PizzaPlace.Enums;
using PizzaPlace.Models;

namespace PizzaPlace.Pages
{
    public partial class PizzaItem
    {
        [Parameter]
        public Pizza Pizza { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public EventCallback<Pizza> Selected { get; set; }
        private string SpicinessImage(Spiciness spiciness) => $"Images/{spiciness.ToString().ToLower()}.png";
    }
}
