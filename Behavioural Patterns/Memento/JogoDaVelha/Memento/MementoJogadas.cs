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

        public MementoJogadas(Jogadas jogadas)
        {
            mementoJogadas = new Dictionary<string, string>();

            foreach (var key in jogadas._jogadas.Keys)
            {
                mementoJogadas.Add(key, jogadas._jogadas[key]);
            }
        }
    }
}
