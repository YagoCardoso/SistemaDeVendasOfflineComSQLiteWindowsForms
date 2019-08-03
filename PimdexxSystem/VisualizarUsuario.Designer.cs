namespace PimdexxSystem
{
    partial class VisualizarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarUsuario));
            this.GridVisualizarUsuario = new System.Windows.Forms.DataGridView();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTNASCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIRRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOUSUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTADMISSAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTDESLIGAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemOrangeDataSet9 = new PimdexxSystem.SystemOrangeDataSet9();
            this.uSUARIOTableAdapter = new PimdexxSystem.SystemOrangeDataSet9TableAdapters.USUARIOTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridVisualizarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // GridVisualizarUsuario
            // 
            this.GridVisualizarUsuario.AllowUserToAddRows = false;
            this.GridVisualizarUsuario.AllowUserToDeleteRows = false;
            this.GridVisualizarUsuario.AutoGenerateColumns = false;
            this.GridVisualizarUsuario.BackgroundColor = System.Drawing.Color.White;
            this.GridVisualizarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVisualizarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVisualizarUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPFDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.dTNASCIMENTODataGridViewTextBoxColumn,
            this.eNDERECODataGridViewTextBoxColumn,
            this.bAIRRODataGridViewTextBoxColumn,
            this.cIDADEDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.fONEDataGridViewTextBoxColumn,
            this.sALARIODataGridViewTextBoxColumn,
            this.tIPOUSUDataGridViewTextBoxColumn,
            this.dTADMISSAODataGridViewTextBoxColumn,
            this.dTDESLIGAMENTODataGridViewTextBoxColumn,
            this.uSUARIODataGridViewTextBoxColumn,
            this.sENHADataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn});
            this.GridVisualizarUsuario.DataSource = this.uSUARIOBindingSource;
            this.GridVisualizarUsuario.Location = new System.Drawing.Point(12, 25);
            this.GridVisualizarUsuario.Name = "GridVisualizarUsuario";
            this.GridVisualizarUsuario.ReadOnly = true;
            this.GridVisualizarUsuario.Size = new System.Drawing.Size(1167, 313);
            this.GridVisualizarUsuario.TabIndex = 0;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTNASCIMENTODataGridViewTextBoxColumn
            // 
            this.dTNASCIMENTODataGridViewTextBoxColumn.DataPropertyName = "DTNASCIMENTO";
            this.dTNASCIMENTODataGridViewTextBoxColumn.HeaderText = "DATA DE NASCIMENTO";
            this.dTNASCIMENTODataGridViewTextBoxColumn.Name = "dTNASCIMENTODataGridViewTextBoxColumn";
            this.dTNASCIMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNDERECODataGridViewTextBoxColumn
            // 
            this.eNDERECODataGridViewTextBoxColumn.DataPropertyName = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.HeaderText = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.Name = "eNDERECODataGridViewTextBoxColumn";
            this.eNDERECODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bAIRRODataGridViewTextBoxColumn
            // 
            this.bAIRRODataGridViewTextBoxColumn.DataPropertyName = "BAIRRO";
            this.bAIRRODataGridViewTextBoxColumn.HeaderText = "BAIRRO";
            this.bAIRRODataGridViewTextBoxColumn.Name = "bAIRRODataGridViewTextBoxColumn";
            this.bAIRRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            this.cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            this.cIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            this.rGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fONEDataGridViewTextBoxColumn
            // 
            this.fONEDataGridViewTextBoxColumn.DataPropertyName = "FONE";
            this.fONEDataGridViewTextBoxColumn.HeaderText = "FONE";
            this.fONEDataGridViewTextBoxColumn.Name = "fONEDataGridViewTextBoxColumn";
            this.fONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALARIODataGridViewTextBoxColumn
            // 
            this.sALARIODataGridViewTextBoxColumn.DataPropertyName = "SALARIO";
            this.sALARIODataGridViewTextBoxColumn.HeaderText = "SALARIO";
            this.sALARIODataGridViewTextBoxColumn.Name = "sALARIODataGridViewTextBoxColumn";
            this.sALARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPOUSUDataGridViewTextBoxColumn
            // 
            this.tIPOUSUDataGridViewTextBoxColumn.DataPropertyName = "TIPOUSU";
            this.tIPOUSUDataGridViewTextBoxColumn.HeaderText = "TIPO DE USUÁRIO";
            this.tIPOUSUDataGridViewTextBoxColumn.Name = "tIPOUSUDataGridViewTextBoxColumn";
            this.tIPOUSUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTADMISSAODataGridViewTextBoxColumn
            // 
            this.dTADMISSAODataGridViewTextBoxColumn.DataPropertyName = "DTADMISSAO";
            this.dTADMISSAODataGridViewTextBoxColumn.HeaderText = "DATA ADMISSAO";
            this.dTADMISSAODataGridViewTextBoxColumn.Name = "dTADMISSAODataGridViewTextBoxColumn";
            this.dTADMISSAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTDESLIGAMENTODataGridViewTextBoxColumn
            // 
            this.dTDESLIGAMENTODataGridViewTextBoxColumn.DataPropertyName = "DTDESLIGAMENTO";
            this.dTDESLIGAMENTODataGridViewTextBoxColumn.HeaderText = "DATA DESLIGAMENTO";
            this.dTDESLIGAMENTODataGridViewTextBoxColumn.Name = "dTDESLIGAMENTODataGridViewTextBoxColumn";
            this.dTDESLIGAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSUARIODataGridViewTextBoxColumn
            // 
            this.uSUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.Name = "uSUARIODataGridViewTextBoxColumn";
            this.uSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sENHADataGridViewTextBoxColumn
            // 
            this.sENHADataGridViewTextBoxColumn.DataPropertyName = "SENHA";
            this.sENHADataGridViewTextBoxColumn.HeaderText = "SENHA";
            this.sENHADataGridViewTextBoxColumn.Name = "sENHADataGridViewTextBoxColumn";
            this.sENHADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            this.uFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.systemOrangeDataSet9;
            // 
            // systemOrangeDataSet9
            // 
            this.systemOrangeDataSet9.DataSetName = "SystemOrangeDataSet9";
            this.systemOrangeDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
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
            this.button2.Location = new System.Drawing.Point(996, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 41);
            this.button2.TabIndex = 144;
            this.button2.Text = "    Exportar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VisualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 413);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridVisualizarUsuario);
            this.Name = "VisualizarUsuario";
            this.Text = "VisualizarUsuario";
            this.Load += new System.EventHandler(this.VisualizarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVisualizarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridVisualizarUsuario;
        private SystemOrangeDataSet9 systemOrangeDataSet9;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private SystemOrangeDataSet9TableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTNASCIMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIRRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOUSUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTADMISSAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTDESLIGAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sENHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}