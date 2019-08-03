namespace PimdexxSystem
{
    partial class ConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.systemOrangeDataSet12 = new PimdexxSystem.SystemOrangeDataSet12();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new PimdexxSystem.SystemOrangeDataSet12TableAdapters.USUARIOTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.uSUARIOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1082, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // systemOrangeDataSet12
            // 
            this.systemOrangeDataSet12.DataSetName = "SystemOrangeDataSet12";
            this.systemOrangeDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.systemOrangeDataSet12;
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
            this.button2.Location = new System.Drawing.Point(921, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 41);
            this.button2.TabIndex = 145;
            this.button2.Text = "    Exportar ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            // 
            // dTNASCIMENTODataGridViewTextBoxColumn
            // 
            this.dTNASCIMENTODataGridViewTextBoxColumn.DataPropertyName = "DTNASCIMENTO";
            this.dTNASCIMENTODataGridViewTextBoxColumn.HeaderText = "DATA NASCIMENTO";
            this.dTNASCIMENTODataGridViewTextBoxColumn.Name = "dTNASCIMENTODataGridViewTextBoxColumn";
            // 
            // eNDERECODataGridViewTextBoxColumn
            // 
            this.eNDERECODataGridViewTextBoxColumn.DataPropertyName = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.HeaderText = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.Name = "eNDERECODataGridViewTextBoxColumn";
            // 
            // bAIRRODataGridViewTextBoxColumn
            // 
            this.bAIRRODataGridViewTextBoxColumn.DataPropertyName = "BAIRRO";
            this.bAIRRODataGridViewTextBoxColumn.HeaderText = "BAIRRO";
            this.bAIRRODataGridViewTextBoxColumn.Name = "bAIRRODataGridViewTextBoxColumn";
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            this.cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            // 
            // fONEDataGridViewTextBoxColumn
            // 
            this.fONEDataGridViewTextBoxColumn.DataPropertyName = "FONE";
            this.fONEDataGridViewTextBoxColumn.HeaderText = "FONE";
            this.fONEDataGridViewTextBoxColumn.Name = "fONEDataGridViewTextBoxColumn";
            // 
            // sALARIODataGridViewTextBoxColumn
            // 
            this.sALARIODataGridViewTextBoxColumn.DataPropertyName = "SALARIO";
            this.sALARIODataGridViewTextBoxColumn.HeaderText = "SALARIO";
            this.sALARIODataGridViewTextBoxColumn.Name = "sALARIODataGridViewTextBoxColumn";
            // 
            // tIPOUSUDataGridViewTextBoxColumn
            // 
            this.tIPOUSUDataGridViewTextBoxColumn.DataPropertyName = "TIPOUSU";
            this.tIPOUSUDataGridViewTextBoxColumn.HeaderText = "TIPOUSU";
            this.tIPOUSUDataGridViewTextBoxColumn.Name = "tIPOUSUDataGridViewTextBoxColumn";
            // 
            // dTADMISSAODataGridViewTextBoxColumn
            // 
            this.dTADMISSAODataGridViewTextBoxColumn.DataPropertyName = "DTADMISSAO";
            this.dTADMISSAODataGridViewTextBoxColumn.HeaderText = "DATA ADMISSAO";
            this.dTADMISSAODataGridViewTextBoxColumn.Name = "dTADMISSAODataGridViewTextBoxColumn";
            // 
            // dTDESLIGAMENTODataGridViewTextBoxColumn
            // 
            this.dTDESLIGAMENTODataGridViewTextBoxColumn.DataPropertyName = "DTDESLIGAMENTO";
            this.dTDESLIGAMENTODataGridViewTextBoxColumn.HeaderText = "DATA DESLIGAMENTO";
            this.dTDESLIGAMENTODataGridViewTextBoxColumn.Name = "dTDESLIGAMENTODataGridViewTextBoxColumn";
            // 
            // uSUARIODataGridViewTextBoxColumn
            // 
            this.uSUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.Name = "uSUARIODataGridViewTextBoxColumn";
            // 
            // sENHADataGridViewTextBoxColumn
            // 
            this.sENHADataGridViewTextBoxColumn.DataPropertyName = "SENHA";
            this.sENHADataGridViewTextBoxColumn.HeaderText = "SENHA";
            this.sENHADataGridViewTextBoxColumn.Name = "sENHADataGridViewTextBoxColumn";
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarUsuario";
            this.Text = "ConsultarUsuario";
            this.Load += new System.EventHandler(this.ConsultarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SystemOrangeDataSet12 systemOrangeDataSet12;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private SystemOrangeDataSet12TableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private System.Windows.Forms.Button button2;
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
    }
}