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
    public partial class Relatorios : Form 
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet4.RELATORIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.rELATORIOSTableAdapter.Fill(this.systemOrangeDataSet4.RELATORIOS);

        }

        //função que abre novo form dentro do painel do form inicial
       

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_relatorio != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("insert into RELATORIOS(DESCRICAO) values (@varDescricao)", sql);

                command.Parameters.Add("@varDescricao", SqlDbType.Text).Value = txt_relatorio.Text;

                if (txt_relatorio.Text != "")
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Salvo  com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_relatorio.Text = "";

                       
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
                else
                {
                    MessageBox.Show("ATENÇÃO CAMPOS OBRIGATORIOS!", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("ATENÇÃO CAMPOS OBRIGATORIOS!", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_codRelatorio.Text != null && txt_codRelatorio.Text != "")
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("select * from RELATORIOS where SEQRELATORIO=@SEQRELATORIO", sql);

                command.Parameters.Add("@SEQRELATORIO", SqlDbType.BigInt).Value = txt_codRelatorio.Text;


                try
                {
                    sql.Open();
                    SqlDataReader drms = command.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new Exception("Relatório não encontrado");
                    }
                    drms.Read();
                    txt_codRelatorio.Text = Convert.ToString(drms["SEQRELATORIO"]);
                    txt_relatorio.Text = Convert.ToString(drms["DESCRICAO"]);

                    btn_inserir.Enabled = false;

                    btn_alterar.Enabled = true;
                    btn_excluir.Enabled = true;


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
            else { MessageBox.Show("Digite o código do relatório para pesquisar.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_codRelatorio.Text != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("update RELATORIOS  set  DESCRICAO=@descricao where SEQRELATORIO=@SEQRELATORIO ", sql);


                // command.Parameters.Add("@cod", SqlDbType.NVarChar).Value = textBox1.Text;
                command.Parameters.Add("@descricao", SqlDbType.Text).Value = txt_relatorio.Text;
                command.Parameters.Add("@SEQRELATORIO", SqlDbType.BigInt).Value = txt_codRelatorio.Text;




                if (txt_relatorio.Text != "")
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Atualização salva com Sucesso com Sucesso!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_codRelatorio.Text = "";
                        txt_relatorio.Text = "";

                        btn_alterar.Enabled = false;
                        btn_Pesquisar.Enabled = false;
                        btn_excluir.Enabled = false;

                        btn_inserir.Enabled = true;


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
                else
                {
                    MessageBox.Show("ATENÇÃO CAMPOS OBRIGATORIOS!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else { MessageBox.Show("Digite o código do relatório!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = "Deseja realmente Excluir?";
            string titulo = " Excluir";

            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {




                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("delete from RELATORIOS where SEQRELATORIO=@cod", sql);

                command.Parameters.Add("@cod", SqlDbType.Int).Value = txt_codRelatorio.Text;

                try
                {
                    sql.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show(" Excluido com Sucesso!", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_relatorio.Text = "";
                    txt_codRelatorio.Text = "";

                    btn_alterar.Enabled = false;
                    btn_Pesquisar.Enabled = false;
                    btn_excluir.Enabled = false;

                    btn_inserir.Enabled = true;

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

        private void button3_Click(object sender, EventArgs e)
        {
            txt_relatorio.Text = "";
            txt_codRelatorio.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O campo código relatorio serve para: Pesquisar um relatório caso precise, Editar ou Exclui\n " +
                "digite o codigo que corresponde ao relatório desejado e depois clique em pesquisar", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_Pesquisar.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Relatorios abrir = new Relatorios();
            abrir.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Label_INFO.Visible = false;
        }

        private void txt_codRelatorio_TextChanged(object sender, EventArgs e)
        {
            btn_Pesquisar.Enabled = true;
        }

        private void txt_codRelatorio_Click(object sender, EventArgs e)
        {
            Label_INFO.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            // worksheet = workbook.Sheets["novo"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[i, 1] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Relatorios-Anotações";
            saveFileDialoge.DefaultExt = ".xlsx";

            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    }
}
