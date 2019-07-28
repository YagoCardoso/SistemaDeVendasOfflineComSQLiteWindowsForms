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
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void Venda_Load(object sender, EventArgs e)
        {
            // set datatable columns values
            table.Columns.Add("Código do Produto", typeof(int));// data type int
            table.Columns.Add("Descrição", typeof(string));// datatype string
            table.Columns.Add("Categoria", typeof(string));// datatype string
            table.Columns.Add("Valor", typeof(string));// data type int

            dataGridView1.DataSource = table;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt_codProduto.Text, txt_descricao.Text, txt_categoria.Text, txt_Valor.Text);
            dataGridView1.DataSource = table;
            txt_categoria.Text = "";
            txt_codProduto.Text = "";
            txt_descricao.Text = "";
            txt_Valor.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_ADD.Enabled = true;
            if(txt_codProduto.Text != "")
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

            else { MessageBox.Show("Digite o código no campo : Código do Produto", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information); }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txt_categoria.Text = "";
            txt_codProduto.Text = "";
            txt_descricao.Text = "";
            txt_Valor.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt_codProduto.Text, txt_descricao.Text, txt_categoria.Text, txt_Valor.Text);
            dataGridView1.DataSource = table;
            txt_categoria.Text = "";
            txt_codProduto.Text = "";
            txt_descricao.Text = "";
            txt_Valor.Text = "";

          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_ADD.Enabled = false;

          
        }

        private void txtvalor_total_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
           

           
        }

        private void txt_recebido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_recebido_MouseClick(object sender, MouseEventArgs e)
        {

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            //Calculando Valor total do carrinho
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                total += Convert.ToDouble(row.Cells["Valor"].Value);


            }
            //exibindo valor total na label
            labelitens.Text = Convert.ToString(total);
            labelValorPagar.Text = Convert.ToString(total);



            btn_Finalizar.Enabled = true;
            txt_pagamento.Enabled = true;
            txt_recebido.Enabled = true;
            txtDesconto.Enabled = true;
            panelPagamento.Enabled = true;
            panelDesconto.Enabled = true;
            panelTroco.Enabled = true;
            BtnCalcularTroco.Enabled = true;
            btn_CalcularDesconto.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Calculando valor do troco
             double valor1, valor2, resultado;
             valor1 = Convert.ToDouble(txt_recebido.Text);
             valor2 = Convert.ToDouble(labelValorPagar.Text);
             resultado = valor1 - valor2;
             labelResult.Text = resultado.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Calculando Desconto
           
            double valor = Convert.ToDouble(labelitens.Text); // valor original
            double desconto = Convert.ToDouble(txtDesconto.Text);
            double percentual = desconto / 100.0; // desconto escolhido pelo usuario
            double valor_final = valor - (percentual * valor);

            labelDesconto.Text = valor_final.ToString();

            labelValorPagar.Text = valor_final.ToString();
        }

        private void labelitens_Click(object sender, EventArgs e)
        {

        }
    }
}
