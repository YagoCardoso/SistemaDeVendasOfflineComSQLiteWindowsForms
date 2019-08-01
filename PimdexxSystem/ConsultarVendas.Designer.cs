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
            this.systemOrangeDataSet7 = new PimdexxSystem.SystemOrangeDataSet7();
            this.vENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDATableAdapter = new PimdexxSystem.SystemOrangeDataSet7TableAdapters.VENDATableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.systemOrangeDataSet8 = new PimdexxSystem.SystemOrangeDataSet8();
            this.vENDABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vENDATableAdapter1 = new PimdexxSystem.SystemOrangeDataSet8TableAdapters.VENDATableAdapter();
            this.sEQCAIXADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPPAGAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALCOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDABindingSource1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendas Realizadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sEQCAIXADataGridViewTextBoxColumn,
            this.cLIENTEDataGridViewTextBoxColumn,
            this.tPPAGAMENTODataGridViewTextBoxColumn,
            this.tOTALVENDADataGridViewTextBoxColumn,
            this.dESCONTODataGridViewTextBoxColumn,
            this.tOTALCOMPRADataGridViewTextBoxColumn,
            this.dATADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vENDABindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 337);
            this.dataGridView1.TabIndex = 3;
            // 
            // systemOrangeDataSet8
            // 
            this.systemOrangeDataSet8.DataSetName = "SystemOrangeDataSet8";
            this.systemOrangeDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENDABindingSource1
            // 
            this.vENDABindingSource1.DataMember = "VENDA";
            this.vENDABindingSource1.DataSource = this.systemOrangeDataSet8;
            // 
            // vENDATableAdapter1
            // 
            this.vENDATableAdapter1.ClearBeforeFill = true;
            // 
            // sEQCAIXADataGridViewTextBoxColumn
            // 
            this.sEQCAIXADataGridViewTextBoxColumn.DataPropertyName = "SEQCAIXA";
            this.sEQCAIXADataGridViewTextBoxColumn.HeaderText = "SEQCAIXA";
            this.sEQCAIXADataGridViewTextBoxColumn.Name = "sEQCAIXADataGridViewTextBoxColumn";
            this.sEQCAIXADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTEDataGridViewTextBoxColumn
            // 
            this.cLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE";
            this.cLIENTEDataGridViewTextBoxColumn.Name = "cLIENTEDataGridViewTextBoxColumn";
            // 
            // tPPAGAMENTODataGridViewTextBoxColumn
            // 
            this.tPPAGAMENTODataGridViewTextBoxColumn.DataPropertyName = "TPPAGAMENTO";
            this.tPPAGAMENTODataGridViewTextBoxColumn.HeaderText = "TPPAGAMENTO";
            this.tPPAGAMENTODataGridViewTextBoxColumn.Name = "tPPAGAMENTODataGridViewTextBoxColumn";
            // 
            // tOTALVENDADataGridViewTextBoxColumn
            // 
            this.tOTALVENDADataGridViewTextBoxColumn.DataPropertyName = "TOTALVENDA";
            this.tOTALVENDADataGridViewTextBoxColumn.HeaderText = "TOTALVENDA";
            this.tOTALVENDADataGridViewTextBoxColumn.Name = "tOTALVENDADataGridViewTextBoxColumn";
            // 
            // dESCONTODataGridViewTextBoxColumn
            // 
            this.dESCONTODataGridViewTextBoxColumn.DataPropertyName = "DESCONTO";
            this.dESCONTODataGridViewTextBoxColumn.HeaderText = "DESCONTO";
            this.dESCONTODataGridViewTextBoxColumn.Name = "dESCONTODataGridViewTextBoxColumn";
            // 
            // tOTALCOMPRADataGridViewTextBoxColumn
            // 
            this.tOTALCOMPRADataGridViewTextBoxColumn.DataPropertyName = "TOTALCOMPRA";
            this.tOTALCOMPRADataGridViewTextBoxColumn.HeaderText = "TOTALCOMPRA";
            this.tOTALCOMPRADataGridViewTextBoxColumn.Name = "tOTALCOMPRADataGridViewTextBoxColumn";
            // 
            // dATADataGridViewTextBoxColumn
            // 
            this.dATADataGridViewTextBoxColumn.DataPropertyName = "DATA";
            this.dATADataGridViewTextBoxColumn.HeaderText = "DATA";
            this.dATADataGridViewTextBoxColumn.Name = "dATADataGridViewTextBoxColumn";
            // 
            // ConsultarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(968, 422);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarVendas";
            this.Text = "ConsultarVendas";
            this.Load += new System.EventHandler(this.ConsultarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDABindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SystemOrangeDataSet7 systemOrangeDataSet7;
        private System.Windows.Forms.BindingSource vENDABindingSource;
        private SystemOrangeDataSet7TableAdapters.VENDATableAdapter vENDATableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}