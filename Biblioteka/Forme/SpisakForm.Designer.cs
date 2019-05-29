namespace Biblioteka.Forme
{
    partial class SpisakForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NazadButton = new System.Windows.Forms.Button();
            this.SpisakUcenikaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(704, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // NazadButton
            // 
            this.NazadButton.Location = new System.Drawing.Point(39, 43);
            this.NazadButton.Name = "NazadButton";
            this.NazadButton.Size = new System.Drawing.Size(139, 53);
            this.NazadButton.TabIndex = 1;
            this.NazadButton.Text = "Nazad";
            this.NazadButton.UseVisualStyleBackColor = true;
            this.NazadButton.Click += new System.EventHandler(this.NazadButton_Click);
            // 
            // SpisakUcenikaLabel
            // 
            this.SpisakUcenikaLabel.AutoSize = true;
            this.SpisakUcenikaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpisakUcenikaLabel.Location = new System.Drawing.Point(468, 61);
            this.SpisakUcenikaLabel.Name = "SpisakUcenikaLabel";
            this.SpisakUcenikaLabel.Size = new System.Drawing.Size(86, 29);
            this.SpisakUcenikaLabel.TabIndex = 2;
            this.SpisakUcenikaLabel.Text = "Spisak";
            // 
            // SpisakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpisakUcenikaLabel);
            this.Controls.Add(this.NazadButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SpisakForm";
            this.Text = "Spisak";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button NazadButton;
        private System.Windows.Forms.Label SpisakUcenikaLabel;
    }
}