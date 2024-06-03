using PimdexxSystem.WSCorreios;
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

using Pdv.Domain.Entidades;
using Pdv.Domain.Services;

namespace PimdexxSystem
{
    public partial class Clientes : Form
    {
        private readonly IClienteService _clienteService;

        public Clientes(IClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
        }

        private void EventoClickInserir(object sender, EventArgs e)
        {
            var endereco = new Endereco(txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, txtUf.Text);
            var cliente = new Cliente(txtNome.Text, txtCpf.Text, txtRg.Text, txtTelefone.Text, Convert.ToDateTime(txtDtNascimento), endereco);
            
            if (cliente.IsValid)
            {
                try
                {
                    _clienteService.InserirCliente(cliente);
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.EventoClickLimpar(sender, e);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                }

            }
            else
            {
                MessageBox.Show("Campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EventoClickPesquisar(object sender, EventArgs e)
        {
            if(txtCpf.Text != null && txtCpf.Text != "")
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("select * from CLIENTE where CPF=@CPF", sql);

                command.Parameters.Add("@CPF", SqlDbType.BigInt).Value = txtCpf.Text;

                try
                {
                    sql.Open();
                    SqlDataReader drms = command.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new System.Exception("Produto não encontrado!");
                    }
                    else
                    {
                        drms.Read();
                        txtCpf.Text = Convert.ToString(drms["CPF"]);
                        txtNome.Text = Convert.ToString(drms["NOME"]);
                        txtDtNascimento.Text = Convert.ToString(drms["DTNASCIMENTO"]);
                        txtEndereco.Text = Convert.ToString(drms["ENDERECO"]);
                        txtBairro.Text = Convert.ToString(drms["BAIRRO"]);
                        txtCidade.Text = Convert.ToString(drms["CIDADE"]);
                        txtCep.Text = Convert.ToString(drms["CEP"]);
                        txtUf.Text = Convert.ToString(drms["UF"]);
                        txtRg.Text = Convert.ToString(drms["RG"]);
                        txtTelefone.Text = Convert.ToString(drms["FONE"]);
                    }
                }
                catch (System.Exception ex)
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

        private void EventoClickAlterar(object sender, EventArgs e)
        {
            if(txtCpf.Text != null)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("update CLIENTE  set  NOME=@NOME, DTNASCIMENTO=@DTNASCIMENTO, ENDERECO=@ENDERECO, BAIRRO=@BAIRRO, CIDADE=@CIDADE, CEP=@CEP, UF=@UF, RG=@RG, FONE=@FONE  where CPF=@CPF ", sql);

                command.Parameters.Add("@CPF", SqlDbType.BigInt).Value = txtCpf.Text;
                command.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = txtNome.Text;
                command.Parameters.Add("@DTNASCIMENTO", SqlDbType.DateTime).Value = txtDtNascimento.Text;
                command.Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = txtEndereco.Text;
                command.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = txtBairro.Text;
                command.Parameters.Add("@CIDADE", SqlDbType.NVarChar).Value = txtCidade.Text;
                command.Parameters.Add("@CEP", SqlDbType.NVarChar).Value = txtCep.Text;
                command.Parameters.Add("@UF", SqlDbType.NVarChar).Value = txtUf.Text;
                command.Parameters.Add("@RG", SqlDbType.NVarChar).Value = txtRg.Text;
                command.Parameters.Add("@FONE", SqlDbType.NVarChar).Value = txtTelefone.Text;




                if (txtCpf.Text != "" & txtNome.Text != "")
                {
                    try
                    {
                        sql.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Atualização salva com Sucesso com Sucesso!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCpf.Text = "";
                        txtNome.Text = "";
                        txtDtNascimento.Text = "";
                        txtEndereco.Text = "";
                        txtBairro.Text = "";
                        txtCidade.Text = "";
                        txtCep.Text = "";
                        txtUf.Text = "";
                        txtRg.Text = "";
                        txtTelefone.Text = "";

                    }
                    catch (System.Exception ex)
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

        private void EventoClickLimpar(object sender, EventArgs e)
        {
            txtCpf.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtDtNascimento.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtUf.Text = String.Empty;
            txtRg.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCep.Text = String.Empty;
        }

        private void EventoClickExcluir(object sender, EventArgs e)
        {
            string texto = "Deseja realmente Excluir?";
            string titulo = " Excluir";

            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                SqlCommand command = new SqlCommand("delete from CLIENTE where CPF=@cod", sql);

                command.Parameters.Add("@cod", SqlDbType.BigInt).Value = txtCpf.Text;

                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show(" Excluido com Sucesso!", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.EventoClickLimpar(sender, e);
                }
                catch (System.Exception ex)
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
            ListaClientes f = new ListaClientes();

            f.Show();
        }

        private void txt_CPF_Click(object sender, EventArgs e)
        {
            labelCpf.Text = "";
        }

        private void EventoClickTxtCpf(object sender, EventArgs e)
        {
            labelCpf.Text = "";
        }

        private void EventoCpfClick(object sender, EventArgs e)
        {
            labelCpf.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())

                    try
                    {
                        var endereco = ws.consultaCEP(txtCep.Text.Trim());
                        txtUf.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                        txtBairro.Text = endereco.bairro;
                        txtEndereco.Text = endereco.end;

                    }
                    catch (System.Exception ex)
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
