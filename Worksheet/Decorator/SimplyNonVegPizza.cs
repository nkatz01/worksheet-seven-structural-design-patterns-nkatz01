namespace Decorator
{
    public class SimplyNonVegPizza : IPizza
    {
        public SimplyNonVegPizza()// :base(description, price) { }
        {
            Description = "SimplyNonVegPizza";
            Price = 350;
        }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"Desc: {Description} ({Price}),";
        }
    }
}