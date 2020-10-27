using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria("Marcos", 100, $"\nHistórico:\nDeposito R$100 {DateTime.Now}\n");
            CareTakerContaBancaria careTaker = new CareTakerContaBancaria();
            careTaker.Add(contaBancaria.CreateMementoContaBancaria());

            contaBancaria.SetValor(50);
            contaBancaria.SetHistorico("Saldo alterado para R$50,00");
            careTaker.Add(contaBancaria.CreateMementoContaBancaria());

            contaBancaria.SetValor(300);
            contaBancaria.SetHistorico("Saldo alterado para R$300,00");
            careTaker.Add(contaBancaria.CreateMementoContaBancaria());
           
            contaBancaria.SetValor(1000);
            contaBancaria.SetHistorico("Saldo alterado para R$1000,00");
            careTaker.Add(contaBancaria.CreateMementoContaBancaria());

            contaBancaria.SetMemento(careTaker.Get(2));

            Console.WriteLine($"Titular: {contaBancaria.Titular} \nValor: R${contaBancaria.Valor}\n{contaBancaria.Historico}");
            Console.Read();

        }
    }
}
