using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class MementoContaBancaria
    {
        public double Valor { get; private set; }
        public string Historico { get; private set; }
        public MementoContaBancaria(ContaBancaria contaBancaria)
        {
            this.Valor = contaBancaria.Valor;
            this.Historico = contaBancaria.Historico;
        }
    }
}
