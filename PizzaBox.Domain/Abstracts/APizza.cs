namespace PizzaBox.Domain.Abstracts
{
    public abstract class APizza
    {
        public string Topping1 { get; protected set; }

        public override string ToString()
        {
            return Topping1;
        }
    }
}