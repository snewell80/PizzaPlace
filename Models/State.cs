namespace PizzaPlace.Models
{
    public class State
    {
        public Menu Menu { get; } = new Menu();
        public ShoppingCart ShoppingCart { get; } = new ShoppingCart();
        public UI UI { get; } = new UI();

        public decimal TotalPrice => ShoppingCart.Orders.Sum(id => Menu.GetPizza(id)!.Price);
    }
}
