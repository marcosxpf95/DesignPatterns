using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class CareTakerContaBancaria
    {
        private List<MementoContaBancaria> mementosContaBancaria = new List<MementoContaBancaria>();

        public void Add(MementoContaBancaria mementoContaBancaria)
        {
            mementosContaBancaria.Add(mementoContaBancaria);
        }

        public MementoContaBancaria Get(int index = -1)
        {
            if (index < 0)
                index = mementosContaBancaria.Count - 1;

            return mementosContaBancaria[index];
        }
    }
}
