using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Singletons
{
    public class PizzaSingleton
    {
        public List<APizza> Pizzas { get; set; }

        public PizzaSingleton()
        {
            Pizzas = new List<APizza>
            {
                new CheesePizza()
            };
        }
    }
}