using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class CheesePizza : APizza
    {
        public CheesePizza()
        {
            Topping1 = "Cheese";
        }
    }
}