using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Exercicio_1
{
    public class Farenheit : IMedidor
    {
        MedidorFarenheit _medidorFarenheit;
        public Farenheit(MedidorFarenheit medidorFarenheit)
        {
            this._medidorFarenheit = medidorFarenheit;
        }
        public double MedirTemperatura()
        {
            return _medidorFarenheit.getTemperaturaFarenheit();
        }
    }
}
