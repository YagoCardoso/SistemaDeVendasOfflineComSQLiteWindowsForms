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

        private void Categorias_Load(object sender, EventArgs e)
        {
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
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("update CATEGORIA  set  DESCRICAO=@descricao where SEQCATEGORIA=@SEQCATEGORIA ", sql);


           // command.Parameters.Add("@cod", SqlDbType.NVarChar).Value = textBox1.Text;
            command.Parameters.Add("@descricao", SqlDbType.NVarChar).Value = txt_categoria.Text;
            command.Parameters.Add("@SEQCATEGORIA", SqlDbType.Int).Value = textBox1.Text;




            if (txt_categoria.Text != "" )
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Atualização salva com Sucesso com Sucesso!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox1.Text = "";
                    txt_categoria.Text = "";
              
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

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}


