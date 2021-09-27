
namespace v9
{
    partial class FormStatistika
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
            this.comboBoxProizvod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMesec = new System.Windows.Forms.ComboBox();
            this.lblProcenat = new System.Windows.Forms.Label();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxProizvod
            // 
            this.comboBoxProizvod.FormattingEnabled = true;
            this.comboBoxProizvod.Location = new System.Drawing.Point(37, 57);
            this.comboBoxProizvod.Name = "comboBoxProizvod";
            this.comboBoxProizvod.Size = new System.Drawing.Size(167, 21);
            this.comboBoxProizvod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proizvodi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(255, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mesec";
            // 
            // comboBoxMesec
            // 
            this.comboBoxMesec.FormattingEnabled = true;
            this.comboBoxMesec.Location = new System.Drawing.Point(260, 57);
            this.comboBoxMesec.Name = "comboBoxMesec";
            this.comboBoxMesec.Size = new System.Drawing.Size(167, 21);
            this.comboBoxMesec.TabIndex = 2;
            // 
            // lblProcenat
            // 
            this.lblProcenat.AutoSize = true;
            this.lblProcenat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblProcenat.Location = new System.Drawing.Point(670, 51);
            this.lblProcenat.Name = "lblProcenat";
            this.lblProcenat.Size = new System.Drawing.Size(90, 25);
            this.lblProcenat.TabIndex = 4;
            this.lblProcenat.Text = "Procenat";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPrikaz.Location = new System.Drawing.Point(478, 29);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(129, 49);
            this.btnPrikaz.TabIndex = 5;
            this.btnPrikaz.Text = "Prikaz";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // FormStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.lblProcenat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMesec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProizvod);
            this.Name = "FormStatistika";
            this.Text = "FormStatistika";
            this.Load += new System.EventHandler(this.FormStatistika_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormStatistika_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProizvod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMesec;
        private System.Windows.Forms.Label lblProcenat;
        private System.Windows.Forms.Button btnPrikaz;
    }
}