using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Memento
{
    public class MementoJogadas
    {
        public Dictionary<string, string> mementoJogadas { get; private set; }
        public bool jogadaPar { get; private set; }

        public MementoJogadas(Jogadas jogadas)
        {
            jogadaPar = jogadas.jogadarPar;
            mementoJogadas = new Dictionary<string, string>();

            foreach (var key in jogadas.jogadas.Keys)
            {
                mementoJogadas.Add(key, jogadas.jogadas[key]);
            }
        }
    }
}
