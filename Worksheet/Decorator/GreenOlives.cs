namespace Decorator
{
    public class GreenOlives : IPizza
    {
        public GreenOlives(IPizza pizza)
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