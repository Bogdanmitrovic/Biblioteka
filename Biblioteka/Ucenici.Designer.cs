namespace Biblioteka
{
    partial class Ucenici
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Biblioteka.databaseDataSet();
            this.uceniciTableAdapter = new Biblioteka.databaseDataSetTableAdapters.UceniciTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srednjeSlovoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzeteKnjigeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odeljenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojUzetihKnjigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Ucenici";
            this.bindingSource1.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uceniciTableAdapter
            // 
            this.uceniciTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.srednjeSlovoDataGridViewTextBoxColumn,
            this.uzeteKnjigeDataGridViewTextBoxColumn,
            this.razredDataGridViewTextBoxColumn,
            this.odeljenjeDataGridViewTextBoxColumn,
            this.brojUzetihKnjigaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(844, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // srednjeSlovoDataGridViewTextBoxColumn
            // 
            this.srednjeSlovoDataGridViewTextBoxColumn.DataPropertyName = "srednjeSlovo";
            this.srednjeSlovoDataGridViewTextBoxColumn.HeaderText = "srednjeSlovo";
            this.srednjeSlovoDataGridViewTextBoxColumn.Name = "srednjeSlovoDataGridViewTextBoxColumn";
            this.srednjeSlovoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uzeteKnjigeDataGridViewTextBoxColumn
            // 
            this.uzeteKnjigeDataGridViewTextBoxColumn.DataPropertyName = "uzeteKnjige";
            this.uzeteKnjigeDataGridViewTextBoxColumn.HeaderText = "uzeteKnjige";
            this.uzeteKnjigeDataGridViewTextBoxColumn.Name = "uzeteKnjigeDataGridViewTextBoxColumn";
            this.uzeteKnjigeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razredDataGridViewTextBoxColumn
            // 
            this.razredDataGridViewTextBoxColumn.DataPropertyName = "razred";
            this.razredDataGridViewTextBoxColumn.HeaderText = "razred";
            this.razredDataGridViewTextBoxColumn.Name = "razredDataGridViewTextBoxColumn";
            this.razredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odeljenjeDataGridViewTextBoxColumn
            // 
            this.odeljenjeDataGridViewTextBoxColumn.DataPropertyName = "odeljenje";
            this.odeljenjeDataGridViewTextBoxColumn.HeaderText = "odeljenje";
            this.odeljenjeDataGridViewTextBoxColumn.Name = "odeljenjeDataGridViewTextBoxColumn";
            this.odeljenjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojUzetihKnjigaDataGridViewTextBoxColumn
            // 
            this.brojUzetihKnjigaDataGridViewTextBoxColumn.DataPropertyName = "brojUzetihKnjiga";
            this.brojUzetihKnjigaDataGridViewTextBoxColumn.HeaderText = "brojUzetihKnjiga";
            this.brojUzetihKnjigaDataGridViewTextBoxColumn.Name = "brojUzetihKnjigaDataGridViewTextBoxColumn";
            this.brojUzetihKnjigaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ucenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ucenici";
            this.Text = "Ucenici";
            this.Load += new System.EventHandler(this.Ucenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private databaseDataSet databaseDataSet;
        private databaseDataSetTableAdapters.UceniciTableAdapter uceniciTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srednjeSlovoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzeteKnjigeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odeljenjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojUzetihKnjigaDataGridViewTextBoxColumn;
    }
}