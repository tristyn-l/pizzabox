using System;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayWithStore();
        }

        public static void PlayWithStore() 
        {
            var pizzaSingleton = new PizzaSingleton();

            foreach(var store in StoreSingleton.Instance.Stores)
            {
                Console.WriteLine(store);
            }

            // foreach(var pizza in pizzaSingleton.Pizzas)
            // {
            //     Console.WriteLine(pizza);
            // }
        }
    }
}
