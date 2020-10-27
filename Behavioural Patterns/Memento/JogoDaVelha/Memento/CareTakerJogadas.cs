using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Memento
{
    public class CareTakerJogadas
    {
        private List<MementoJogadas> mementosJogadas = new List<MementoJogadas>();

        public void Add(MementoJogadas mementoJogadas)
        {
            mementosJogadas.Add(mementoJogadas);
        }

        public MementoJogadas Get(int index = -1)
        {
            if (index < 0)
                index = mementosJogadas.Count - 1;

            return mementosJogadas[index];
        }
    }
}
