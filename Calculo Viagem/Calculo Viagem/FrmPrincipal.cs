using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Viagem
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ckGastosPedagio_CheckedChanged(object sender, EventArgs e)
        {
            lbPedagio.Visible = txtPedagio.Visible = ckGastosPedagio.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try 
            {
                float distancia, consumo, combustivel, pedagio;

                distancia = float.Parse(txtDistancia.Text);
                consumo = float.Parse(txtConsumo.Text);
                combustivel = float.Parse(txtCombustivel.Text);
                pedagio = ckGastosPedagio.Checked ? float.Parse(txtPedagio.Text) : 0;
                          
           
            }
            catch (Exception) 
            {
                MessageBox.Show("Ops... algo deu errado");
            
            }
        }
    }
}
