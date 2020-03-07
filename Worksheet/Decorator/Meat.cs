namespace Decorator
{
    public class Meat  : PizzaDecorator
    {
        public Meat(IPizza pizza) : base(pizza)
        {
            Description = "Meat";
            Price = 18.12M;
        }

       

        public override string ToString()
        {
            return base.ToString() + $" {Description}, ({Price})";
        }
    }
}