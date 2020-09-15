namespace AbstractFactoryDesignPattern {
    
    //Objeto que representa a compra
    public abstract class PurchaseFactory {
        //Propriedade que representa o empacotamento
        public abstract Packaging CreatePackaging ();
        //Propriedade que representa o envio.
        public abstract DeliveryDocument CreateDeliveryDocument ();
    }
}