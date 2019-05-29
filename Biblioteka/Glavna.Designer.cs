namespace Biblioteka
{
    partial class Glavna
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
            this.databaseDataSet = new Biblioteka.databaseDataSet();
            this.uceniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uceniciTableAdapter = new Biblioteka.databaseDataSetTableAdapters.UceniciTableAdapter();
            this.tableAdapterManager = new Biblioteka.databaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uceniciBindingSource
            // 
            this.uceniciBindingSource.DataMember = "Ucenici";
            this.uceniciBindingSource.DataSource = this.databaseDataSet;
            this.uceniciBindingSource.CurrentChanged += new System.EventHandler(this.UceniciBindingSource_CurrentChanged);
            // 
            // uceniciTableAdapter
            // 
            this.uceniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UceniciTableAdapter = this.uceniciTableAdapter;
            this.tableAdapterManager.UpdateOrder = Biblioteka.databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Name = "Glavna";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource uceniciBindingSource;
        private databaseDataSetTableAdapters.UceniciTableAdapter uceniciTableAdapter;
        private databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

