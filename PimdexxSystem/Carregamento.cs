using Pdv.Application;
using Pdv.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimdexxSystem
{
    public partial class Carregamento : Form
    {
        private readonly FuncionarioService _funcionarioService;

        public Carregamento(FuncionarioService funcionarioService)
        {
            InitializeComponent();
            this._funcionarioService = funcionarioService;
        }

        private void Carregamento_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                Login log = new Login(_funcionarioService);
                log.Show();
                this.Visible = false;
            }
        }
    }
}
