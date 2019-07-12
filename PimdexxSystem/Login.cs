using System;
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

namespace PimdexxSystem
{
    public partial class Login : Form
    {
        private Thread nt;

        public Login()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (txtLogin.Text == "pimdexx" && txtSenha.Text == "123456")
            {
                this.Close();
                //campo nt foi gerado no começo da classe
                //novo forme se refere ao nome da funçao criado apos essa
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Login ou Senha Invalidos!", "Erro Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          

        }
        private void novoForm()
        {
            Application.Run(new Principal());
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

        private void Veiculos_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "123456")
            {
                this.Close();
                //campo nt foi gerado no começo da classe
                //novo forme se refere ao nome da funçao criado apos essa
                 nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                 nt.Start();
              
            }
            else
            {
                MessageBox.Show("Login ou Senha Invalidos!", "Erro Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "123456")
            {
                this.Close();
                //campo nt foi gerado no começo da classe
                //novo forme se refere ao nome da funçao criado apos essa
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

            }
            else
            {
                MessageBox.Show("Login ou Senha Invalidos!", "Erro Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
