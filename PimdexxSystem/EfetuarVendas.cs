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
    public partial class EfetuarVendas : Form
    {
        public EfetuarVendas()
        {
            InitializeComponent();
        }

        private void EfetuarVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet3.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOTableAdapter.Fill(this.systemOrangeDataSet3.PRODUTO);

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

        private void txt_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
