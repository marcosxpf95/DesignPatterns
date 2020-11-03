using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Memento
{
    public class CareTakerJogadas
    {
        public List<MementoJogadas> mementosJogadas = new List<MementoJogadas>();

        public void Add(MementoJogadas mementoJogadas)
        {
            mementosJogadas.Add(mementoJogadas);
        }

        public MementoJogadas Get(int index = -1, bool descartarJogada = true)
        {
            if (index < 0)
                index = mementosJogadas.Count - 1;
            
            var mementoJogada = mementosJogadas[index];

            if (descartarJogada)
                mementosJogadas.Remove(mementoJogada);

            return mementoJogada;
        }
    }
}
