using JogoDaVelha.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Jogadas
    {
        public Dictionary<string, string> _jogadas { get; private set; }

        public Jogadas()
        {
            _jogadas = new Dictionary<string, string>();
        }

        public void SetJogadas(string label, string jogador)
        {
            if (!_jogadas.ContainsKey(label))
                _jogadas.Add(label, jogador);
        }

        public MementoJogadas CreateMementoJogadas()
        {
            return (new MementoJogadas(this));
        }

        public void SetMemento(MementoJogadas memento)
        {
            this._jogadas = memento.mementoJogadas;
        }
    }
}
