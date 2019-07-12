using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;



namespace PimdexxSystem
{
    public partial class Produtos : Form
    {

        private string _strConn = @"Data Source = DESKTOP - PIKVREV\SQLEXPRESS;Initial Catalog = PDBASE; Integrated Security = True";

        SqlConnection objtConect = null;

        SqlCommand objCommand = null;


        public Produtos()
        {
            InitializeComponent();
        }

        private void Veiculos_Load(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void ListaGrid()
        {
            



        }

     
     

     

   
      

    

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
