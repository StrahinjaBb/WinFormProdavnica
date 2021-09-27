
namespace v9
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblKategorije = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblProizvod = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.radBtnNaziv = new System.Windows.Forms.RadioButton();
            this.radBtnKategorija = new System.Windows.Forms.RadioButton();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.btnRacuni = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lblKategorije
            // 
            this.lblKategorije.AutoSize = true;
            this.lblKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblKategorije.Location = new System.Drawing.Point(19, 30);
            this.lblKategorije.Name = "lblKategorije";
            this.lblKategorije.Size = new System.Drawing.Size(106, 25);
            this.lblKategorije.TabIndex = 1;
            this.lblKategorije.Text = "Kategorije:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(399, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 290);
            this.listBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(399, 418);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // lblProizvod
            // 
            this.lblProizvod.AutoSize = true;
            this.lblProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblProizvod.Location = new System.Drawing.Point(394, 30);
            this.lblProizvod.Name = "lblProizvod";
            this.lblProizvod.Size = new System.Drawing.Size(98, 25);
            this.lblProizvod.TabIndex = 4;
            this.lblProizvod.Text = "Proizvodi:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblKolicina.Location = new System.Drawing.Point(394, 390);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(87, 25);
            this.lblKolicina.TabIndex = 5;
            this.lblKolicina.Text = "Kolicina:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(24, 394);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(260, 20);
            this.txtPretraga.TabIndex = 6;
            // 
            // radBtnNaziv
            // 
            this.radBtnNaziv.AutoSize = true;
            this.radBtnNaziv.Location = new System.Drawing.Point(24, 431);
            this.radBtnNaziv.Name = "radBtnNaziv";
            this.radBtnNaziv.Size = new System.Drawing.Size(52, 17);
            this.radBtnNaziv.TabIndex = 7;
            this.radBtnNaziv.TabStop = true;
            this.radBtnNaziv.Text = "Naziv";
            this.radBtnNaziv.UseVisualStyleBackColor = true;
            // 
            // radBtnKategorija
            // 
            this.radBtnKategorija.AutoSize = true;
            this.radBtnKategorija.Location = new System.Drawing.Point(82, 431);
            this.radBtnKategorija.Name = "radBtnKategorija";
            this.radBtnKategorija.Size = new System.Drawing.Size(72, 17);
            this.radBtnKategorija.TabIndex = 8;
            this.radBtnKategorija.TabStop = true;
            this.radBtnKategorija.Text = "Kategorija";
            this.radBtnKategorija.UseVisualStyleBackColor = true;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPretraga.Location = new System.Drawing.Point(19, 357);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(92, 25);
            this.lblPretraga.TabIndex = 9;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDodaj.Location = new System.Drawing.Point(561, 390);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(166, 48);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPretrazi.Location = new System.Drawing.Point(160, 418);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(124, 30);
            this.btnPretrazi.TabIndex = 11;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDodajProizvod.Location = new System.Drawing.Point(24, 284);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(166, 48);
            this.btnDodajProizvod.TabIndex = 14;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // btnRacuni
            // 
            this.btnRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRacuni.Location = new System.Drawing.Point(216, 284);
            this.btnRacuni.Name = "btnRacuni";
            this.btnRacuni.Size = new System.Drawing.Size(166, 48);
            this.btnRacuni.TabIndex = 15;
            this.btnRacuni.Text = "Svi racuni";
            this.btnRacuni.UseVisualStyleBackColor = true;
            this.btnRacuni.Click += new System.EventHandler(this.btnRacuni_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnStatistika.Location = new System.Drawing.Point(216, 230);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(166, 48);
            this.btnStatistika.TabIndex = 16;
            this.btnStatistika.Text = "Statistika prodaje";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnRacuni);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.radBtnKategorija);
            this.Controls.Add(this.radBtnNaziv);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblProizvod);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblKategorije);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblKategorije;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblProizvod;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.RadioButton radBtnNaziv;
        private System.Windows.Forms.RadioButton radBtnKategorija;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.Button btnRacuni;
        private System.Windows.Forms.Button btnStatistika;
    }
}