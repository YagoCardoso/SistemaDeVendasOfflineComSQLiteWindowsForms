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
    public partial class ConsultarVendas : Form
    {
        public ConsultarVendas()
        {
            InitializeComponent();
        }

        private void ConsultarVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet8.VENDA'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDATableAdapter1.Fill(this.systemOrangeDataSet8.VENDA);
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet7.VENDA'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDATableAdapter.Fill(this.systemOrangeDataSet7.VENDA);

        }
    }
}
