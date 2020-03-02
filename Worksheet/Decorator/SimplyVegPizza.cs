namespace Decorator
{
    public class SimplyVegPizza : IPizza
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}