using Pdv.Application;
using Pdv.Domain.Entidades;
using Pdv.Domain.Entidades.Funcionario;
using Pdv.Domain.Enums;
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
        private readonly FuncionarioService _funcionarioService;

        public Usuarios(FuncionarioService funcionarioService)
        {
            InitializeComponent();
            _funcionarioService = funcionarioService;
        }

        public void LimparCamposFuncionario()
        {
            txtCpf.Text = "";
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            txtRg.Text = "";
            txtTelefone.Text = "";
            txtSalario.Text = "";
            cboxTipoAcesso.Text = "";
            txtDataAdmissao.Text = "";
            txtDataDesligamento.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            
            txtCpf.Focus();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'systemOrangeDataSet11.USUARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.UsuarioTableAdapter.Fill(this.systemOrangeDataSet11.USUARIO);
        }

        private void EventoClickSalvarFuncionario(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
            SqlCommand command = new SqlCommand("insert into USUARIO(CPF, NOME, DTNASCIMENTO, ENDERECO, BAIRRO, CIDADE, CEP, UF, RG, FONE, SALARIO, TIPOUSU, DTADMISSAO, DTDESLIGAMENTO, USUARIO, SENHA ) values (@varCpf, @varNome, @varDTnascimento, @varEndereco, @varBairro, @varCidade, @varCep, @varUF, @varRG, @varFone, @varSalario, @varTipousu, @varDTadmissao, @varDTdesligamento, @varUsuario, @varSenha)", sql);

            /*var funcionario = new Funcionario(
                txtNome.Text,
                txtCpf.Text,
                txtRg.Text,
                txtTelefone.Text,
                Convert.ToDateTime(txtDataNascimento.Text),
                new Endereco
                {
                    Rua = txtRua.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    CodigoCep = txtCidade.Text,
                    Uf = (Uf)Enum.Parse(typeof(Uf), txtUf.Text, true)
                },
                new ContaAcesso
                {
                    Usuario = txtUsuario.Text,
                    Senha = txtSenha.Text
                },
                Convert.ToDecimal(txtSalario.Text)
                );*/

            //command.Parameters.Add("@varCpf", SqlDbType.BigInt).Value = ;
            command.Parameters.Add("@varNome", SqlDbType.NVarChar).Value = txtNome.Text;
            command.Parameters.Add("@varDTnascimento", SqlDbType.DateTime).Value = txtDataNascimento.Text;
            command.Parameters.Add("@varEndereco", SqlDbType.NVarChar).Value = txtRua.Text;
            command.Parameters.Add("@varBairro", SqlDbType.NVarChar).Value = txtBairro.Text;
            command.Parameters.Add("@varCidade", SqlDbType.NVarChar).Value = txtCidade.Text;
            command.Parameters.Add("@varCep", SqlDbType.NVarChar).Value = txt_CEP.Text;
            command.Parameters.Add("@varUF", SqlDbType.NVarChar).Value = txtUf.Text;
            command.Parameters.Add("@varRG", SqlDbType.NVarChar).Value = txtRg.Text;
            command.Parameters.Add("@varFone", SqlDbType.NVarChar).Value = txtTelefone.Text;
            command.Parameters.Add("@varSalario", SqlDbType.NVarChar).Value = txtSalario.Text;
            command.Parameters.Add("@varTipousu", SqlDbType.NVarChar).Value = cboxTipoAcesso.Text;
            command.Parameters.Add("@varDTadmissao", SqlDbType.DateTime).Value = txtDataAdmissao.Text;
            command.Parameters.Add("@varDTdesligamento", SqlDbType.DateTime).Value = txtDataDesligamento.Text;
            command.Parameters.Add("@varUsuario", SqlDbType.NVarChar).Value = txtUsuario.Text;
            command.Parameters.Add("@varSenha", SqlDbType.NVarChar).Value = txtSenha.Text;

            if (txtCpf.Text != "" && txtNome.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimparCamposFuncionario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Atenção campos obrigatórios!", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EventoClickPesquisarFuncionario(object sender, EventArgs e)
        {
            if (txtCpf.Text != null && txtCpf.Text != "")
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("select * from USUARIO where CPF=@CPF", sql);

                command.Parameters.Add("@CPF", SqlDbType.BigInt).Value = txtCpf.Text;


                try
                {
                    sql.Open();
                    SqlDataReader drms = command.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new Exception("Usuário  não encontrado!");
                    }
                    drms.Read();
                    txtCpf.Text = Convert.ToString(drms["CPF"]);
                    txtNome.Text = Convert.ToString(drms["NOME"]);
                    txtDataNascimento.Text = Convert.ToString(drms["DTNASCIMENTO"]);
                    txtRua.Text = Convert.ToString(drms["ENDERECO"]);
                    txtBairro.Text = Convert.ToString(drms["BAIRRO"]);
                    txtCidade.Text = Convert.ToString(drms["CIDADE"]);
                    txt_CEP.Text = Convert.ToString(drms["CEP"]);
                    txtUf.Text = Convert.ToString(drms["UF"]);
                    txtRg.Text = Convert.ToString(drms["RG"]);
                    txtTelefone.Text = Convert.ToString(drms["FONE"]);

                    txtSalario.Text = Convert.ToString(drms["SALARIO"]);
                    cboxTipoAcesso.Text = Convert.ToString(drms["TIPOUSU"]);
                    txtDataAdmissao.Text = Convert.ToString(drms["DTADMISSAO"]);
                    txtDataDesligamento.Text = Convert.ToString(drms["DTDESLIGAMENTO"]);
                    txtUsuario.Text = Convert.ToString(drms["USUARIO"]);
                    txtSenha.Text = Convert.ToString(drms["SENHA"]);


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
            else { MessageBox.Show("ATENÇÃO DIGITE UM CPF PARA PESQUISAR!", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void EventoLimparClick(object sender, EventArgs e)
        {
            this.LimparCamposFuncionario();
        }

        private void EventoClickAlterarFuncionario(object sender, EventArgs e)
        {
            if (txtCpf.Text != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("update USUARIO  set  NOME=@NOME, DTNASCIMENTO=@DTNASCIMENTO, ENDERECO=@ENDERECO, BAIRRO=@BAIRRO, CIDADE=@CIDADE, CEP=@CEP, UF=@UF, RG=@RG, FONE=@FONE, SALARIO=@SALARIO, TIPOUSU=@TIPOUSU, DTADMISSAO=@DTADMISSAO, DTDESLIGAMENTO=@DTDESLIGAMENTO, USUARIO=@USUARIO, SENHA=@SENHA  where CPF=@CPF ", sql);

                command.Parameters.Add("@CPF", SqlDbType.BigInt).Value = txtCpf.Text;
                command.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = txtNome.Text;
                command.Parameters.Add("@DTNASCIMENTO", SqlDbType.DateTime).Value = txtDataNascimento.Text;
                command.Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = txtRua.Text;
                command.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = txtBairro.Text;
                command.Parameters.Add("@CIDADE", SqlDbType.NVarChar).Value = txtCidade.Text;
                command.Parameters.Add("@CEP", SqlDbType.NVarChar).Value = txt_CEP.Text;
                command.Parameters.Add("@UF", SqlDbType.NVarChar).Value = txtUf.Text;
                command.Parameters.Add("@RG", SqlDbType.NVarChar).Value = txtRg.Text;
                command.Parameters.Add("@FONE", SqlDbType.NVarChar).Value = txtTelefone.Text;
                command.Parameters.Add("@SALARIO", SqlDbType.NVarChar).Value = txtSalario.Text;
                command.Parameters.Add("@TIPOUSU", SqlDbType.NVarChar).Value = cboxTipoAcesso.Text;
                command.Parameters.Add("@DTADMISSAO", SqlDbType.DateTime).Value = txtDataAdmissao.Text;
                command.Parameters.Add("@DTDESLIGAMENTO", SqlDbType.DateTime).Value = txtDataDesligamento.Text;
                command.Parameters.Add("@USUARIO", SqlDbType.NVarChar).Value = txtUsuario.Text;
                command.Parameters.Add("@SENHA", SqlDbType.NVarChar).Value = txtSenha.Text;

                if (txtCpf.Text != "" & txtNome.Text != "")
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Atualização salva com Sucesso com Sucesso!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimparCamposFuncionario();

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
                    MessageBox.Show("Primeiro pesquise por algum CPF, para alterar registros.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else { MessageBox.Show("Primeiro pesquise por algum CPF, para alterar registros.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void EventoClickExcluirFuncionario(object sender, EventArgs e)
        {
            string texto = "Deseja realmente Excluir?";
            string titulo = " Excluir";

            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("delete from USUARIO where cpf=@cod", sql);

                command.Parameters.Add("@cod", SqlDbType.BigInt).Value = txtCpf.Text;

                try
                {
                    sql.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show(" Excluido com Sucesso!", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LimparCamposFuncionario();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConsultarUsuario ver = new ConsultarUsuario();
            ver.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_CEP.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())

                    try
                    {
                        var endereco = ws.consultaCEP(txt_CEP.Text.Trim());
                        txtUf.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                        txtBairro.Text = endereco.bairro;
                        txtRua.Text = endereco.end;

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
    }
}
