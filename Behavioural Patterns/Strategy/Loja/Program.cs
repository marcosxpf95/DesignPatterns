using System;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra compraNatal = new Compra(new DescontoNatal());
            Compra compraPascoa = new Compra(new DescontoPascoa());

            Console.WriteLine("Valor da compra:");
            double valorCompra = Convert.ToDouble(Console.ReadLine());

            compraNatal.setValor(valorCompra);
            compraPascoa.setValor(valorCompra);

            Console.WriteLine($"Valor final da compra com desconto no Natal: R${compraNatal.obterValorFinal()}");
            Console.WriteLine($"Valor final da compra com desconto na Pascoa: R${compraPascoa.obterValorFinal()}");

        }
    }
}
