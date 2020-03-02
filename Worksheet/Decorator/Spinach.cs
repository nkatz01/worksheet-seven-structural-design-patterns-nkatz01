namespace Decorator
{
    public class Spinach : IPizza
    {
        public Spinach(IPizza pizza)
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