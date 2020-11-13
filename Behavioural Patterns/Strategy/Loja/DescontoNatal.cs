using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
    public class DescontoNatal : Desconto
    {
        public double aplicarDesconto(double valorCompra)
        {
            return valorCompra -= valorCompra * 0.1;
        }
    }
}
