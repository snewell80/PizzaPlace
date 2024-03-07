namespace PizzaPlace.Models
{
    public class ShoppingCart
    {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = [];
        public bool HasPaid { get; set; }

        public void Add(int id) => Orders.Add(id);
        public void RemoveAt(int pos) => Orders.RemoveAt(pos);
    }
}
