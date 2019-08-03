namespace PimdexxSystem
{
    partial class ConsultarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProdutos));
            this.GridVisualizarProdutos = new System.Windows.Forms.DataGridView();
            this.sEQPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemOrangeDataSet2 = new PimdexxSystem.SystemOrangeDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.pRODUTOTableAdapter = new PimdexxSystem.SystemOrangeDataSet2TableAdapters.PRODUTOTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridVisualizarProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // GridVisualizarProdutos
            // 
            this.GridVisualizarProdutos.AllowUserToAddRows = false;
            this.GridVisualizarProdutos.AllowUserToDeleteRows = false;
            this.GridVisualizarProdutos.AutoGenerateColumns = false;
            this.GridVisualizarProdutos.BackgroundColor = System.Drawing.Color.White;
            this.GridVisualizarProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVisualizarProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVisualizarProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sEQPRODUTODataGridViewTextBoxColumn,
            this.dESCRICAODataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.cATEGORIADataGridViewTextBoxColumn});
            this.GridVisualizarProdutos.DataSource = this.pRODUTOBindingSource;
            this.GridVisualizarProdutos.Location = new System.Drawing.Point(21, 30);
            this.GridVisualizarProdutos.Name = "GridVisualizarProdutos";
            this.GridVisualizarProdutos.ReadOnly = true;
            this.GridVisualizarProdutos.Size = new System.Drawing.Size(440, 368);
            this.GridVisualizarProdutos.TabIndex = 0;
            // 
            // sEQPRODUTODataGridViewTextBoxColumn
            // 
            this.sEQPRODUTODataGridViewTextBoxColumn.DataPropertyName = "SEQPRODUTO";
            this.sEQPRODUTODataGridViewTextBoxColumn.HeaderText = "Código do Produto";
            this.sEQPRODUTODataGridViewTextBoxColumn.Name = "sEQPRODUTODataGridViewTextBoxColumn";
            this.sEQPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRICAODataGridViewTextBoxColumn
            // 
            this.dESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.HeaderText = "Produto";
            this.dESCRICAODataGridViewTextBoxColumn.Name = "dESCRICAODataGridViewTextBoxColumn";
            this.dESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.HeaderText = "R$ Valor";
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            this.vALORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEGORIADataGridViewTextBoxColumn
            // 
            this.cATEGORIADataGridViewTextBoxColumn.DataPropertyName = "CATEGORIA";
            this.cATEGORIADataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.cATEGORIADataGridViewTextBoxColumn.Name = "cATEGORIADataGridViewTextBoxColumn";
            this.cATEGORIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.systemOrangeDataSet2;
            // 
            // systemOrangeDataSet2
            // 
            this.systemOrangeDataSet2.DataSetName = "SystemOrangeDataSet2";
            this.systemOrangeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualização de Produtos";
            // 
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(326, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "    Exportar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridVisualizarProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarProdutos";
            this.Text = "ConsultarProdutos";
            this.Load += new System.EventHandler(this.ConsultarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVisualizarProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemOrangeDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridVisualizarProdutos;
        private System.Windows.Forms.Label label1;
        private SystemOrangeDataSet2 systemOrangeDataSet2;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private SystemOrangeDataSet2TableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEQPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORIADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}