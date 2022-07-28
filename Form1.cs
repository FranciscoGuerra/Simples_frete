using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFrete
{
    public partial class FrmPrincipal : Form

    {
        float kmRodados = 0;
        float ValorCombustivel = 0;
        float regraDeNegocio = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ttxVeiculo_Leave(object sender, EventArgs e)
        {
            txtVeiculo.Text.ToLower().Trim();

            if (txtVeiculo.Text == "carro")
            {
                ImgVeiculos.Image = CalcularFrete.Properties.Resources.carro;
            }
            else if (txtVeiculo.Text == "caminhão")
            {
                ImgVeiculos.Image = CalcularFrete.Properties.Resources.caminhão;

            }
            else if (txtVeiculo.Text == "camin~hao")
            {
                ImgVeiculos.Image = CalcularFrete.Properties.Resources.caminhão;
            }

            else if (txtVeiculo.Text == "moto")
            {
                ImgVeiculos.Image = CalcularFrete.Properties.Resources.moto;
            }
            else
            {
                txtVeiculo.Text = "";
                txtVeiculo.Focus(); return;
            }


        }

        private void txtVeiculo_TextChanged(object sender, EventArgs e)
        {
            txtVeiculo.Text = txtVeiculo.Text;
            


        }

        private void btnConfirmar_Click(object sender, EventArgs e)

        {
            kmRodados = float.Parse(txtDistanciaKm.Text);
            txtVeiculo.Text.ToLower().Trim();
            if (checkBox1IdaVolta.Checked)
            {
                kmRodados = kmRodados * 2;
            }

            ValorCombustivel = float.Parse(txtValorCombustivel.Text);


            switch (txtVeiculo.Text)
            {
                case "carro":

                    {
                        Carro car = new Carro();

                        string DesCombustiveis = car.Calcular(kmRodados,ValorCombustivel).ToString();
                        txtKmRodados.Text = kmRodados.ToString();

                        txtConsumoCombustivel.Text = (kmRodados / 12, "litros ").ToString();
                        txtDespesasCombustivel.Text = ("R$:" + DesCombustiveis);

                        float dp = Convert.ToSingle(DesCombustiveis);
                        regraDeNegocio = Convert.ToSingle(comboTabela.Text);
                        txtTotal.Text = (dp * regraDeNegocio).ToString();

                        dp = dp / kmRodados;
                        txtCustoPorKm.Text = dp.ToString();
                       

                        return;
                    }

                case "moto":

                    {
                        Moto m = new Moto();
                        string DesCombustiveis = m.Calcular(kmRodados, ValorCombustivel).ToString();
                        txtKmRodados.Text = kmRodados.ToString();

                        txtConsumoCombustivel.Text = (kmRodados / 35, "litros ").ToString();
                        txtDespesasCombustivel.Text = ("R$:" + DesCombustiveis);

                        float dp = Convert.ToSingle(DesCombustiveis);
                        txtTotal.Text = (dp * 3).ToString();

                        dp = dp / kmRodados;
                        txtCustoPorKm.Text = dp.ToString();
                        return;

                    }
                default:
                    {
                        Caminhao c = new Caminhao();
                        string DesCombustiveis = c.Calcular(kmRodados, ValorCombustivel).ToString();
                        txtKmRodados.Text = kmRodados.ToString();

                        txtConsumoCombustivel.Text = (kmRodados / 3.5, "litros ").ToString();
                        txtDespesasCombustivel.Text = ("R$:" + DesCombustiveis);

                        float dp = Convert.ToSingle(DesCombustiveis);
                        txtTotal.Text = (dp * 3).ToString();

                        dp = dp / kmRodados;
                        txtCustoPorKm.Text = dp.ToString();
                        return;

                    }

            }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
