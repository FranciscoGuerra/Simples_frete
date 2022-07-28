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
        public float Calcular(float distancia, float combustivel)

        {
            float media = distancia / 12;
            return combustivel = combustivel * media;

        }

        public void Exibir() 
        {
            FrmPrincipal fp = new FrmPrincipal();

            



        }
    }
}
