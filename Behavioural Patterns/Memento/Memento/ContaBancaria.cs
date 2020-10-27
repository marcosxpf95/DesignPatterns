using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class ContaBancaria
    {
        public ContaBancaria(string titular, double valor, string historico)
        {
            this.Titular = titular;
            this.Valor = valor;
            this.Historico = historico;
        }

        public string Titular { get; private set; }
        public double Valor { get; private set; }
        public string Historico { get; private set; }

        public void SetTitular(string titular)
        {
            this.Titular = titular;
        }

        public void SetValor(double valor)
        {
            this.Valor = valor;
        }

        public void SetHistorico(string historico)
        {
            this.Historico += $"{historico} {DateTime.Now}\n";
        }

        public MementoContaBancaria CreateMementoContaBancaria()
        {
            return (new MementoContaBancaria(this));
        }

        public void SetMemento(MementoContaBancaria memento)
        {
            this.Valor = memento.Valor;
            this.Historico = memento.Historico;
        }
    }
}
