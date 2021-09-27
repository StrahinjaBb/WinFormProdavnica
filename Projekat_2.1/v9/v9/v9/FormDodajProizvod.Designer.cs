
namespace v9
{
    partial class FormDodajProizvod
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNaziv.Location = new System.Drawing.Point(143, 77);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(67, 25);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(255, 82);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(224, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(255, 133);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(224, 20);
            this.txtCena.TabIndex = 3;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCena.Location = new System.Drawing.Point(143, 127);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(66, 25);
            this.lblCena.TabIndex = 2;
            this.lblCena.Text = "Cena:";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblKategorija.Location = new System.Drawing.Point(143, 176);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(106, 25);
            this.lblKategorija.TabIndex = 4;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(148, 349);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(161, 54);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj u bazu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // FormDodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Name = "FormDodajProizvod";
            this.Text = "FormDodajProizvod";
            this.Load += new System.EventHandler(this.FormDodajProizvod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}