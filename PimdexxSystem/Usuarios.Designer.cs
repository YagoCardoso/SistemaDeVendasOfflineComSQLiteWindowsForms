namespace PimdexxSystem
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.btn_SalvarNovo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txt_CEP = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblDataDesligamento = new System.Windows.Forms.Label();
            this.cboxTipoAcesso = new System.Windows.Forms.ComboBox();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.txtDataDesligamento = new System.Windows.Forms.DateTimePicker();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.LABEL_CPF = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.systemOrangeDataSet11 = new PimdexxSystem.SystemOrangeDataSet11();
            this.UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsuarioTableAdapter = new PimdexxSystem.SystemOrangeDataSet11TableAdapters.USUARIOTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SalvarNovo
            // 
            this.btn_SalvarNovo.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_SalvarNovo.FlatAppearance.BorderSize = 0;
            this.btn_SalvarNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_SalvarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalvarNovo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarNovo.ForeColor = System.Drawing.Color.White;
            this.btn_SalvarNovo.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalvarNovo.Image")));
            this.btn_SalvarNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SalvarNovo.Location = new System.Drawing.Point(3, 635);
            this.btn_SalvarNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SalvarNovo.Name = "btn_SalvarNovo";
            this.btn_SalvarNovo.Size = new System.Drawing.Size(246, 60);
            this.btn_SalvarNovo.TabIndex = 143;
            this.btn_SalvarNovo.Text = "Adicionar Novo";
            this.btn_SalvarNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SalvarNovo.UseVisualStyleBackColor = false;
            this.btn_SalvarNovo.Click += new System.EventHandler(this.EventoClickSalvarFuncionario);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-2, 3);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 72);
            this.button4.TabIndex = 142;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.EventoClickPesquisarFuncionario);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Orange;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(227, 3);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(216, 72);
            this.button6.TabIndex = 141;
            this.button6.Text = "Alterar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.EventoClickAlterarFuncionario);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(460, 3);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(216, 72);
            this.button7.TabIndex = 140;
            this.button7.Text = "Limpar ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.EventoLimparClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(692, 3);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(212, 72);
            this.button8.TabIndex = 139;
            this.button8.Text = "Excluir";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.EventoClickExcluirFuncionario);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(3, 198);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(553, 29);
            this.txtNome.TabIndex = 144;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(464, 258);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(388, 26);
            this.txtRua.TabIndex = 145;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(862, 258);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(277, 26);
            this.txtBairro.TabIndex = 146;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(249, 320);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(300, 29);
            this.txtCidade.TabIndex = 147;
            // 
            // txt_CEP
            // 
            this.txt_CEP.Location = new System.Drawing.Point(3, 320);
            this.txt_CEP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CEP.Multiline = true;
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(235, 29);
            this.txt_CEP.TabIndex = 148;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(560, 320);
            this.txtUf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUf.Multiline = true;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(84, 29);
            this.txtUf.TabIndex = 149;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(3, 258);
            this.txtRg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(232, 26);
            this.txtRg.TabIndex = 151;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(244, 258);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(212, 26);
            this.txtTelefone.TabIndex = 152;
            this.txtTelefone.Text = "( )";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(756, 446);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(157, 26);
            this.txtSalario.TabIndex = 153;
            this.txtSalario.Text = "EX:  R$ 000,00";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(-1, 172);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(159, 21);
            this.lblNome.TabIndex = 157;
            this.lblNome.Text = "Nome Completo*";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(3, 235);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(45, 21);
            this.lblRg.TabIndex = 158;
            this.lblRg.Text = "RG*";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(925, 175);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(54, 21);
            this.lblCpf.TabIndex = 159;
            this.lblCpf.Text = "CPF*";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(555, 297);
            this.lblUf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(35, 21);
            this.lblUf.TabIndex = 160;
            this.lblUf.Text = "UF";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(3, 297);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(47, 21);
            this.lblCep.TabIndex = 161;
            this.lblCep.Text = "CEP";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(244, 297);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(72, 21);
            this.lblCidade.TabIndex = 162;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(858, 234);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(66, 21);
            this.lblBairro.TabIndex = 163;
            this.lblBairro.Text = "Bairro";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(464, 235);
            this.lblRua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(96, 21);
            this.lblRua.TabIndex = 164;
            this.lblRua.Text = "Endereço";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(756, 423);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(73, 21);
            this.lblSalario.TabIndex = 165;
            this.lblSalario.Text = "Salário";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(244, 234);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(54, 21);
            this.lblTelefone.TabIndex = 166;
            this.lblTelefone.Text = "Fone";
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAdmissao.Location = new System.Drawing.Point(3, 420);
            this.lblDataAdmissao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(168, 21);
            this.lblDataAdmissao.TabIndex = 167;
            this.lblDataAdmissao.Text = "Data de admissão";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(16, 560);
            this.lblTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(147, 21);
            this.lblTipoUsuario.TabIndex = 168;
            this.lblTipoUsuario.Text = "Tipo de usuário";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            this.panel1.TabIndex = 169;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(50, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 21);
            this.label13.TabIndex = 170;
            this.label13.Text = "Dados Pessoais";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(460, 566);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(66, 21);
            this.lblSenha.TabIndex = 172;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(464, 588);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(247, 26);
            this.txtSenha.TabIndex = 171;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(254, 588);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(199, 26);
            this.txtUsuario.TabIndex = 170;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(0, 505);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 35);
            this.panel2.TabIndex = 171;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(50, 8);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 21);
            this.label15.TabIndex = 170;
            this.label15.Text = "Dados para acesso";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(252, 566);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 21);
            this.lblUsuario.TabIndex = 173;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(563, 175);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(186, 21);
            this.lblDataNascimento.TabIndex = 175;
            this.lblDataNascimento.Text = "Data de nascimento";
            // 
            // lblDataDesligamento
            // 
            this.lblDataDesligamento.AutoSize = true;
            this.lblDataDesligamento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDesligamento.Location = new System.Drawing.Point(357, 425);
            this.lblDataDesligamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDesligamento.Name = "lblDataDesligamento";
            this.lblDataDesligamento.Size = new System.Drawing.Size(202, 21);
            this.lblDataDesligamento.TabIndex = 177;
            this.lblDataDesligamento.Text = "Data de desligamento";
            // 
            // cboxTipoAcesso
            // 
            this.cboxTipoAcesso.FormattingEnabled = true;
            this.cboxTipoAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Funcionario"});
            this.cboxTipoAcesso.Location = new System.Drawing.Point(21, 586);
            this.cboxTipoAcesso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxTipoAcesso.Name = "cboxTipoAcesso";
            this.cboxTipoAcesso.Size = new System.Drawing.Size(206, 28);
            this.cboxTipoAcesso.TabIndex = 178;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(567, 198);
            this.txtDataNascimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(350, 26);
            this.txtDataNascimento.TabIndex = 179;
            // 
            // txtDataAdmissao
            // 
            this.txtDataAdmissao.Location = new System.Drawing.Point(8, 446);
            this.txtDataAdmissao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataAdmissao.Name = "txtDataAdmissao";
            this.txtDataAdmissao.Size = new System.Drawing.Size(343, 26);
            this.txtDataAdmissao.TabIndex = 180;
            // 
            // txtDataDesligamento
            // 
            this.txtDataDesligamento.Location = new System.Drawing.Point(362, 446);
            this.txtDataDesligamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataDesligamento.Name = "txtDataDesligamento";
            this.txtDataDesligamento.Size = new System.Drawing.Size(349, 26);
            this.txtDataDesligamento.TabIndex = 181;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(928, 198);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCpf.MaxLength = 12;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(211, 26);
            this.txtCpf.TabIndex = 183;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(0, 360);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 35);
            this.panel3.TabIndex = 171;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(50, 8);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(195, 21);
            this.label19.TabIndex = 170;
            this.label19.Text = "Dados para empresa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(987, 603);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 213;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(933, 577);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(239, 21);
            this.label20.TabIndex = 214;
            this.label20.Text = "Ver usuários cadastrados";
            // 
            // LABEL_CPF
            // 
            this.LABEL_CPF.AutoSize = true;
            this.LABEL_CPF.BackColor = System.Drawing.Color.White;
            this.LABEL_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CPF.Location = new System.Drawing.Point(946, 205);
            this.LABEL_CPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LABEL_CPF.Name = "LABEL_CPF";
            this.LABEL_CPF.Size = new System.Drawing.Size(170, 17);
            this.LABEL_CPF.TabIndex = 215;
            this.LABEL_CPF.Text = "  Digite apenas numeros..";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(722, 451);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 21);
            this.label21.TabIndex = 216;
            this.label21.Text = "R$";
            // 
            // systemOrangeDataSet11
            // 
            this.systemOrangeDataSet11.DataSetName = "SystemOrangeDataSet11";
            this.systemOrangeDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsuarioBindingSource
            // 
            this.UsuarioBindingSource.DataMember = "USUARIO";
            this.UsuarioBindingSource.DataSource = this.systemOrangeDataSet11;
            // 
            // UsuarioTableAdapter
            // 
            this.UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleName = "";
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(206, 322);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 218;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1500, 769);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.LABEL_CPF);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtDataDesligamento);
            this.Controls.Add(this.txtDataAdmissao);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.cboxTipoAcesso);
            this.Controls.Add(this.lblDataDesligamento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblDataAdmissao);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btn_SalvarNovo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Usuarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SalvarNovo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txt_CEP;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblDataDesligamento;
        private System.Windows.Forms.ComboBox cboxTipoAcesso;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.DateTimePicker txtDataAdmissao;
        private System.Windows.Forms.DateTimePicker txtDataDesligamento;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label LABEL_CPF;
        private System.Windows.Forms.Label label21;
        private SystemOrangeDataSet11 systemOrangeDataSet11;
        private System.Windows.Forms.BindingSource UsuarioBindingSource;
        private SystemOrangeDataSet11TableAdapters.USUARIOTableAdapter UsuarioTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}