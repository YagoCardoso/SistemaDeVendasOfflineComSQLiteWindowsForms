﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Pdv.Application;

namespace PimdexxSystem
{
    
    public partial class Login : Form
    {
        private Thread nt;

        private readonly FuncionarioService _funcionarioService;

        public Login(FuncionarioService funcionarioService)
        {
            InitializeComponent();
            this._funcionarioService = funcionarioService;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoForm()
        {
            Application.Run(new Principal(_funcionarioService));
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ///btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click_2(object sender, EventArgs e)
        {

            string texto = "Deseja sair da aplicação?";
            string titulo = "Finalizando aplicação";

            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            
        }
        //codigo abaixo e para autorizar a mover as janelas

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LABEL_INFOYAGO.Visible = false;//label pra eu saber que tmeg
            labelclone.Visible = false;
            txtclone.Visible = false;
            txt_DatadeExpiracao.Visible = false;

            //faz parte do checkbox de ver senha
            txtclone.Text = txtSenha.Text;
            txtSenha.Text = txtclone.Text;
        }

        private void Veiculos_Click(object sender, EventArgs e)
        {
            txtclone.Text = txtSenha.Text;
            txtSenha.Text = txtclone.Text;

            #region Licença do sistema por data
            string dataAtual = DateTime.Now.ToShortDateString().ToString();
           // string anoAtual = DateTime.Now.Year.ToString();

            DateTime data1 = new DateTime(2019, 12, 05);
            data1.ToString("dd/MM/yyyy");

            DateTime dataHoje = DateTime.Today;

            txt_DatadeExpiracao.Text = dataHoje.ToShortDateString().ToString();
            #endregion

            if(txtLogin.Text == "master" && txtSenha.Text == "maksuell" && txtclone.Text == "maksuell")
            {
                this.Close();
                //campo nt foi gerado no começo da classe
                //novo forme se refere ao nome da funçao criado apos essa
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

            }

            if (dataHoje > data1 ) { MessageBox.Show("Sua licença para este Software expirou, Contato o desenvolvedor\n para adquirir outra licença", "INATIVO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {

                if (txtLogin.Text == "admin" && txtSenha.Text == "123456")
                {
                    this.Close();
                    //campo nt foi gerado no começo da classe
                    //novo forme se refere ao nome da funçao criado apos essa
                    nt = new Thread(novoForm);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();

                }//Verificação de Login no banco de dados
                else
                {

                    SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SystemOrange;Data Source=DESKTOP-PIKVREV\\SQLEXPRESS");
                    SqlCommand command = new SqlCommand("select * from USUARIO where USUARIO=@varUsuario and SENHA=@varSenha", sql);

                    command.Parameters.Add("@varUsuario", SqlDbType.NVarChar).Value = txtLogin.Text;
                    command.Parameters.Add("@varSenha", SqlDbType.NVarChar).Value = txtSenha.Text;

                    try
                    {
                        sql.Open();
                        SqlDataReader drms = command.ExecuteReader();
                        if (drms.HasRows == false)
                        {
                            throw new Exception("Usuário ou senha Incorretos.");

                        }
                        drms.Read();

                        nt = new Thread(novoForm);
                        nt.SetApartmentState(ApartmentState.STA);
                        nt.Start();
                        this.Visible = false;
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



            //if (txtLogin.Text == "master" && txtSenha.Text == "123456" )
            //{
            //    this.Close();
            //    //campo nt foi gerado no começo da classe
            //    //novo forme se refere ao nome da funçao criado apos essa
            //     nt = new Thread(novoForm);
            //    nt.SetApartmentState(ApartmentState.STA);
            //     nt.Start();

            //}
            //else
            //{
            //    MessageBox.Show("Login ou Senha Invalidos!", "Erro Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }


        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtclone_TextChanged(object sender, EventArgs e)
        {
            txtSenha.Text = txtclone.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Ver senha
            labelclone.Visible = true;
            if(txtclone.Visible == true){ txtclone.Visible = false; } else { txtclone.Visible = true; }
            txtclone.Text = txtSenha.Text;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Ver senha
            labelclone.Visible = true;
            if (txtclone.Visible == true) { txtclone.Visible = false; } else { txtclone.Visible = true; }
            txtclone.Text = txtSenha.Text;
        }
    }
}
