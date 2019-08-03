using ExportarDatagridviewToExcel;
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
    public partial class ConsultarUsuario : Form
    {
        public ConsultarUsuario()
        {
            InitializeComponent();
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet12.USUARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.uSUARIOTableAdapter.Fill(this.systemOrangeDataSet12.USUARIO);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exportar exp = new Exportar();
            exp.ExportarDataGridViewExcel(dataGridView1);
        }
    }
}
