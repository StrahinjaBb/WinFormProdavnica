
namespace v9
{
    partial class FormRacun
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
            this.lblRacunID = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblProizvodi = new System.Windows.Forms.Label();
            this.btnStornirajProizvod = new System.Windows.Forms.Button();
            this.btnStornirajRacun = new System.Windows.Forms.Button();
            this.lblCenaUkupno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRacunID
            // 
            this.lblRacunID.AutoSize = true;
            this.lblRacunID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRacunID.Location = new System.Drawing.Point(30, 30);
            this.lblRacunID.Name = "lblRacunID";
            this.lblRacunID.Size = new System.Drawing.Size(68, 20);
            this.lblRacunID.TabIndex = 0;
            this.lblRacunID.Text = "idRacun";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDatum.Location = new System.Drawing.Point(30, 74);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(57, 20);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(391, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 303);
            this.listBox1.TabIndex = 3;
            // 
            // lblProizvodi
            // 
            this.lblProizvodi.AutoSize = true;
            this.lblProizvodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProizvodi.Location = new System.Drawing.Point(387, 30);
            this.lblProizvodi.Name = "lblProizvodi";
            this.lblProizvodi.Size = new System.Drawing.Size(72, 20);
            this.lblProizvodi.TabIndex = 4;
            this.lblProizvodi.Text = "Proizvodi";
            // 
            // btnStornirajProizvod
            // 
            this.btnStornirajProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStornirajProizvod.Location = new System.Drawing.Point(391, 390);
            this.btnStornirajProizvod.Name = "btnStornirajProizvod";
            this.btnStornirajProizvod.Size = new System.Drawing.Size(179, 48);
            this.btnStornirajProizvod.TabIndex = 15;
            this.btnStornirajProizvod.Text = "Storniraj proizvod";
            this.btnStornirajProizvod.UseVisualStyleBackColor = true;
            this.btnStornirajProizvod.Click += new System.EventHandler(this.btnStornirajProizvod_Click);
            // 
            // btnStornirajRacun
            // 
            this.btnStornirajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStornirajRacun.Location = new System.Drawing.Point(589, 390);
            this.btnStornirajRacun.Name = "btnStornirajRacun";
            this.btnStornirajRacun.Size = new System.Drawing.Size(151, 48);
            this.btnStornirajRacun.TabIndex = 16;
            this.btnStornirajRacun.Text = "Storniraj racun";
            this.btnStornirajRacun.UseVisualStyleBackColor = true;
            this.btnStornirajRacun.Click += new System.EventHandler(this.btnStornirajRacun_Click);
            // 
            // lblCenaUkupno
            // 
            this.lblCenaUkupno.AutoSize = true;
            this.lblCenaUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCenaUkupno.Location = new System.Drawing.Point(42, 390);
            this.lblCenaUkupno.Name = "lblCenaUkupno";
            this.lblCenaUkupno.Size = new System.Drawing.Size(128, 25);
            this.lblCenaUkupno.TabIndex = 17;
            this.lblCenaUkupno.Text = "CenaUkupno";
            // 
            // FormRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCenaUkupno);
            this.Controls.Add(this.btnStornirajRacun);
            this.Controls.Add(this.btnStornirajProizvod);
            this.Controls.Add(this.lblProizvodi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblRacunID);
            this.Name = "FormRacun";
            this.Text = "FormRacun";
            this.Load += new System.EventHandler(this.FormRacun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRacunID;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblProizvodi;
        private System.Windows.Forms.Button btnStornirajProizvod;
        private System.Windows.Forms.Button btnStornirajRacun;
        private System.Windows.Forms.Label lblCenaUkupno;
    }
}