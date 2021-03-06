namespace Decorator
{
    public class GreenOlives : PizzaDecorator
    {
        public GreenOlives(IPizza pizza) : base(pizza)
        {
            Description = "GreenOlives";
            Price = 5.47M;
        }

       

        public override string ToString()
        {
            return base.ToString() + $" {Description}, ({Price})";
        }
    }
}