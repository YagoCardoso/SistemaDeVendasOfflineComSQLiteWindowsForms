
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
using validaocampos;

namespace PimdexxSystem
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("insert into CLIENTE(CPF, NOME, DTNASCIMENTO, ENDERECO, BAIRRO, CIDADE, CEP, UF, RG, FONE) values (@varCpf, @varNome, @varDTnascimento, @varEndereco, @varBairro, @varCidade, @varCep, @varUF, @varRG, @varFone)", sql);

            command.Parameters.Add("@varCpf", SqlDbType.BigInt).Value = txt_CPF.Text;
            command.Parameters.Add("@varNome", SqlDbType.NVarChar).Value = txt_NomeCompleto.Text;
            command.Parameters.Add("@varDTnascimento", SqlDbType.DateTime).Value = txt_dtNascimento.Text;
            command.Parameters.Add("@varEndereco", SqlDbType.NVarChar).Value = txt_Endereco.Text;
            command.Parameters.Add("@varBairro", SqlDbType.NVarChar).Value = txt_Bairro.Text;
            command.Parameters.Add("@varCidade", SqlDbType.NVarChar).Value = txt_Cidade.Text;
            command.Parameters.Add("@varCep", SqlDbType.NVarChar).Value = txt_CEP.Text;
            command.Parameters.Add("@varUF", SqlDbType.NVarChar).Value = txt_UF.Text;
            command.Parameters.Add("@varRG", SqlDbType.NVarChar).Value = txt_RG.Text;
            command.Parameters.Add("@varFone", SqlDbType.NVarChar).Value = txt_Fone.Text;

            if (txt_CPF.Text != "" & txt_NomeCompleto.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_CPF.Text = "";
                    txt_NomeCompleto.Text = "";
                    txt_dtNascimento.Text = "";
                    txt_Endereco.Text = "";
                    txt_Bairro.Text = "";
                    txt_Cidade.Text = "";
                    txt_UF.Text = "";
                    txt_RG.Text = "";
                    txt_Fone.Text = "";

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
            if(txt_CPF.Text != null && txt_CPF.Text != "")
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("select * from CLIENTE where CPF=@CPF", sql);

                command.Parameters.Add("@CPF", SqlDbType.BigInt).Value = txt_CPF.Text;


                try
                {
                    sql.Open();
                    SqlDataReader drms = command.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new Exception("Produto não encontrado!");
                    }
                    else
                    {
                        drms.Read();
                        txt_CPF.Text = Convert.ToString(drms["CPF"]);
                        txt_NomeCompleto.Text = Convert.ToString(drms["NOME"]);
                        txt_dtNascimento.Text = Convert.ToString(drms["DTNASCIMENTO"]);
                        txt_Endereco.Text = Convert.ToString(drms["ENDERECO"]);
                        txt_Bairro.Text = Convert.ToString(drms["BAIRRO"]);
                        txt_Cidade.Text = Convert.ToString(drms["CIDADE"]);
                        txt_CEP.Text = Convert.ToString(drms["CEP"]);
                        txt_UF.Text = Convert.ToString(drms["UF"]);
                        txt_RG.Text = Convert.ToString(drms["RG"]);
                        txt_Fone.Text = Convert.ToString(drms["FONE"]);
                    }
                  


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
            else { MessageBox.Show("ATENÇÃO DIGITE UM CPF PARA PESQUISAR!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information); }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(txt_CPF.Text != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("update CLIENTE  set  NOME=@NOME, DTNASCIMENTO=@DTNASCIMENTO, ENDERECO=@ENDERECO, BAIRRO=@BAIRRO, CIDADE=@CIDADE, CEP=@CEP, UF=@UF, RG=@RG, FONE=@FONE  where CPF=@CPF ", sql);


                command.Parameters.Add("@CPF", SqlDbType.BigInt).Value = txt_CPF.Text;
                command.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = txt_NomeCompleto.Text;
                command.Parameters.Add("@DTNASCIMENTO", SqlDbType.DateTime).Value = txt_dtNascimento.Text;
                command.Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = txt_Endereco.Text;
                command.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = txt_Bairro.Text;
                command.Parameters.Add("@CIDADE", SqlDbType.NVarChar).Value = txt_Cidade.Text;
                command.Parameters.Add("@CEP", SqlDbType.NVarChar).Value = txt_CEP.Text;
                command.Parameters.Add("@UF", SqlDbType.NVarChar).Value = txt_UF.Text;
                command.Parameters.Add("@RG", SqlDbType.NVarChar).Value = txt_RG.Text;
                command.Parameters.Add("@FONE", SqlDbType.NVarChar).Value = txt_Fone.Text;




                if (txt_CPF.Text != "" & txt_NomeCompleto.Text != "")
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Atualização salva com Sucesso com Sucesso!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_CPF.Text = "";
                        txt_NomeCompleto.Text = "";
                        txt_dtNascimento.Text = "";
                        txt_Endereco.Text = "";
                        txt_Bairro.Text = "";
                        txt_Cidade.Text = "";
                        txt_CEP.Text = "";
                        txt_UF.Text = "";
                        txt_RG.Text = "";
                        txt_Fone.Text = "";

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
            else { MessageBox.Show("Primeiro pesquise por algum CPF, para alterar registros.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_CPF.Text = "";
            txt_NomeCompleto.Text = "";
            txt_dtNascimento.Text = "";
            txt_Endereco.Text = "";
            txt_Bairro.Text = "";
            txt_Cidade.Text = "";
            txt_UF.Text = "";
            txt_RG.Text = "";
            txt_Fone.Text = "";
            txt_CEP.Text = string.Empty;
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
                SqlCommand command = new SqlCommand("delete from CLIENTE where CPF=@cod", sql);

                command.Parameters.Add("@cod", SqlDbType.BigInt).Value = txt_CPF.Text;

                try
                {
                    sql.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show(" Excluido com Sucesso!", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_CPF.Text = "";
                    txt_NomeCompleto.Text = "";
                    txt_dtNascimento.Text = "";
                    txt_Endereco.Text = "";
                    txt_Bairro.Text = "";
                    txt_Cidade.Text = "";
                    txt_UF.Text = "";
                    txt_RG.Text = "";
                    txt_Fone.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                }
        }   }

        private void txt_CPF_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListaClientes f = new ListaClientes();

            f.Show();
        }

        private void txt_CPF_Click(object sender, EventArgs e)
        {
            LABEL_CPF.Text = "";
        }

        private void txt_CPF_Click_1(object sender, EventArgs e)
        {
            LABEL_CPF.Text = "";
        }

        private void LABEL_CPF_Click(object sender, EventArgs e)
        {
            LABEL_CPF.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //ConsultarCep cep = new ConsultarCep();
            //cep.Show();

            if (!string.IsNullOrWhiteSpace(txt_CEP.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())

                    try
                    {
                        var endereco = ws.consultaCEP(txt_CEP.Text.Trim());
                        txt_UF.Text = endereco.uf;
                        txt_Cidade.Text = endereco.cidade;
                        txt_Bairro.Text = endereco.bairro;
                        txt_Endereco.Text = endereco.end;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                MessageBox.Show("Informe um CEP para Pesquisar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
