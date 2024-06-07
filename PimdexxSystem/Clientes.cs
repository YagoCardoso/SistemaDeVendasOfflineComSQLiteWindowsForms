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
using Pdv.Application;
using Pdv.Domain.Enums;

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

        private void PreencherDadosClienteForm(Pessoa cliente)
        {
            txtCpf.Text = cliente.Cpf;
            txtNome.Text = cliente.Nome;
            txtDtNascimento.Text = cliente.DataNascimento.ToString();
            txtEndereco.Text = cliente.Endereco.Rua;
            txtBairro.Text = cliente.Endereco.Bairro;
            txtCidade.Text = cliente.Endereco.Cidade;
            txtCep.Text = cliente.Endereco.CodigoCep;
            txtUf.Text = cliente.Endereco.Uf.ToString();
            txtRg.Text = cliente.Rg;
            txtTelefone.Text = cliente.Telefone;
        }

        private void PreencherDadosEnderecoForm(Endereco endereco)
        {
            txtUf.Text = endereco.Uf.ToString();
            txtCidade.Text = endereco.Cidade;
            txtBairro.Text = endereco.Bairro;
            txtEndereco.Text = endereco.Rua;
            txtCep.Text = endereco.CodigoCep;
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

        private void EventoClickInserir(object sender, EventArgs e)
        {
            var endereco = new Endereco(txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, (Uf)Enum.Parse(typeof(Uf), txtUf.Text, true));
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
            }
            else
            {
                MessageBox.Show("Campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EventoClickPesquisar(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;

            if(!String.IsNullOrEmpty(cpf))
            {

                var cliente = _clienteService.ObterCliente(cpf);                

                try
                {                    
                    if (cliente != null)                    
                        this.PreencherDadosClienteForm(cliente);                    
                    else
                        MessageBox.Show("CPF não encontrado !", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show("Digite um CPF válido!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void EventoClickAlterar(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;

            if (!String.IsNullOrEmpty(cpf))
            {
                var endereco = new Endereco(txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, (Uf)Enum.Parse(typeof(Uf), txtUf.Text, true));
                var cliente = new Cliente(txtNome.Text, txtCpf.Text, txtRg.Text, txtTelefone.Text, Convert.ToDateTime(txtDtNascimento), endereco);

                if (cliente.IsValid)
                {
                    try
                    {
                        _clienteService.AlterarCliente(cliente);
                        MessageBox.Show("Pessoa alterado com sucesso!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.EventoClickLimpar(sender, e);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Campos obrigatórios!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Primeiro pesquise por algum CPF, para alterar registros.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void EventoClickExcluir(object sender, EventArgs e)
        {
            string texto = "Deseja realmente excluir o registro ?";
            string titulo = "Excluir";
            string cpf = txtCpf.Text;

            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                try
                {
                    _clienteService.DeletarCliente(cpf);
                    MessageBox.Show("Excluido com Sucesso!", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.EventoClickLimpar(sender, e);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListaClientes f = new ListaClientes();

            f.Show();
        }        

        private void EventoClickTxtCpf(object sender, EventArgs e)
        {
            labelCpf.Text = "";
        }

        private void EventoCpfClick(object sender, EventArgs e)
        {
            labelCpf.Text = "";
        }

        private void EventoPctCep(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                try
                {
                    var endereco = ws.consultaCEP(txtCep.Text.Trim());
                    Endereco enderecoConsulta = new Endereco(endereco.end, endereco.bairro, endereco.cidade, txtCep.Text, (Uf)Enum.Parse(typeof(Uf), endereco.uf, true));
                    this.PreencherDadosEnderecoForm(enderecoConsulta);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else            
                MessageBox.Show("Informe um CEP para pesquisar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
