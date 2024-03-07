using System.ComponentModel;

namespace PizzaPlace.Enums
{
    public enum Spiciness
    {
        [Description("None")]
        None = 0,
        [Description("Spicy")]
        Spicy = 1,
        [Description("Hot")]
        Hot = 2,
    }
}
