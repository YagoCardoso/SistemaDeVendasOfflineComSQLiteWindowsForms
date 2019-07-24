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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_SalvarNovo_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("insert into USUARIO(CPF, NOME, DTNASCIMENTO, ENDERECO, BAIRRO, CIDADE, CEP, UF, RG, " +
                "FONE, SALARIO, TIPOUSU, DTADMISSAO, DTDESLIGAMENTO, USUARIO, SENHA ) values (@varCpf, @varNome, @varDTnascimento, " +
                "@varEndereco, @varBairro, @varCidade, @varCep, @varUF, @varRG, @varFone, @varSalario, @varTipousu, @varDTadmissao, " +
                "@varDTdesligamento, @varUsuario, @varSenha )", sql);

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
            command.Parameters.Add("@varSalario", SqlDbType.NVarChar).Value = txt_Salario.Text;
            command.Parameters.Add("@varTipousu", SqlDbType.NVarChar).Value = cbox_TipoUsu.Text;
            command.Parameters.Add("@varDTadmissao", SqlDbType.DateTime).Value = txt_dtadmissao.Text;
            command.Parameters.Add("@varDTdesligamento", SqlDbType.DateTime).Value = txt_desligamento.Text;
            command.Parameters.Add("@varUsuario", SqlDbType.NVarChar).Value = txt_usuario.Text;
            command.Parameters.Add("@varSenha", SqlDbType.NVarChar).Value = txt_Senha.Text;

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
                    txt_Salario.Text = "";
                    cbox_TipoUsu.Text = "";
                    txt_dtadmissao.Text = "";
                    txt_desligamento.Text = "";
                    txt_usuario.Text = "";
                    txt_Senha.Text = "";

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
            if (txt_CPF.Text != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("select * from USUARIO where CPF=@CPF", sql);

                command.Parameters.Add("@CPF", SqlDbType.BigInt).Value = txt_CPF.Text;


                try
                {
                    sql.Open();
                    SqlDataReader drms = command.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new Exception("Cadastro  não encontrado!");
                    }
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

                    txt_Salario.Text = Convert.ToString(drms["SALARIO"]);
                    cbox_TipoUsu.Text = Convert.ToString(drms["TIPOUSU"]);
                    txt_dtadmissao.Text = Convert.ToString(drms["DTADMISSAO"]);
                    txt_desligamento.Text = Convert.ToString(drms["DTDESLIGAMENTO"]);
                    txt_usuario.Text = Convert.ToString(drms["USUARIO"]);
                    txt_Senha.Text = Convert.ToString(drms["SENHA"]);


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
            txt_CPF.Text = "";
            txt_NomeCompleto.Text = "";
            txt_dtNascimento.Text = "";
            txt_Endereco.Text = "";
            txt_Bairro.Text = "";
            txt_Cidade.Text = "";
            txt_UF.Text = "";
            txt_RG.Text = "";
            txt_Fone.Text = "";
            txt_Salario.Text = "";
            cbox_TipoUsu.Text = "";
            txt_dtadmissao.Text = "";
            txt_desligamento.Text = "";
            txt_usuario.Text = "";
            txt_Senha.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_CPF.Text != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("update USUARIO  set  NOME=@NOME, DTNASCIMENTO=@DTNASCIMENTO, ENDERECO=@ENDERECO, BAIRRO=@BAIRRO, CIDADE=@CIDADE, CEP=@CEP, UF=@UF, RG=@RG, FONE=@FONE, SALARIO=@SALARIO, TIPOUSU=@TIPOUSU, DTADMISSAO=@DTADMISSAO, DTDESLIGAMENTO=@DTDESLIGAMENTO, USUARIO=@USUARIO, SENHA=@SENHA  where CPF=@CPF ", sql);


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
                command.Parameters.Add("@SALARIO", SqlDbType.NVarChar).Value = txt_Salario.Text;
                command.Parameters.Add("@TIPOUSU", SqlDbType.NVarChar).Value = cbox_TipoUsu.Text;
                command.Parameters.Add("@DTADMISSAO", SqlDbType.DateTime).Value = txt_dtadmissao.Text;
                command.Parameters.Add("@DTDESLIGAMENTO", SqlDbType.DateTime).Value = txt_desligamento.Text;
                command.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = txt_usuario.Text;
                command.Parameters.Add("@SENHA", SqlDbType.NVarChar).Value = txt_Senha.Text;




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
                        txt_UF.Text = "";
                        txt_RG.Text = "";
                        txt_Fone.Text = "";
                        txt_Salario.Text = "";
                        cbox_TipoUsu.Text = "";
                        txt_dtadmissao.Text = "";
                        txt_desligamento.Text = "";
                        txt_usuario.Text = "";
                        txt_Senha.Text = "";

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

        private void button8_Click(object sender, EventArgs e)
        {
            string texto = "Deseja realmente Excluir?";
            string titulo = " Excluir";

            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {




                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("delete from USUARIO where cpf=@cod", sql);

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
                    txt_Salario.Text = "";
                    cbox_TipoUsu.Text = "";
                    txt_dtadmissao.Text = "";
                    txt_desligamento.Text = "";
                    txt_usuario.Text = "";
                    txt_Senha.Text = "";

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
}
