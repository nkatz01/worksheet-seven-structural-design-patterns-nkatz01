namespace Decorator
{
    public class SimplyVegPizza : IPizza
    {
      
        public SimplyVegPizza() //:base(description, price)
        {
            Description = "SimplyVegPizza";
            Price = 230;
        }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
           return $"Desc: {Description} ({Price}),";
        }
    }
}

/*
 * Desc: SimplyVegPizza (230), Roma Tomatoes (5.20), Green Olives (5.47), Spinach (7.92)
Price: 248.59
Desc: SimplyNonVegPizza (350), Meat (14.25), Cheese (20.72), Cheese (20.72), Ham (18.12)
Price: 423.81
*/