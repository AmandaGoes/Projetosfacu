namespace Calculo_Viagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.lbCombustivel = new System.Windows.Forms.Label();
            this.lbPedagio = new System.Windows.Forms.Label();
            this.ckGastosPedagio = new System.Windows.Forms.CheckBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtPedagio = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.ld = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(43, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(43, 112);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.BackColor = System.Drawing.Color.Transparent;
            this.lbDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistancia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDistancia.Location = new System.Drawing.Point(130, 54);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(210, 24);
            this.lbDistancia.TabIndex = 4;
            this.lbDistancia.Text = "Distância a percorrer:";
            // 
            // lbConsumo
            // 
            this.lbConsumo.AutoSize = true;
            this.lbConsumo.BackColor = System.Drawing.Color.Transparent;
            this.lbConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbConsumo.Location = new System.Drawing.Point(130, 123);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(272, 24);
            this.lbConsumo.TabIndex = 5;
            this.lbConsumo.Text = "Consumo médio do veículo:";
            // 
            // lbCombustivel
            // 
            this.lbCombustivel.AutoSize = true;
            this.lbCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCombustivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCombustivel.Location = new System.Drawing.Point(130, 193);
            this.lbCombustivel.Name = "lbCombustivel";
            this.lbCombustivel.Size = new System.Drawing.Size(231, 24);
            this.lbCombustivel.TabIndex = 6;
            this.lbCombustivel.Text = "Valor do comustível: R$";
            // 
            // lbPedagio
            // 
            this.lbPedagio.AutoSize = true;
            this.lbPedagio.BackColor = System.Drawing.Color.White;
            this.lbPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedagio.ForeColor = System.Drawing.Color.Black;
            this.lbPedagio.Location = new System.Drawing.Point(112, 332);
            this.lbPedagio.Name = "lbPedagio";
            this.lbPedagio.Size = new System.Drawing.Size(280, 24);
            this.lbPedagio.TabIndex = 7;
            this.lbPedagio.Text = "Valor gasto com pedágio: R$";
            this.lbPedagio.Visible = false;
            // 
            // ckGastosPedagio
            // 
            this.ckGastosPedagio.AutoSize = true;
            this.ckGastosPedagio.BackColor = System.Drawing.Color.Transparent;
            this.ckGastosPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGastosPedagio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckGastosPedagio.Location = new System.Drawing.Point(134, 268);
            this.ckGastosPedagio.Name = "ckGastosPedagio";
            this.ckGastosPedagio.Size = new System.Drawing.Size(295, 28);
            this.ckGastosPedagio.TabIndex = 8;
            this.ckGastosPedagio.Text = "Houve gastos com pedágio?";
            this.ckGastosPedagio.UseVisualStyleBackColor = false;
            this.ckGastosPedagio.CheckedChanged += new System.EventHandler(this.ckGastosPedagio_CheckedChanged);
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(180, 411);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(212, 44);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular Despesas";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(346, 51);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 29);
            this.txtDistancia.TabIndex = 10;
            // 
            // txtPedagio
            // 
            this.txtPedagio.BackColor = System.Drawing.Color.White;
            this.txtPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedagio.Location = new System.Drawing.Point(398, 329);
            this.txtPedagio.Name = "txtPedagio";
            this.txtPedagio.Size = new System.Drawing.Size(100, 29);
            this.txtPedagio.TabIndex = 11;
            this.txtPedagio.Visible = false;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustivel.Location = new System.Drawing.Point(367, 190);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(100, 29);
            this.txtCombustivel.TabIndex = 12;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(408, 123);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 29);
            this.txtConsumo.TabIndex = 13;
            // 
            // ld
            // 
            this.ld.AutoSize = true;
            this.ld.BackColor = System.Drawing.Color.Transparent;
            this.ld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ld.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ld.Location = new System.Drawing.Point(444, 54);
            this.ld.Name = "ld";
            this.ld.Size = new System.Drawing.Size(40, 24);
            this.ld.TabIndex = 14;
            this.ld.Text = "Km";
            this.ld.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 524);
            this.Controls.Add(this.ld);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.txtPedagio);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.ckGastosPedagio);
            this.Controls.Add(this.lbPedagio);
            this.Controls.Add(this.lbCombustivel);
            this.Controls.Add(this.lbConsumo);
            this.Controls.Add(this.lbDistancia);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label lbCombustivel;
        private System.Windows.Forms.Label lbPedagio;
        private System.Windows.Forms.CheckBox ckGastosPedagio;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtPedagio;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label ld;
    }
}

