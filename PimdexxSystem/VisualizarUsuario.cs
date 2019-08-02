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
    public partial class VisualizarUsuario : Form
    {
        public VisualizarUsuario()
        {
            InitializeComponent();
        }

        private void VisualizarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet9.USUARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.uSUARIOTableAdapter.Fill(this.systemOrangeDataSet9.USUARIO);

        }
    }
}
