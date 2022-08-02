using System;
using System.Windows.Forms;

namespace CalcularFrete
{
    public partial class FrmPrincipal : Form

    {
        float kmRodados = 0;
        float ValorCombustivel = 0;
        float mediaCombustivel = 0;
        float valorTotal=0;
      
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void exibir()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ttxVeiculo_Leave(object sender, EventArgs e)
        {

        }


        private void btnConfirmar_Click(object sender, EventArgs e)

        {
            kmRodados = float.Parse(txtDistanciaKm.Text);
            ValorCombustivel = float.Parse(txtValorCombustivel.Text);
            



            //Calcular se for ida e volta.
            if (checkBox1IdaVolta.Checked)
            {
                kmRodados = kmRodados * 2;
            }
            // receber o valor do combustivel
            ValorCombustivel = float.Parse(txtValorCombustivel.Text);

            // opções para carro, moto e caminhão
            switch (comboVeiculos.Text)
            {
                case "Moto":

                    {
                        mediaCombustivel = kmRodados / 35;
                        
                        Moto m = new Moto();
                        m.Calcular(kmRodados, mediaCombustivel, ValorCombustivel);
                        Exibir();

                        //txtConsumoCombustivel.Text = ("Litros:"+mediaCombustivel.ToString());
                        //txtDespesasCombustivel.Text = (mediaCombustivel * ValorCombustivel).ToString();
                        //txtKmRodados.Text = ("km:"+kmRodados.ToString());
                        //txtCustoPorKm.Text = ("R$:", kmRodados / (mediaCombustivel * ValorCombustivel)).ToString();


                        ////regra de negocio
                        //// -> valor gasto da viagem- seria uma viagem para a empresa.
                        ////-> multiplica os gastos por 2 - seria uma empresa parceira
                        ////-> multiplica os gastos por 3- seria o valor normal cobrado.
                        //if (comboTabela.SelectedIndex == 0) txtTotal.Text = ("R$", (mediaCombustivel * ValorCombustivel)).ToString();
                        //else if (comboTabela.SelectedIndex == 1) txtTotal.Text = ("R$", (mediaCombustivel * ValorCombustivel) * 2).ToString();

                        //else if (comboTabela.SelectedIndex == 2) txtTotal.Text = ("R$", (+mediaCombustivel * ValorCombustivel) * 3).ToString();
                        return;


                    }

                case "Carro":

                    {
                        mediaCombustivel = kmRodados / 12;
                        Carro car = new Carro();
                        car.Calcular(kmRodados, mediaCombustivel, ValorCombustivel);
                        Exibir();

                        //txtConsumoCombustivel.Text = ("Litros:" +mediaCombustivel.ToString());
                        //txtDespesasCombustivel.Text = ("R$:",mediaCombustivel * ValorCombustivel).ToString();
                        //txtKmRodados.Text = ("km:" + kmRodados.ToString());
                        //txtCustoPorKm.Text = ("R$:" , kmRodados / (mediaCombustivel * ValorCombustivel)).ToString();


                        ////regra de negocio
                        //// -> valor gasto da viagem- seria uma viagem para a empresa.
                        ////-> multiplica os gastos por 2 - seria uma empresa parceira
                        ////-> multiplica os gastos por 3- seria o valor normal cobrado.
                        //if (comboTabela.SelectedIndex == 0) txtTotal.Text = ("R$", (mediaCombustivel * ValorCombustivel)).ToString();
                        //else if (comboTabela.SelectedIndex == 1) txtTotal.Text = ("R$", (mediaCombustivel * ValorCombustivel) * 2).ToString();

                        //else if (comboTabela.SelectedIndex == 2) txtTotal.Text = ("R$", (+mediaCombustivel * ValorCombustivel) * 3).ToString();
                        return;

                    }
                default:
                    {
                        mediaCombustivel =(float)(kmRodados / 3.5);
                        Caminhao c = new Caminhao();
                        c.Calcular(kmRodados, mediaCombustivel, ValorCombustivel);
                        Exibir();

                        //txtConsumoCombustivel.Text = ("Litros:" + mediaCombustivel.ToString());
                        //txtDespesasCombustivel.Text = ("R$:", mediaCombustivel * ValorCombustivel).ToString();
                        //txtKmRodados.Text = ("km:" + kmRodados.ToString());
                        //txtCustoPorKm.Text = ("R$" + kmRodados / (mediaCombustivel * ValorCombustivel)).ToString();


                        //regra de negocio
                        // -> valor gasto da viagem- seria uma viagem para a empresa.
                        //-> multiplica os gastos por 2 - seria uma empresa parceira
                        //-> multiplica os gastos por 3- seria o valor normal cobrado.
                        //if (comboTabela.SelectedIndex == 0) txtTotal.Text = ("R$", (mediaCombustivel * ValorCombustivel)).ToString();
                        //else if (comboTabela.SelectedIndex == 1) txtTotal.Text = ("R$", (mediaCombustivel * ValorCombustivel) * 2).ToString();

                        //else if (comboTabela.SelectedIndex == 2) txtTotal.Text = ("R$", (+mediaCombustivel * ValorCombustivel) * 3).ToString();
                        return;


                    }

            }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboTabela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVeiculos.SelectedIndex == 0)
            {
                ImgVeiculos.Image = CalcularFrete.Properties.Resources.moto;
            }
            else if (comboVeiculos.SelectedIndex == 1)
            {
                ImgVeiculos.Image = CalcularFrete.Properties.Resources.carro;

            }

            else if (comboVeiculos.SelectedIndex == 2)
            {
                ImgVeiculos.Image = CalcularFrete.Properties.Resources.caminhão;
            }
        }

        private void txtConsumoCombustivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorCombustivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDespesasCombustivel_TextChanged(object sender, EventArgs e)
        {

        }

        public void Exibir() 
        {
            txtConsumoCombustivel.Text = ("Litros:" + mediaCombustivel.ToString());
            txtDespesasCombustivel.Text = ("R$:", mediaCombustivel * ValorCombustivel).ToString();
            txtKmRodados.Text = ("km:" + kmRodados.ToString());
            txtCustoPorKm.Text = ("R$" + kmRodados / (mediaCombustivel * ValorCombustivel)).ToString();


            //regra de negocio
            // -> valor gasto da viagem- seria uma viagem para a empresa.
            //-> multiplica os gastos por 2 - seria uma empresa parceira
            //-> multiplica os gastos por 3- seria o valor normal cobrado.
            if (comboTabela.SelectedIndex == 0)
            {
                valorTotal = mediaCombustivel * ValorCombustivel;
                txtCustoPorKm.Text = ("R$",valorTotal/kmRodados).ToString();
                txtTotal.Text = ("R$:",valorTotal).ToString();
            }
               
            else if (comboTabela.SelectedIndex == 1) 
            {
                valorTotal = (mediaCombustivel * ValorCombustivel) * 2;
                txtCustoPorKm.Text = ("R$:",valorTotal / kmRodados).ToString();
                txtTotal.Text = ("R$:",valorTotal).ToString();
            }

            else if (comboTabela.SelectedIndex == 2)
            {
                valorTotal = (mediaCombustivel * ValorCombustivel) * 3;
                txtCustoPorKm.Text = ("R$:", valorTotal / kmRodados).ToString();
                txtTotal.Text = ("R$:", valorTotal).ToString();
            }
    
            return;

        }
    }
}
