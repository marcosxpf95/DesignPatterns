using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Adapter.Exercicio_1
{
    public class MedidorFarenheit
    {
        public double getTemperaturaFarenheit()
        {
            //SUPER GAMBIARRA PARA PEGAR A TEMPERATURA EM FARENHEIT!!!!
            return new Random().NextDouble();
        }
    }
}
