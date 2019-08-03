namespace PimdexxSystem
{
    partial class ConsultarVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVendas));
            this.systemOrangeDataSet7 = new PimdexxSystem.SystemOrangeDataSet7();
            this.vENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDATableAdapter = new PimdexxSystem.SystemOrangeDataSet7TableAdapters.VENDATableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.GridVendaRealizada = new System.Windows.Forms.DataGridView();
            this.sEQCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPPAGAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALCOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.systemOrangeDataSet8 = new PimdexxSystem.SystemOrangeDataSet8();
            this.vENDATableAdapter1 = new PimdexxSystem.SystemOrangeDataSet8TableAdapters.VENDATableAdapter();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.TXT_COD = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendaRealizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // systemOrangeDataSet7
            // 
            this.systemOrangeDataSet7.DataSetName = "SystemOrangeDataSet7";
            this.systemOrangeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENDABindingSource
            // 
            this.vENDABindingSource.DataMember = "VENDA";
            this.vENDABindingSource.DataSource = this.systemOrangeDataSet7;
            // 
            // vENDATableAdapter
            // 
            this.vENDATableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendas Realizadas";
            // 
            // GridVendaRealizada
            // 
            this.GridVendaRealizada.AutoGenerateColumns = false;
            this.GridVendaRealizada.BackgroundColor = System.Drawing.Color.White;
            this.GridVendaRealizada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVendaRealizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVendaRealizada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sEQCAIXADataGridViewTextBoxColumn,
            this.cLIENTEDataGridViewTextBoxColumn,
            this.tPPAGAMENTODataGridViewTextBoxColumn,
            this.tOTALVENDADataGridViewTextBoxColumn,
            this.dESCONTODataGridViewTextBoxColumn,
            this.tOTALCOMPRADataGridViewTextBoxColumn,
            this.dATADataGridViewTextBoxColumn});
            this.GridVendaRealizada.DataSource = this.vENDABindingSource1;
            this.GridVendaRealizada.Location = new System.Drawing.Point(12, 153);
            this.GridVendaRealizada.Name = "GridVendaRealizada";
            this.GridVendaRealizada.Size = new System.Drawing.Size(741, 221);
            this.GridVendaRealizada.TabIndex = 3;
            this.GridVendaRealizada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVendaRealizada_CellContentClick);
            // 
            // sEQCAIXADataGridViewTextBoxColumn
            // 
            this.sEQCAIXADataGridViewTextBoxColumn.DataPropertyName = "SEQCAIXA";
            this.sEQCAIXADataGridViewTextBoxColumn.HeaderText = "Nº Venda";
            this.sEQCAIXADataGridViewTextBoxColumn.Name = "sEQCAIXADataGridViewTextBoxColumn";
            this.sEQCAIXADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTEDataGridViewTextBoxColumn
            // 
            this.cLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.cLIENTEDataGridViewTextBoxColumn.Name = "cLIENTEDataGridViewTextBoxColumn";
            // 
            // tPPAGAMENTODataGridViewTextBoxColumn
            // 
            this.tPPAGAMENTODataGridViewTextBoxColumn.DataPropertyName = "TPPAGAMENTO";
            this.tPPAGAMENTODataGridViewTextBoxColumn.HeaderText = "Forma de Pagamento";
            this.tPPAGAMENTODataGridViewTextBoxColumn.Name = "tPPAGAMENTODataGridViewTextBoxColumn";
            // 
            // tOTALVENDADataGridViewTextBoxColumn
            // 
            this.tOTALVENDADataGridViewTextBoxColumn.DataPropertyName = "TOTALVENDA";
            this.tOTALVENDADataGridViewTextBoxColumn.HeaderText = "Venda Liquida";
            this.tOTALVENDADataGridViewTextBoxColumn.Name = "tOTALVENDADataGridViewTextBoxColumn";
            // 
            // dESCONTODataGridViewTextBoxColumn
            // 
            this.dESCONTODataGridViewTextBoxColumn.DataPropertyName = "DESCONTO";
            this.dESCONTODataGridViewTextBoxColumn.HeaderText = "%Desconto";
            this.dESCONTODataGridViewTextBoxColumn.Name = "dESCONTODataGridViewTextBoxColumn";
            // 
            // tOTALCOMPRADataGridViewTextBoxColumn
            // 
            this.tOTALCOMPRADataGridViewTextBoxColumn.DataPropertyName = "TOTALCOMPRA";
            this.tOTALCOMPRADataGridViewTextBoxColumn.HeaderText = "Venda Bruta";
            this.tOTALCOMPRADataGridViewTextBoxColumn.Name = "tOTALCOMPRADataGridViewTextBoxColumn";
            // 
            // dATADataGridViewTextBoxColumn
            // 
            this.dATADataGridViewTextBoxColumn.DataPropertyName = "DATA";
            this.dATADataGridViewTextBoxColumn.HeaderText = "Data";
            this.dATADataGridViewTextBoxColumn.Name = "dATADataGridViewTextBoxColumn";
            // 
            // vENDABindingSource1
            // 
            this.vENDABindingSource1.DataMember = "VENDA";
            this.vENDABindingSource1.DataSource = this.systemOrangeDataSet8;
            // 
            // systemOrangeDataSet8
            // 
            this.systemOrangeDataSet8.DataSetName = "SystemOrangeDataSet8";
            this.systemOrangeDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENDATableAdapter1
            // 
            this.vENDATableAdapter1.ClearBeforeFill = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(558, 41);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(144, 36);
            this.BtnExcluir.TabIndex = 131;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // TXT_COD
            // 
            this.TXT_COD.Location = new System.Drawing.Point(558, 15);
            this.TXT_COD.Name = "TXT_COD";
            this.TXT_COD.Size = new System.Drawing.Size(195, 20);
            this.TXT_COD.TabIndex = 132;
            this.TXT_COD.Text = "Digite o numero aqui para excluir..";
            this.TXT_COD.Click += new System.EventHandler(this.TXT_COD_Click);
            this.TXT_COD.TextChanged += new System.EventHandler(this.TXT_COD_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(618, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 32);
            this.button2.TabIndex = 144;
            this.button2.Text = "    Exportar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConsultarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(968, 422);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TXT_COD);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.GridVendaRealizada);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarVendas";
            this.Text = "ConsultarVendas";
            this.Load += new System.EventHandler(this.ConsultarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendaRealizada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SystemOrangeDataSet7 systemOrangeDataSet7;
        private System.Windows.Forms.BindingSource vENDABindingSource;
        private SystemOrangeDataSet7TableAdapters.VENDATableAdapter vENDATableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridVendaRealizada;
        private SystemOrangeDataSet8 systemOrangeDataSet8;
        private System.Windows.Forms.BindingSource vENDABindingSource1;
        private SystemOrangeDataSet8TableAdapters.VENDATableAdapter vENDATableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEQCAIXADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPPAGAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALCOMPRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TXT_COD;
        private System.Windows.Forms.Button button2;
    }
}