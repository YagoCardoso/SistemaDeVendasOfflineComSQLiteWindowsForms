using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PimdexxSystem
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        

        private void Fechar_Click(object sender, EventArgs e)
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            AbrirFormInPanel(new Produtos());
          // btn_Contas_TelaInicial.Visible = false;
          // Btn_EfetuarVenda_Telainicial.Visible = false;


        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panelContendor_Paint(object sender, PaintEventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
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
        //função que abre novo form dentro do painel do form inicial
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.painel_TelaInicial.Controls.Count > 0)
                this.painel_TelaInicial.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.painel_TelaInicial.Controls.Add(fh);
            this.painel_TelaInicial.Tag = fh;
            fh.Show();
        }

      

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Usuarios());
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMotorista_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Clientes());
        }

        private void btnSeguros_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Relatorios());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void painelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void painel_TelaInicial_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Produtos());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            AbrirFormInPanel(new Categorias());
          // btn_Contas_TelaInicial.Visible = false;
          // Btn_EfetuarVenda_Telainicial.Visible = false;
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.Show();
           // AbrirFormInPanel(new Venda());
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnPecas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ConsultarProdutos());
        }
    }
}
