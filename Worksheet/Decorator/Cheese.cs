namespace Decorator
{
    public class Cheese : IPizza
    {
        public Cheese(IPizza pizza)
        {
            throw new System.NotImplementedException();
        }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}