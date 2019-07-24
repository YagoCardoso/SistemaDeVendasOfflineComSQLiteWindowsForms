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

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_relatorio != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("insert into RELATORIOS(DESCRICAO) values (@varDescricao)", sql);

                command.Parameters.Add("@varDescricao", SqlDbType.NVarChar).Value = txt_relatorio.Text;

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
            if (txt_relatorio.Text != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("select * from RELATORIOS where SEQRELATORIO=@SEQRELATORIO", sql);

                command.Parameters.Add("@SEQRELATORIO", SqlDbType.BigInt).Value = textBox1.Text;


                try
                {
                    sql.Open();
                    SqlDataReader drms = command.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new Exception("Relatório não encontrado");
                    }
                    drms.Read();
                    textBox1.Text = Convert.ToString(drms["SEQRELATORIO"]);
                    txt_relatorio.Text = Convert.ToString(drms["DESCRICAO"]);



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
            else { MessageBox.Show("Digite o código do relatório!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("update RELATORIOS  set  DESCRICAO=@descricao where SEQRELATORIO=@SEQRELATORIO ", sql);


                // command.Parameters.Add("@cod", SqlDbType.NVarChar).Value = textBox1.Text;
                command.Parameters.Add("@descricao", SqlDbType.NVarChar).Value = txt_relatorio.Text;
                command.Parameters.Add("@SEQRELATORIO", SqlDbType.BigInt).Value = textBox1.Text;




                if (txt_relatorio.Text != "")
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Atualização salva com Sucesso com Sucesso!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox1.Text = "";
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

                command.Parameters.Add("@cod", SqlDbType.Int).Value = textBox1.Text;

                try
                {
                    sql.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show(" Excluido com Sucesso!", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_relatorio.Text = "";
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
            txt_relatorio.Text = "";
            textBox1.Text = "";
        }
    }
}
