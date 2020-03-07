namespace Decorator
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(IPizza pizza) : base(pizza)
        {
            Description = "Cheese";
            Price = 20.72M;
        }

        

        public override string ToString()
        {
            return base.ToString() + $" {Description}, ({Price})";
        }
    }
}