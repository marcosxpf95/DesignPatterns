using Adapter.Exercicio_1;
using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            MedidorFarenheit medidorFarenheit = new MedidorFarenheit();

            IMedidor celcius = new Celcius();
            IMedidor farenheit = new Farenheit(medidorFarenheit);

            Console.WriteLine($"Temperatura em celcius: {celcius.MedirTemperatura()} °F");
            Console.WriteLine($"Temperatura em farenheit: {farenheit.MedirTemperatura()} °C");
        }
    }
}
