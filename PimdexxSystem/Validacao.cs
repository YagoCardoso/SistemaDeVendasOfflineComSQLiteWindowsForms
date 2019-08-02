using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace validaocampos
{
    public class Validacao : TextBox
    {
        




        //limpar controle quando pressiona tecla esc
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
                this.Text = "";
        }

        //quando recver o foco vai seleciona todo texto contido e ira colorir tudo de vermelho
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.SelectAll();
            this.BackColor = Color.OrangeRed;
        }
        //quando perder o foco ira voltar a ser branco
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.White;
        }

        //quando  controle for criado
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
        }

        //nao permitira a entrada de letras
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == 8)
                return;
            //se for diferente de um numero nao escrevera
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Apenas números");
            }
        }

        internal void campoVazio()
        {
            throw new NotImplementedException();
        }
    }



}
