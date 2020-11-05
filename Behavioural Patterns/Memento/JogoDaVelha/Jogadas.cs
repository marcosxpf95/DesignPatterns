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
        public Dictionary<string, string> jogadas { get; private set; }
        public bool jogadarPar { get; private set; }

        public Jogadas()
        {
            jogadas = new Dictionary<string, string>();
            jogadarPar = true;
        }

        public void SetJogadas(string label, string jogador)
        {
            if (!jogadas.ContainsKey(label))
                jogadas.Add(label, jogador);

            jogadarPar = !jogadarPar;
        }

        public MementoJogadas CreateMementoJogadas()
        {
            return (new MementoJogadas(this));
        }

        public void SetMemento(MementoJogadas memento)
        {
            this.jogadas = memento.mementoJogadas;
            this.jogadarPar = memento.jogadaPar;
        }
    }
}
