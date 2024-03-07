using PizzaPlace.Enums;

namespace PizzaPlace.Models
{
    public class Pizza(int id, string name, decimal price, Spiciness spiciness)
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public decimal Price { get; } = price;
        public Spiciness Spiciness { get; } = spiciness;
    }
}
