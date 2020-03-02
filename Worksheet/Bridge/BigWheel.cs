using System;

namespace Bridge
{
    internal class BigWheel : Car
    {
        private IProduct _product;
        private string _v;

        public BigWheel(IProduct product, string v) : base(product, v)
        {
            _product = product;
            _v = v;
        }

        public override void ProduceProduct()
        {
            throw new NotImplementedException();
        }

        public override void Assemble()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}