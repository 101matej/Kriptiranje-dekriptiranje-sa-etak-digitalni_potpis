namespace os2_projekt
{
    partial class AsimetricnaKriptografija
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
            this.btn_kriptirajTekst = new System.Windows.Forms.Button();
            this.btn_generirajKljuceve = new System.Windows.Forms.Button();
            this.btnDekriptirajTekst = new System.Windows.Forms.Button();
            this.tb_uneseniTekst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_javniKljuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_privatniKljuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_kriptiraniTekst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dekriptiraniTekst = new System.Windows.Forms.TextBox();
            this.tb_imeDatoteke = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_odaberiDatoteku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kriptirajTekst
            // 
            this.btn_kriptirajTekst.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_kriptirajTekst.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kriptirajTekst.Location = new System.Drawing.Point(31, 310);
            this.btn_kriptirajTekst.Name = "btn_kriptirajTekst";
            this.btn_kriptirajTekst.Size = new System.Drawing.Size(323, 85);
            this.btn_kriptirajTekst.TabIndex = 0;
            this.btn_kriptirajTekst.Text = "Kriptiraj tekst";
            this.btn_kriptirajTekst.UseVisualStyleBackColor = false;
            this.btn_kriptirajTekst.Click += new System.EventHandler(this.btn_kriptirajTekst_Click);
            // 
            // btn_generirajKljuceve
            // 
            this.btn_generirajKljuceve.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_generirajKljuceve.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generirajKljuceve.Location = new System.Drawing.Point(31, 159);
            this.btn_generirajKljuceve.Name = "btn_generirajKljuceve";
            this.btn_generirajKljuceve.Size = new System.Drawing.Size(323, 85);
            this.btn_generirajKljuceve.TabIndex = 1;
            this.btn_generirajKljuceve.Text = "Generiraj ključeve";
            this.btn_generirajKljuceve.UseVisualStyleBackColor = false;
            this.btn_generirajKljuceve.Click += new System.EventHandler(this.btn_generirajKljuceve_Click);
            // 
            // btnDekriptirajTekst
            // 
            this.btnDekriptirajTekst.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDekriptirajTekst.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekriptirajTekst.Location = new System.Drawing.Point(31, 460);
            this.btnDekriptirajTekst.Name = "btnDekriptirajTekst";
            this.btnDekriptirajTekst.Size = new System.Drawing.Size(323, 85);
            this.btnDekriptirajTekst.TabIndex = 2;
            this.btnDekriptirajTekst.Text = "Dekriptiraj tekst";
            this.btnDekriptirajTekst.UseVisualStyleBackColor = false;
            this.btnDekriptirajTekst.Click += new System.EventHandler(this.btnDekriptirajTekst_Click);
            // 
            // tb_uneseniTekst
            // 
            this.tb_uneseniTekst.Enabled = false;
            this.tb_uneseniTekst.Location = new System.Drawing.Point(422, 159);
            this.tb_uneseniTekst.Multiline = true;
            this.tb_uneseniTekst.Name = "tb_uneseniTekst";
            this.tb_uneseniTekst.Size = new System.Drawing.Size(300, 200);
            this.tb_uneseniTekst.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uneseni tekst:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(738, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Javni ključ:";
            // 
            // tb_javniKljuc
            // 
            this.tb_javniKljuc.Enabled = false;
            this.tb_javniKljuc.Location = new System.Drawing.Point(741, 159);
            this.tb_javniKljuc.Multiline = true;
            this.tb_javniKljuc.Name = "tb_javniKljuc";
            this.tb_javniKljuc.Size = new System.Drawing.Size(300, 200);
            this.tb_javniKljuc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1059, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Privatni ključ:";
            // 
            // tb_privatniKljuc
            // 
            this.tb_privatniKljuc.Enabled = false;
            this.tb_privatniKljuc.Location = new System.Drawing.Point(1062, 159);
            this.tb_privatniKljuc.Multiline = true;
            this.tb_privatniKljuc.Name = "tb_privatniKljuc";
            this.tb_privatniKljuc.Size = new System.Drawing.Size(300, 200);
            this.tb_privatniKljuc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kriptirani tekst:";
            // 
            // tb_kriptiraniTekst
            // 
            this.tb_kriptiraniTekst.Enabled = false;
            this.tb_kriptiraniTekst.Location = new System.Drawing.Point(424, 410);
            this.tb_kriptiraniTekst.Multiline = true;
            this.tb_kriptiraniTekst.Name = "tb_kriptiraniTekst";
            this.tb_kriptiraniTekst.Size = new System.Drawing.Size(300, 200);
            this.tb_kriptiraniTekst.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dekriptirani tekst:";
            // 
            // tb_dekriptiraniTekst
            // 
            this.tb_dekriptiraniTekst.Enabled = false;
            this.tb_dekriptiraniTekst.Location = new System.Drawing.Point(743, 410);
            this.tb_dekriptiraniTekst.Multiline = true;
            this.tb_dekriptiraniTekst.Name = "tb_dekriptiraniTekst";
            this.tb_dekriptiraniTekst.Size = new System.Drawing.Size(300, 200);
            this.tb_dekriptiraniTekst.TabIndex = 11;
            // 
            // tb_imeDatoteke
            // 
            this.tb_imeDatoteke.Enabled = false;
            this.tb_imeDatoteke.Location = new System.Drawing.Point(218, 46);
            this.tb_imeDatoteke.Name = "tb_imeDatoteke";
            this.tb_imeDatoteke.Size = new System.Drawing.Size(243, 22);
            this.tb_imeDatoteke.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Odaberi datoteku:";
            // 
            // btn_odaberiDatoteku
            // 
            this.btn_odaberiDatoteku.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_odaberiDatoteku.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odaberiDatoteku.Location = new System.Drawing.Point(494, 38);
            this.btn_odaberiDatoteku.Name = "btn_odaberiDatoteku";
            this.btn_odaberiDatoteku.Size = new System.Drawing.Size(215, 39);
            this.btn_odaberiDatoteku.TabIndex = 26;
            this.btn_odaberiDatoteku.Text = "Odaberi datoteku";
            this.btn_odaberiDatoteku.UseVisualStyleBackColor = false;
            this.btn_odaberiDatoteku.Click += new System.EventHandler(this.btn_odaberiDatoteku_Click);
            // 
            // AsimetricnaKriptografija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 633);
            this.Controls.Add(this.tb_imeDatoteke);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_odaberiDatoteku);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_dekriptiraniTekst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_kriptiraniTekst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_privatniKljuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_javniKljuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_uneseniTekst);
            this.Controls.Add(this.btnDekriptirajTekst);
            this.Controls.Add(this.btn_generirajKljuceve);
            this.Controls.Add(this.btn_kriptirajTekst);
            this.Name = "AsimetricnaKriptografija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asimetrična kriptografija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kriptirajTekst;
        private System.Windows.Forms.Button btn_generirajKljuceve;
        private System.Windows.Forms.Button btnDekriptirajTekst;
        private System.Windows.Forms.TextBox tb_uneseniTekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_javniKljuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_privatniKljuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_kriptiraniTekst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dekriptiraniTekst;
        private System.Windows.Forms.TextBox tb_imeDatoteke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_odaberiDatoteku;
    }
}