using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFrete
{
    internal class Caminhao
    {
        public float Calcular(float distancia, float combustivel)
        {
            combustivel = (float)(distancia / 3.5);
            return combustivel;

        }
    }
}
