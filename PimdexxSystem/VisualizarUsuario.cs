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

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            // worksheet = workbook.Sheets["novo"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i < GridVisualizarUsuario.Columns.Count + 1; i++)
            {
                worksheet.Cells[i, 1] = GridVisualizarUsuario.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < GridVisualizarUsuario.Rows.Count; i++)
            {
                for (int j = 0; j < GridVisualizarUsuario.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = GridVisualizarUsuario.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Usuarios";
            saveFileDialoge.DefaultExt = ".xlsx";

            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    }
}
