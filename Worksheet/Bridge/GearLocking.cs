namespace Bridge
{
    public class GearLocking : IProduct
    {
        public GearLocking(string name)
        {
        }

        public string ProductName { get; set; }

        public void Produce()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}