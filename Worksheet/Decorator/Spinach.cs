namespace Decorator
{
    public class Spinach : PizzaDecorator 
    {
        public Spinach(IPizza pizza) : base(pizza)
        {
           Description= "Spinach";
            Price = 7.92M;
        }

      

        public override string ToString()
        {
            return base.ToString() + $" {Description}, ({Price})";
        }
    }
}
