using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFrete
{
    internal class Carro 
    {

       
        
        //public float Calcular(float distancia, float combustivel)

        //{
        //    float media = distancia / 12;
        //    return combustivel = combustivel * media;

        //}

        public float Calcular(float distancia, float MediaCombustivel, float precoCombustivel) 
        {
            MediaCombustivel = distancia / 12;
            precoCombustivel = precoCombustivel * MediaCombustivel;
            return MediaCombustivel;
        }
    }
}
