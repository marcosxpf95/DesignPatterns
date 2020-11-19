using System;
using System.Collections.Generic;
using System.Text;

namespace Loja
{
    public class Compra
    {
        private Desconto desconto { get; set; }
        public double valor { get; set; }

        public Compra() { }

        public Compra(Desconto desconto)
        {
            this.desconto = desconto;
            this.valor = 0;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public double obterValorFinal()
        {
            return desconto.aplicarDesconto(this.valor);
        }
    }
}
