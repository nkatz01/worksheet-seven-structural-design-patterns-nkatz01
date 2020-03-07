namespace Decorator
{
    public class RomaTomatoes : PizzaDecorator
    {
        public RomaTomatoes(IPizza pizza) : base(pizza)
        {
            Description = "RomaTomatoes";
            Price = 5.20M;
        }


        

        public override string ToString()
        {
            return base.ToString() + $" {Description}, ({Price})" ;
        }
    }
}