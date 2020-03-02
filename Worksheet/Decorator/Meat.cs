namespace Decorator
{
    public class Meat : IPizza
    {
        public Meat(IPizza pizza)
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