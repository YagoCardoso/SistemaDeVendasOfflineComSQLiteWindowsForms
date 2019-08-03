using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void GridVendaRealizada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            string texto = "Deseja realmente Excluir?";
            string titulo = " Excluir";

            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {




                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("delete from VENDA where SEQCAIXA=@cod", sql);

                command.Parameters.Add("@cod", SqlDbType.Int).Value = TXT_COD.Text;

                try
                {
                    sql.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show(" Excluido com Sucesso!", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXT_COD.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                }
            }
        }

        private void TXT_COD_TextChanged(object sender, EventArgs e)
        {
            //TXT_COD.Text = "";
        }

        private void TXT_COD_Click(object sender, EventArgs e)
        {
            TXT_COD.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            // worksheet = workbook.Sheets["novo"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i < GridVendaRealizada.Columns.Count + 1; i++)
            {
                worksheet.Cells[i, 1] = GridVendaRealizada.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < GridVendaRealizada.Rows.Count; i++)
            {
                for (int j = 0; j < GridVendaRealizada.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = GridVendaRealizada.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Vendas";
            saveFileDialoge.DefaultExt = ".xlsx";

            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    }
}
