using System;

namespace Bridge
{
    internal class BigWheel : Car
    {
       

        public BigWheel(IProduct product, string v) : base(product, v)
        {
          
        }

        public override void ProduceProduct()
        {

            _product.Produce();
            Console.WriteLine($"Modifying product {_product.ProductName} for {_carType}");

        }

        public override void Assemble()
        {
            Console.WriteLine($"Assembling {_product.ProductName} according to {_carType}");

        }

        public override string ToString()
        {
            return base.ToString();  
        }
    }
}