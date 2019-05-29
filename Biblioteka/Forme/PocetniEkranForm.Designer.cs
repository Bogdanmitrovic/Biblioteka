namespace Biblioteka
{
    partial class PocetniEkranForm
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
            this.IznajmiKnjiguButton = new System.Windows.Forms.Button();
            this.VratiKnjiguButton = new System.Windows.Forms.Button();
            this.IDVratiKnjiguTextBox = new System.Windows.Forms.TextBox();
            this.SpisakUcenikaButton = new System.Windows.Forms.Button();
            this.SpisakKnjigaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IznajmiKnjiguButton
            // 
            this.IznajmiKnjiguButton.Location = new System.Drawing.Point(56, 110);
            this.IznajmiKnjiguButton.Name = "IznajmiKnjiguButton";
            this.IznajmiKnjiguButton.Size = new System.Drawing.Size(148, 60);
            this.IznajmiKnjiguButton.TabIndex = 0;
            this.IznajmiKnjiguButton.Text = "Iznajmi knjigu";
            this.IznajmiKnjiguButton.UseVisualStyleBackColor = true;
            // 
            // VratiKnjiguButton
            // 
            this.VratiKnjiguButton.Location = new System.Drawing.Point(229, 110);
            this.VratiKnjiguButton.Name = "VratiKnjiguButton";
            this.VratiKnjiguButton.Size = new System.Drawing.Size(148, 60);
            this.VratiKnjiguButton.TabIndex = 1;
            this.VratiKnjiguButton.Text = "Vrati knjigu";
            this.VratiKnjiguButton.UseVisualStyleBackColor = true;
            // 
            // IDVratiKnjiguTextBox
            // 
            this.IDVratiKnjiguTextBox.Location = new System.Drawing.Point(91, 34);
            this.IDVratiKnjiguTextBox.Multiline = true;
            this.IDVratiKnjiguTextBox.Name = "IDVratiKnjiguTextBox";
            this.IDVratiKnjiguTextBox.Size = new System.Drawing.Size(246, 57);
            this.IDVratiKnjiguTextBox.TabIndex = 2;
            this.IDVratiKnjiguTextBox.Text = "ID knjige";
            this.IDVratiKnjiguTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpisakUcenikaButton
            // 
            this.SpisakUcenikaButton.Location = new System.Drawing.Point(56, 204);
            this.SpisakUcenikaButton.Name = "SpisakUcenikaButton";
            this.SpisakUcenikaButton.Size = new System.Drawing.Size(148, 88);
            this.SpisakUcenikaButton.TabIndex = 3;
            this.SpisakUcenikaButton.Text = "Spisak ucenika";
            this.SpisakUcenikaButton.UseVisualStyleBackColor = true;
            this.SpisakUcenikaButton.Click += new System.EventHandler(this.SpisakUcenikaButton_Click);
            // 
            // SpisakKnjigaButton
            // 
            this.SpisakKnjigaButton.Location = new System.Drawing.Point(229, 204);
            this.SpisakKnjigaButton.Name = "SpisakKnjigaButton";
            this.SpisakKnjigaButton.Size = new System.Drawing.Size(148, 88);
            this.SpisakKnjigaButton.TabIndex = 4;
            this.SpisakKnjigaButton.Text = "Spisak knjiga";
            this.SpisakKnjigaButton.UseVisualStyleBackColor = true;
            // 
            // PocetniEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 330);
            this.Controls.Add(this.SpisakKnjigaButton);
            this.Controls.Add(this.SpisakUcenikaButton);
            this.Controls.Add(this.IDVratiKnjiguTextBox);
            this.Controls.Add(this.VratiKnjiguButton);
            this.Controls.Add(this.IznajmiKnjiguButton);
            this.Name = "PocetniEkranForm";
            this.Text = "Pocetni Ekran";
            this.Load += new System.EventHandler(this.PocetniEkranForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IznajmiKnjiguButton;
        private System.Windows.Forms.Button VratiKnjiguButton;
        private System.Windows.Forms.TextBox IDVratiKnjiguTextBox;
        private System.Windows.Forms.Button SpisakUcenikaButton;
        private System.Windows.Forms.Button SpisakKnjigaButton;
    }
}