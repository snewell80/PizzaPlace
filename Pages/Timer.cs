﻿using Microsoft.AspNetCore.Components;

namespace PizzaPlace.Pages
{
    public class Timer : ComponentBase
    {
        [Parameter]
        public double TimeInSeconds { get; set; }
        [Parameter]
        public EventCallback Tick { get; set; } = default!;

        protected override void OnInitialized()
        {
            var timer = new System.Threading.Timer(callback:(_)=> InvokeAsync(() => Tick?.Invoke()), state: null, dueTime: TimeSpan.FromSeconds(TimeInSeconds), period: Timeout.InfiniteTimeSpan);
        }
    }
}