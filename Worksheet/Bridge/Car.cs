using System.Net.Http.Headers;

namespace Bridge
{
    public abstract class Car
    {
        protected IProduct _product { set; get; }
        protected string _carType { set; get; }
        public Car(IProduct product, string carType)
        {
            _product = product;
            _carType = carType;
        }
        
        public abstract void Assemble();
        public abstract void ProduceProduct();

        public override string ToString()
        {
            return $"Car: {_carType}, Product: {_product.ProductName}\n";
        }
    }
}