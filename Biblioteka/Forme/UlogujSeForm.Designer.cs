namespace Biblioteka
{
    partial class UlogujSeForm
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
            this.KorisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.UlogujSeButton = new System.Windows.Forms.Button();
            this.LozinkaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KorisnickoImeTextBox
            // 
            this.KorisnickoImeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KorisnickoImeTextBox.Location = new System.Drawing.Point(41, 45);
            this.KorisnickoImeTextBox.Multiline = true;
            this.KorisnickoImeTextBox.Name = "KorisnickoImeTextBox";
            this.KorisnickoImeTextBox.Size = new System.Drawing.Size(187, 52);
            this.KorisnickoImeTextBox.TabIndex = 0;
            this.KorisnickoImeTextBox.Text = "Korisnicko ime";
            this.KorisnickoImeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UlogujSeButton
            // 
            this.UlogujSeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlogujSeButton.Location = new System.Drawing.Point(41, 226);
            this.UlogujSeButton.Name = "UlogujSeButton";
            this.UlogujSeButton.Size = new System.Drawing.Size(187, 49);
            this.UlogujSeButton.TabIndex = 1;
            this.UlogujSeButton.Text = "Uloguj se";
            this.UlogujSeButton.UseVisualStyleBackColor = true;
            this.UlogujSeButton.Click += new System.EventHandler(this.UlogujSeButton_Click);
            // 
            // LozinkaTextBox
            // 
            this.LozinkaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LozinkaTextBox.Location = new System.Drawing.Point(41, 139);
            this.LozinkaTextBox.Multiline = true;
            this.LozinkaTextBox.Name = "LozinkaTextBox";
            this.LozinkaTextBox.PasswordChar = '*';
            this.LozinkaTextBox.Size = new System.Drawing.Size(187, 49);
            this.LozinkaTextBox.TabIndex = 2;
            this.LozinkaTextBox.Text = "Mozda ne bi bilo lose da se zvezdice pojave tek kad korisnik krene da kuca nzm ka" +
    "ko podsetnik da postavim";
            this.LozinkaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UlogujSeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 318);
            this.Controls.Add(this.LozinkaTextBox);
            this.Controls.Add(this.UlogujSeButton);
            this.Controls.Add(this.KorisnickoImeTextBox);
            this.Name = "UlogujSeForm";
            this.Text = "Uloguj se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KorisnickoImeTextBox;
        private System.Windows.Forms.Button UlogujSeButton;
        private System.Windows.Forms.TextBox LozinkaTextBox;
    }
}