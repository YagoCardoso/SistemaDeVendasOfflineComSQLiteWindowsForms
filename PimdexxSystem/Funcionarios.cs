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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
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
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=db_info;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("insert into tb_funcionarios(id_cpf, nomeUsu, endereco, bairro, cidade, cep, uf, rg, fone, salario, tipoUsu, dtNascimento, dtAdmissao, dtDesligamento, usuario, senha) values (@id_cpf, @nomeUsu, @endereco, @bairro, @cidade, @cep, @uf, @rg, @fone, @salario, @tipoUsu, @dtNascimento, @dtAdmissao, @dtDesligamento, @usuario, @senha)", sql);
            //SqlCommand command = new SqlCommand("insert into lele(cpf, nome, rg) values (@cpf, @nome, @rg)", sql);

            command.Parameters.Add("@id_cpf", SqlDbType.NVarChar).Value = txt_CPF;
            command.Parameters.Add("@nomeUsu", SqlDbType.NVarChar).Value = txt_NomeCompleto;
            command.Parameters.Add("@endereco", SqlDbType.NVarChar).Value = txt_Endereco;
            command.Parameters.Add("@bairro", SqlDbType.NVarChar).Value = txt_Bairro;
            command.Parameters.Add("@cidade", SqlDbType.NVarChar).Value = txt_Cidade;
            command.Parameters.Add("@cep", SqlDbType.NVarChar).Value = txt_CEP;
            command.Parameters.Add("@uf", SqlDbType.NVarChar).Value = txt_UF;
            command.Parameters.Add("@rg", SqlDbType.NVarChar).Value = txt_RG;
            command.Parameters.Add("@fone", SqlDbType.NVarChar).Value = txt_Fone;
            command.Parameters.Add("@salario", SqlDbType.NVarChar).Value = txt_Salario;
            command.Parameters.Add("@tipoUsu", SqlDbType.NVarChar).Value = cbox_TipoUsu;
            command.Parameters.Add("@dtNascimento", SqlDbType.NVarChar).Value = txt_dtNascimento;
            command.Parameters.Add("@dtAdmissao", SqlDbType.NVarChar).Value = txt_dtadmissao;
            command.Parameters.Add("@dtDesligamento", SqlDbType.NVarChar).Value = txt_desligamento;
            command.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = txt_usuario;
            command.Parameters.Add("@senha", SqlDbType.NVarChar).Value = txt_Senha;

            if (txt_CPF.Text != "" & txt_NomeCompleto.Text != "" & txt_RG.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "SUCESSO", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txt_CPF.Text = "";
                    txt_NomeCompleto.Text = "";
                    txt_Endereco.Text = "";
                    txt_Bairro.Text = "";
                    txt_Cidade.Text = "";
                    txt_CEP.Text = "";
                    txt_UF.Text = "";
                    txt_RG.Text = "";
                    txt_Fone.Text = "";
                    txt_Salario.Text = "";
                    cbox_TipoUsu.Text = "";
                    txt_dtNascimento.Text = "";
                    txt_dtadmissao.Text = "";
                    txt_desligamento.Text = "";
                    txt_usuario.Text = "";
                    txt_Senha.Text= "";
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
    }
}
