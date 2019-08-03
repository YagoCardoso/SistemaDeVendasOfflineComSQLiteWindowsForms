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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (txt_categoria != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("insert into CATEGORIA(DESCRICAO) values (@varDescricao)", sql);

                command.Parameters.Add("@varDescricao", SqlDbType.NVarChar).Value = txt_categoria.Text;

                if (txt_categoria.Text != "")
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cadastro efetuado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_categoria.Text = "";

                        BtnPesquisar.Enabled = false;
                        btnAlterar.Enabled = false;
                        BtnExcluir.Enabled = false;

                        Btn_Atualizar.Visible = true;

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

        private void Categorias_Load(object sender, EventArgs e)
        {
            Btn_Atualizar.Visible = false;
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet.CATEGORIA'. Você pode movê-la ou removê-la conforme necessário.
            this.cATEGORIATableAdapter.Fill(this.systemOrangeDataSet.CATEGORIA);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para pesquisar, digite o código no campo >Código< e clique em pesquisar , para  Alterar ou Excluir, Poderá localizar o código na tabela abaixo", "INFORMAÇÔES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand command = new SqlCommand("delete from CATEGORIA where SEQCATEGORIA=@cod", sql);

                command.Parameters.Add("@cod", SqlDbType.Int).Value = textBox1.Text;

                try
                {
                    sql.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show(" Excluido com Sucesso!", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_categoria.Text = "";
                    textBox1.Text = "";
                    BtnPesquisar.Enabled = false;
                    btnAlterar.Enabled = false;
                    BtnExcluir.Enabled = false;

                    Btn_Atualizar.Visible = true;

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
            textBox1.Text = "";
            txt_categoria.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                btnAlterar.Enabled = true;

                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("update CATEGORIA  set  DESCRICAO=@descricao where SEQCATEGORIA=@SEQCATEGORIA ", sql);


                // command.Parameters.Add("@cod", SqlDbType.NVarChar).Value = textBox1.Text;
                command.Parameters.Add("@descricao", SqlDbType.NVarChar).Value = txt_categoria.Text;
                command.Parameters.Add("@SEQCATEGORIA", SqlDbType.Int).Value = textBox1.Text;




                if (txt_categoria.Text != "")
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Atualização salva com Sucesso com Sucesso!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox1.Text = "";
                        txt_categoria.Text = "";
                        Btn_Atualizar.Visible = true;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_categoria.Text != null)
            {
                btnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;

                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("select * from CATEGORIA where SEQCATEGORIA=@SEQCATEGORIA", sql);

                command.Parameters.Add("@SEQCATEGORIA", SqlDbType.Int).Value = textBox1.Text;


                try
                {
                    sql.Open();
                    SqlDataReader drms = command.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new Exception("Categoria não encontrada");
                    }
                    drms.Read();
                    textBox1.Text = Convert.ToString(drms["SEQCATEGORIA"]);
                    txt_categoria.Text = Convert.ToString(drms["DESCRICAO"]);



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
            else { MessageBox.Show("Digite a categoria!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No campo Código CAD, Digite o numero que corresponde a categoria que deseja Editar, Excluir\n e clique no botão Pesquisar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_categoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BtnPesquisar.Enabled = true;
        }

      

        private void button1_Click_2(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
           // worksheet = workbook.Sheets["novo"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i< dataGridView1.Columns.Count+1; i++)
            {
                worksheet.Cells[i, 1] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count;j++ )
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Categoria";
            saveFileDialoge.DefaultExt = ".xlsx";

            if(saveFileDialoge.ShowDialog()==DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();





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
            saveFileDialoge.FileName = "Categoria";
            saveFileDialoge.DefaultExt = ".xlsx";

            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    }

}


