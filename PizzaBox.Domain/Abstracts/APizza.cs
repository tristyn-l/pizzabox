using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    /// <summary>
    /// each pizza must be able to have a crust
    /// each pizza must be able to have a size
    /// each pizza must be able to have toppings
    /// each pizza must be able to compute its pricing
    /// each pizza must have no less than 2 default toppings
    /// each pizza must have no more than 5 total toppings
    /// </summary>
    public abstract class APizza
    {
        public Crust Crust { get; set; }
        public Size Size { get; set; }
        public List<Topping> Toppings { get; set; }

        public APizza()
        {
            FactoryMethod();
        }

        private void FactoryMethod()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }

        protected abstract void AddCrust();
        protected abstract void AddSize();
        protected abstract void AddToppings();
    }
}