namespace Decorator
{
    public class Ham :   PizzaDecorator
    {
        public Ham(IPizza pizza) : base(pizza)
        {
            Description = "Ham";
            Price = 5.47M;
        }



        public override string ToString()
        {
            return base.ToString() + $" {Description}, ({Price})";
        }
    }
}