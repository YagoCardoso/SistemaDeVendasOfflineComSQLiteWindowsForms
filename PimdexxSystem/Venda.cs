using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet6.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.systemOrangeDataSet6.CLIENTE);

            //Campos excondidos na tela Efetuar venda
            TXT_TOTALCARRINHO.Visible = false;
            txt_TAGPORCENTAGEM.Visible = false;

            // set datatable columns values
            table.Columns.Add("Código do Produto", typeof(int));// data type int
            table.Columns.Add("Descrição", typeof(string));// datatype string
            table.Columns.Add("Categoria", typeof(string));// datatype string
            table.Columns.Add("Valor UND.", typeof(int));// data type int
            table.Columns.Add("QTDE.", typeof(int));// data type string
            table.Columns.Add("Total", typeof(int));// data type int


            dataGridView1.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //table.Rows.Add(txt_codProduto.Text, txt_descricao.Text, txt_categoria.Text, txt_ValorUND.Text);
            //dataGridView1.DataSource = table;
            //txt_categoria.Text = "";
            //txt_codProduto.Text = "";
            //txt_descricao.Text = "";
            //txt_ValorUND.Text = "";
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
                    txt_ValorUND.Text = Convert.ToString(drms["VALOR"]);
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
            txt_ValorUND.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double quantidade = Convert.ToDouble(txt_QTDE.Text);
                double unidade = Convert.ToDouble(txt_ValorUND.Text);

                var resultado = quantidade * unidade;

                TXT_TOTALCARRINHO.Text = resultado.ToString();
            }
            catch { MessageBox.Show("Digite apenas numeros nos campos: Valor, QTDE.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);  }
         

            if (txt_QTDE.Text == "")
            {
                MessageBox.Show("Insira a quantidade no campo QTDE.", "ATENÇÃO", MessageBoxButtons.OK);
             
            }else
            {
               
                table.Rows.Add(txt_codProduto.Text, txt_descricao.Text, txt_categoria.Text, txt_ValorUND.Text, txt_QTDE.Text, TXT_TOTALCARRINHO.Text);
                dataGridView1.DataSource = table;
                txt_categoria.Text = "";
                txt_codProduto.Text = "";
                txt_descricao.Text = "";
                txt_ValorUND.Text = "";
                txt_QTDE.Text = "";
            }
          



        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_ADD.Enabled = false;
            txt_pagamento.Enabled = false;


            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("insert into VENDA(CLIENTE, TPPAGAMENTO, DESCONTO, TOTALVENDA, TOTALCOMPRA, DATA) values ( @varCliente, @varTPpagamento, @varDesconto, @varVenda, @varCompra, @DATA)", sql);

            command.Parameters.Add("@varCliente", SqlDbType.NVarChar).Value = txt_cliente.Text;
            command.Parameters.Add("@varTPpagamento", SqlDbType.NVarChar).Value = txt_pagamento.Text;
            command.Parameters.Add("@varDesconto", SqlDbType.NVarChar).Value = txtDesconto.Text + txt_TAGPORCENTAGEM.Text;
            command.Parameters.Add("@varVenda", SqlDbType.Int).Value = labelValorPagar.Text;
            command.Parameters.Add("@varCompra", SqlDbType.Int).Value = labelitens.Text;
            command.Parameters.Add("@DATA", SqlDbType.DateTime).Value = DateTime.Now;

            if (txt_cliente.Text != "" & txt_pagamento.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Venda realizada com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_categoria.Text = "";
                    txt_ValorUND.Text = "";
                    txt_descricao.Text = "";
                    txt_codProduto.Text = "";
                    txt_pagamento.Text = "";
                    labelValorPagar.Text = "";

                    btn_Finalizar.Enabled = false;
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
                MessageBox.Show("ATENÇÃO CAMPO 'CLIENTE' E CAMPO 'FORMA DE PAGAMENTO' SÃO OBRIGATÓRIOS", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


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
            string texto = "Deseja realmente termina o pedido? não sera possivel adicionar mais itens nesse pedido.\n Valor dos itens: R$ " + TXT_TOTALCARRINHO.Text;
            string titulo = "Terminar Pedido";

            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                //Calculando Valor total do carrinho
                double total = 0;


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    total += Convert.ToDouble(row.Cells["Total"].Value);

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
                BtnCalcularTroco.Enabled = true;
                btn_CalcularDesconto.Enabled = true;

            }


         
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
            if(txtDesconto.Text != "")
            {//Calculando Desconto

                double valor = Convert.ToDouble(labelitens.Text); // valor original
                double desconto = Convert.ToDouble(txtDesconto.Text);
                double percentual = desconto / 100.0; // desconto escolhido pelo usuario
                double valor_final = valor - (percentual * valor);

                labelDesconto.Text = valor_final.ToString();

                labelValorPagar.Text = valor_final.ToString();
            }
            else { MessageBox.Show("Insira um valor para calcular o desconto."); }
            
        }

        private void labelitens_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

         
        }

        private void Nordem_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
          //  table.Rows.Add(txt_codProduto.Text, txt_descricao.Text, txt_categoria.Text, txt_ValorUND, txt_QTDE.Text, TXT_TOTALCARRINHO.Text, txt_cliente.Text, txt_pagamento.Text, );

            //"Cliente", 
            //"Forma de P
            //"Desconto",
            //"Total Vend
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
