namespace Bridge
{
    public class Motoren : Car
    {
        public Motoren(IProduct product, string v) : base(product, v)
        {
        }

        public override void Assemble()
        {
            throw new System.NotImplementedException();
        }

        public override void ProduceProduct()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}