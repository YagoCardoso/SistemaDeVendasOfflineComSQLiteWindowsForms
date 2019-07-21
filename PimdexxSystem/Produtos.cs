using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;



namespace PimdexxSystem
{
    public partial class Produtos : Form
    {

        //   private string _strConn = @"Data Source = DESKTOP - PIKVREV\SQLEXPRESS;Initial Catalog = SystemOrange; Integrated Security = True";
        //
        //   SqlConnection objtConect = null;
        //
        //   SqlCommand objCommand = null;


        public Produtos()
        {
            InitializeComponent();
        }

        private void Veiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet1.CATEGORIA'. Você pode movê-la ou removê-la conforme necessário.
            this.cATEGORIATableAdapter.Fill(this.systemOrangeDataSet1.CATEGORIA);


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void ListaGrid()
        {




        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("insert into PRODUTO(SEQPRODUTO, DESCRICAO, VALOR, CATEGORIA) values (@varSeqProdutp, @varDescricao, @varValor, @varCategoria)", sql);

            command.Parameters.Add("@varSeqProdutp", SqlDbType.Int).Value = txt_codProduto.Text;
            command.Parameters.Add("@varDescricao", SqlDbType.NVarChar).Value = txt_descricao.Text;
            command.Parameters.Add("@varValor", SqlDbType.NVarChar).Value = txt_Valor.Text;
            command.Parameters.Add("@varCategoria", SqlDbType.NVarChar).Value = txt_categoria.Text;

            if (txt_codProduto.Text != "" & txt_Valor.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_categoria.Text = "";
                    txt_Valor.Text = "";
                    txt_descricao.Text = "";
                    txt_codProduto.Text = "";

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

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("select * from PRODUTO where SEQPRODUTO=@SEQPRODUTO", sql);

            command.Parameters.Add("@SEQPRODUTO", SqlDbType.Int).Value = txt_codProduto.Text;


            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("Produto não encontrado");
                }
                drms.Read();
                txt_codProduto.Text = Convert.ToString(drms["SEQPRODUTO"]);
                txt_descricao.Text = Convert.ToString(drms["DESCRICAO"]);
                txt_Valor.Text = Convert.ToString(drms["VALOR"]);
                txt_categoria.Text = Convert.ToString(drms["CATEGORIA"]);

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

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("update PRODUTO  set  DESCRICAO=@descricao, CATEGORIA=@categoria, VALOR=@valor where SEQPRODUTO=@SEQPRODUTO ", sql);


            command.Parameters.Add("@categoria", SqlDbType.NVarChar).Value = txt_categoria.Text;
            command.Parameters.Add("@descricao", SqlDbType.NVarChar).Value = txt_descricao.Text;
            command.Parameters.Add("@valor", SqlDbType.NVarChar).Value = txt_Valor.Text;
            command.Parameters.Add("@SEQPRODUTO", SqlDbType.Int).Value = txt_codProduto.Text;




            if (txt_categoria.Text != "" & txt_codProduto.Text != "" & txt_descricao.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Atualização salva com Sucesso com Sucesso!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_categoria.Text = "";
                    txt_codProduto.Text = "";
                    txt_descricao.Text = "";
                    txt_Valor.Text = "";

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

        private void button8_Click(object sender, EventArgs e)
        {
            string texto = "Deseja realmente Excluir?";
            string titulo = " Excluir";

            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {




                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("delete from PRODUTO where SEQPRODUTO=@cod", sql);

                command.Parameters.Add("@cod", SqlDbType.Int).Value = txt_codProduto.Text;

                try
                {
                    sql.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show(" Excluido com Sucesso!", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_categoria.Text = "";
                    txt_codProduto.Text = "";
                    txt_descricao.Text = "";
                    txt_Valor.Text = "";

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

        private void button7_Click(object sender, EventArgs e)
        {
            txt_categoria.Text = "";
            txt_codProduto.Text = "";
            txt_descricao.Text = "";
            txt_Valor.Text = "";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cATEGORIATableAdapter.FillBy(this.systemOrangeDataSet1.CATEGORIA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }

}
