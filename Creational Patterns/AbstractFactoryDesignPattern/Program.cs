using System;
using AbstractFactoryDesignPattern.PatternClass;

namespace AbstractFactoryDesignPattern 
{
    class Program 
    {
        static void Main (string[] args) 
        {
            PurchaseFactory spf = new StandardPurchaseFactory();
            Client standard = new Client(spf);
            Console.WriteLine(standard.ClientPackaging.GetType());
            Console.WriteLine(standard.ClientDocument.GetType());
            
            PurchaseFactory cpf = new DelicatePurchaseFactory();
            Client delicate = new Client(cpf);
            Console.WriteLine(delicate.ClientPackaging.GetType());
            Console.WriteLine(delicate.ClientDocument.GetType());
        }
    }
}