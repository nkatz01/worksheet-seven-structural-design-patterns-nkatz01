namespace Adapter
{
<<<<<<< HEAD
    public class XpayImpl : IXPay
=======
    public class XpayImpl: IXPay
>>>>>>> c34d4679353e3699330b2f96908bfd4fb7cf2d89
    {
        public string CreditCardNo { get; set; }
        public string CustomerName { get; set; }
        public string CardExpMonth { get; set; }
        public string CardExpYear { get; set; }
        public short CardCvvNo { get; set; }
        public double Amount { get; set; }
    }
}