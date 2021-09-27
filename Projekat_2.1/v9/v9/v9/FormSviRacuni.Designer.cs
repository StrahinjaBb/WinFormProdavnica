
namespace v9
{
    partial class FormSviRacuni
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
            this.dtpPocetni = new System.Windows.Forms.DateTimePicker();
            this.dtpKrajnji = new System.Windows.Forms.DateTimePicker();
            this.lblPocetniDatum = new System.Windows.Forms.Label();
            this.lblKrajnjiDatum = new System.Windows.Forms.Label();
            this.btnIzlistaj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzlistajSve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpPocetni
            // 
            this.dtpPocetni.Location = new System.Drawing.Point(27, 70);
            this.dtpPocetni.Name = "dtpPocetni";
            this.dtpPocetni.Size = new System.Drawing.Size(200, 20);
            this.dtpPocetni.TabIndex = 0;
            // 
            // dtpKrajnji
            // 
            this.dtpKrajnji.Location = new System.Drawing.Point(27, 134);
            this.dtpKrajnji.Name = "dtpKrajnji";
            this.dtpKrajnji.Size = new System.Drawing.Size(200, 20);
            this.dtpKrajnji.TabIndex = 1;
            // 
            // lblPocetniDatum
            // 
            this.lblPocetniDatum.AutoSize = true;
            this.lblPocetniDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPocetniDatum.Location = new System.Drawing.Point(22, 42);
            this.lblPocetniDatum.Name = "lblPocetniDatum";
            this.lblPocetniDatum.Size = new System.Drawing.Size(136, 25);
            this.lblPocetniDatum.TabIndex = 2;
            this.lblPocetniDatum.Text = "Pocetni datum";
            // 
            // lblKrajnjiDatum
            // 
            this.lblKrajnjiDatum.AutoSize = true;
            this.lblKrajnjiDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblKrajnjiDatum.Location = new System.Drawing.Point(22, 106);
            this.lblKrajnjiDatum.Name = "lblKrajnjiDatum";
            this.lblKrajnjiDatum.Size = new System.Drawing.Size(125, 25);
            this.lblKrajnjiDatum.TabIndex = 3;
            this.lblKrajnjiDatum.Text = "Krajnji datum";
            // 
            // btnIzlistaj
            // 
            this.btnIzlistaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIzlistaj.Location = new System.Drawing.Point(27, 170);
            this.btnIzlistaj.Name = "btnIzlistaj";
            this.btnIzlistaj.Size = new System.Drawing.Size(200, 50);
            this.btnIzlistaj.TabIndex = 4;
            this.btnIzlistaj.Text = "Izlistaj racune";
            this.btnIzlistaj.UseVisualStyleBackColor = true;
            this.btnIzlistaj.Click += new System.EventHandler(this.btnIzlistaj_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(434, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 264);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(429, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista racuna";
            // 
            // btnIzlistajSve
            // 
            this.btnIzlistajSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIzlistajSve.Location = new System.Drawing.Point(27, 226);
            this.btnIzlistajSve.Name = "btnIzlistajSve";
            this.btnIzlistajSve.Size = new System.Drawing.Size(200, 50);
            this.btnIzlistajSve.TabIndex = 7;
            this.btnIzlistajSve.Text = "Izlistaj sve racune";
            this.btnIzlistajSve.UseVisualStyleBackColor = true;
            this.btnIzlistajSve.Click += new System.EventHandler(this.btnIzlistajSve_Click);
            // 
            // FormSviRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzlistajSve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnIzlistaj);
            this.Controls.Add(this.lblKrajnjiDatum);
            this.Controls.Add(this.lblPocetniDatum);
            this.Controls.Add(this.dtpKrajnji);
            this.Controls.Add(this.dtpPocetni);
            this.Name = "FormSviRacuni";
            this.Text = "FormSviRacuni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPocetni;
        private System.Windows.Forms.DateTimePicker dtpKrajnji;
        private System.Windows.Forms.Label lblPocetniDatum;
        private System.Windows.Forms.Label lblKrajnjiDatum;
        private System.Windows.Forms.Button btnIzlistaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzlistajSve;
    }
}