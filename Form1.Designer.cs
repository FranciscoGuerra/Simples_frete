namespace CalcularFrete
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValorCombustivel = new System.Windows.Forms.TextBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtConsumoCombustivel = new System.Windows.Forms.TextBox();
            this.txtDespesasCombustivel = new System.Windows.Forms.TextBox();
            this.comboTabela = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1IdaVolta = new System.Windows.Forms.CheckBox();
            this.txtDistanciaKm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustoPorKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKmRodados = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboVeiculos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ImgVeiculos = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(47, 248);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(155, 44);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(436, 393);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(137, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // txtValorCombustivel
            // 
            this.txtValorCombustivel.Location = new System.Drawing.Point(52, 111);
            this.txtValorCombustivel.Name = "txtValorCombustivel";
            this.txtValorCombustivel.Size = new System.Drawing.Size(122, 20);
            this.txtValorCombustivel.TabIndex = 4;
            this.txtValorCombustivel.TextChanged += new System.EventHandler(this.txtValorCombustivel_TextChanged);
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(207, 47);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(136, 20);
            this.txtLocalidade.TabIndex = 2;
            // 
            // txtConsumoCombustivel
            // 
            this.txtConsumoCombustivel.Location = new System.Drawing.Point(99, 328);
            this.txtConsumoCombustivel.Name = "txtConsumoCombustivel";
            this.txtConsumoCombustivel.Size = new System.Drawing.Size(122, 20);
            this.txtConsumoCombustivel.TabIndex = 6;
            this.txtConsumoCombustivel.TextChanged += new System.EventHandler(this.txtConsumoCombustivel_TextChanged);
            // 
            // txtDespesasCombustivel
            // 
            this.txtDespesasCombustivel.Location = new System.Drawing.Point(254, 328);
            this.txtDespesasCombustivel.Name = "txtDespesasCombustivel";
            this.txtDespesasCombustivel.Size = new System.Drawing.Size(136, 20);
            this.txtDespesasCombustivel.TabIndex = 7;
            this.txtDespesasCombustivel.TextChanged += new System.EventHandler(this.txtDespesasCombustivel_TextChanged);
            // 
            // comboTabela
            // 
            this.comboTabela.FormattingEnabled = true;
            this.comboTabela.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboTabela.Location = new System.Drawing.Point(207, 111);
            this.comboTabela.Name = "comboTabela";
            this.comboTabela.Size = new System.Drawing.Size(136, 21);
            this.comboTabela.TabIndex = 5;
            this.comboTabela.SelectedIndexChanged += new System.EventHandler(this.comboTabela_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor do Combustivel";
            // 
            // checkBox1IdaVolta
            // 
            this.checkBox1IdaVolta.AutoSize = true;
            this.checkBox1IdaVolta.Location = new System.Drawing.Point(375, 114);
            this.checkBox1IdaVolta.Name = "checkBox1IdaVolta";
            this.checkBox1IdaVolta.Size = new System.Drawing.Size(70, 17);
            this.checkBox1IdaVolta.TabIndex = 11;
            this.checkBox1IdaVolta.Text = "Ida/Volta";
            this.checkBox1IdaVolta.UseVisualStyleBackColor = true;
            // 
            // txtDistanciaKm
            // 
            this.txtDistanciaKm.Location = new System.Drawing.Point(375, 47);
            this.txtDistanciaKm.Name = "txtDistanciaKm";
            this.txtDistanciaKm.Size = new System.Drawing.Size(137, 20);
            this.txtDistanciaKm.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Distância Km";
            // 
            // txtCustoPorKm
            // 
            this.txtCustoPorKm.Location = new System.Drawing.Point(254, 393);
            this.txtCustoPorKm.Name = "txtCustoPorKm";
            this.txtCustoPorKm.Size = new System.Drawing.Size(136, 20);
            this.txtCustoPorKm.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Consumo de Combustivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Localidade:";
            // 
            // txtKmRodados
            // 
            this.txtKmRodados.Location = new System.Drawing.Point(99, 393);
            this.txtKmRodados.Name = "txtKmRodados";
            this.txtKmRodados.Size = new System.Drawing.Size(122, 20);
            this.txtKmRodados.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veiculo: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.comboVeiculos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkBox1IdaVolta);
            this.panel1.Controls.Add(this.comboTabela);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDistanciaKm);
            this.panel1.Controls.Add(this.txtLocalidade);
            this.panel1.Controls.Add(this.txtValorCombustivel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(47, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 200);
            this.panel1.TabIndex = 17;
            // 
            // comboVeiculos
            // 
            this.comboVeiculos.FormattingEnabled = true;
            this.comboVeiculos.Items.AddRange(new object[] {
            "Moto",
            "Carro",
            "Caminhão"});
            this.comboVeiculos.Location = new System.Drawing.Point(51, 47);
            this.comboVeiculos.Name = "comboVeiculos";
            this.comboVeiculos.Size = new System.Drawing.Size(121, 21);
            this.comboVeiculos.TabIndex = 21;
            this.comboVeiculos.SelectedIndexChanged += new System.EventHandler(this.comboVeiculos_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalcularFrete.Properties.Resources.icone2;
            this.pictureBox1.Location = new System.Drawing.Point(546, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Regras de Negocio";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Despesas de Combustivel ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "KM Rodados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Custos por KM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "TOTAL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(370, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 33);
            this.label11.TabIndex = 24;
            this.label11.Text = "Calcular Frete";
            // 
            // ImgVeiculos
            // 
            this.ImgVeiculos.Location = new System.Drawing.Point(596, 267);
            this.ImgVeiculos.Name = "ImgVeiculos";
            this.ImgVeiculos.Size = new System.Drawing.Size(330, 194);
            this.ImgVeiculos.TabIndex = 25;
            this.ImgVeiculos.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 497);
            this.Controls.Add(this.ImgVeiculos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustoPorKm);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConsumoCombustivel);
            this.Controls.Add(this.txtKmRodados);
            this.Controls.Add(this.txtDespesasCombustivel);
            this.Controls.Add(this.txtTotal);
            this.Name = "FrmPrincipal";
            this.Text = "Calcular Frete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValorCombustivel;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtConsumoCombustivel;
        private System.Windows.Forms.TextBox txtDespesasCombustivel;
        private System.Windows.Forms.ComboBox comboTabela;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1IdaVolta;
        private System.Windows.Forms.TextBox txtDistanciaKm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustoPorKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKmRodados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ImgVeiculos;
        private System.Windows.Forms.ComboBox comboVeiculos;
    }
}

