using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Exercicio_1
{
    public class Celcius : IMedidor
    {
        public double MedirTemperatura()
        {            
            return new Random().NextDouble();        
        }
    }
}
