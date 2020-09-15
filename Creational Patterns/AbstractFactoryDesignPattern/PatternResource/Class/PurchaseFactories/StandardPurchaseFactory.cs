namespace AbstractFactoryDesignPattern.PatternClass
{
    public class StandardPurchaseFactory : PurchaseFactory
    {
        public override DeliveryDocument CreateDeliveryDocument()
        {
            return new PostalLabel();
        }

        public override Packaging CreatePackaging()
        {
            return new StandardPackaging();
        }
    }
}