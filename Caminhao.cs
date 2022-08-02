using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFrete
{
    internal class Caminhao
    {
        public float Calcular(float distancia, float MediaCombustivel, float precoCombustivel)
        {
            MediaCombustivel = (float)(distancia / 3.5);
            precoCombustivel = precoCombustivel * MediaCombustivel;
            return MediaCombustivel;
        }
    }
}
