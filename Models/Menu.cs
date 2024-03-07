namespace PizzaPlace.Models
{
    public class Menu
    {
        public List<Pizza> PizzaList { get; set; } = [];

        public Pizza? GetPizza(int id) => PizzaList.SingleOrDefault(pizza => pizza.Id == id);
        public void Add(Pizza pizza) =>PizzaList.Add(pizza);
    }
}
