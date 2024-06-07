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

        private void EventoConsultarCepClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())

                try
                {
                        var endereco = ws.consultaCEP(txtCep.Text.Trim());
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
                MessageBox.Show("Informe um CEP válido.", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void EventoLimparClick(object sender, EventArgs e)
        {
            txtCep.Text = String.Empty;
            TxtEstado.Text = String.Empty;
            TxtCidade.Text = String.Empty;
            TxtBairro.Text = String.Empty;
            txtRua.Text = String.Empty;
        }

        private void EventoSairClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
