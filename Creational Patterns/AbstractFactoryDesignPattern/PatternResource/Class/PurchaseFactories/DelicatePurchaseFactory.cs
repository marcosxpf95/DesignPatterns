namespace AbstractFactoryDesignPattern.PatternClass
{
    public class DelicatePurchaseFactory : PurchaseFactory
    {
        public override DeliveryDocument CreateDeliveryDocument()
        {
            return new CourierManifest();
        }

        public override Packaging CreatePackaging()
        {
            return new ShockProofPackaging();
        }
    }
}