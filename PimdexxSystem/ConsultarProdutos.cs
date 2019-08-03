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
    public partial class ConsultarProdutos : Form
    {
        public ConsultarProdutos()
        {
            InitializeComponent();
        }

        private void ConsultarProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet2.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOTableAdapter.Fill(this.systemOrangeDataSet2.PRODUTO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exportar exp = new Exportar();
            exp.ExportarDataGridViewExcel(GridVisualizarProdutos);
        }
    }
}
