namespace LocalizadorDeCEP
{
    partial class Form1
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
            this.txbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblRegiao = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lbllogradouro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbCEP
            // 
            this.txbCEP.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCEP.Location = new System.Drawing.Point(95, 146);
            this.txbCEP.Margin = new System.Windows.Forms.Padding(4);
            this.txbCEP.Mask = "00000-000";
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(352, 32);
            this.txbCEP.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(140, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(314, 45);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Localizador de CEP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocalizadorDeCEP.Properties.Resources.Osullivanluke_Orb_Os_X_Maps_512;
            this.pictureBox1.Location = new System.Drawing.Point(34, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(34, 210);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(457, 47);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar CEP";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grbResultado
            // 
            this.grbResultado.Controls.Add(this.lblDDD);
            this.grbResultado.Controls.Add(this.lblRegiao);
            this.grbResultado.Controls.Add(this.lblEstado);
            this.grbResultado.Controls.Add(this.lblUF);
            this.grbResultado.Controls.Add(this.lblLocalidade);
            this.grbResultado.Controls.Add(this.lblBairro);
            this.grbResultado.Controls.Add(this.lblUnidade);
            this.grbResultado.Controls.Add(this.lblComplemento);
            this.grbResultado.Controls.Add(this.lbllogradouro);
            this.grbResultado.Controls.Add(this.lblCEP);
            this.grbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResultado.Location = new System.Drawing.Point(518, 23);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(540, 254);
            this.grbResultado.TabIndex = 4;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Resultado";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(23, 224);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(49, 20);
            this.lblDDD.TabIndex = 9;
            this.lblDDD.Text = "DDD:";
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.Location = new System.Drawing.Point(24, 203);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(64, 20);
            this.lblRegiao.TabIndex = 8;
            this.lblRegiao.Text = "Região:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(23, 178);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(24, 157);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(35, 20);
            this.lblUF.TabIndex = 6;
            this.lblUF.Text = "UF:";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(24, 136);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(90, 20);
            this.lblLocalidade.TabIndex = 5;
            this.lblLocalidade.Text = "Localidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(23, 115);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(23, 94);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(73, 20);
            this.lblUnidade.TabIndex = 3;
            this.lblUnidade.Text = "Unidade:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(23, 73);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(112, 20);
            this.lblComplemento.TabIndex = 2;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lbllogradouro
            // 
            this.lbllogradouro.AutoSize = true;
            this.lbllogradouro.Location = new System.Drawing.Point(23, 52);
            this.lbllogradouro.Name = "lbllogradouro";
            this.lbllogradouro.Size = new System.Drawing.Size(89, 20);
            this.lbllogradouro.TabIndex = 1;
            this.lbllogradouro.Text = "logradouro:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(23, 32);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(45, 20);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 289);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbCEP);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Localizador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbResultado.ResumeLayout(false);
            this.grbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txbCEP;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lbllogradouro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblRegiao;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUF;
    }
}
