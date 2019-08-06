using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimdexxSystem
{
    public partial class ConsultarCep : Form
    {
        public ConsultarCep()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())

                try
                {
                        var endereco = ws.consultaCEP(txtCEP.Text.Trim());
                        TxtEstado.Text = endereco.uf;
                        TxtCidade.Text = endereco.cidade;
                        TxtBairro.Text = endereco.bairro;
                        txtRua.Text = endereco.end;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP VAlido.", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCEP.Text = "";
            TxtEstado.Text = "";
            TxtCidade.Text = "";
            TxtBairro.Text = "";
            txtRua.Text = "";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
