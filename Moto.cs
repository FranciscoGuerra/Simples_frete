using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFrete
{
    internal class Moto
    {
        public float Calcular(float distancia, float combustivel)
        {
            combustivel = distancia / 40;
            return combustivel;

        }
    }
}
