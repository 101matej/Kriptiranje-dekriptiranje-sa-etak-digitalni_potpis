namespace os2_projekt
{
    partial class SimetricnaKriptografija
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
            this.btn_generirajTajniKljuc = new System.Windows.Forms.Button();
            this.btn_kriptirajTekst = new System.Windows.Forms.Button();
            this.btn_dekriptirajTekst = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dekriptiraniTekst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_kriptiraniTekst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_iv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tajniKljuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_uneseniTekst = new System.Windows.Forms.TextBox();
            this.tb_imeDatoteke = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_odaberiDatoteku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_generirajTajniKljuc
            // 
            this.btn_generirajTajniKljuc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_generirajTajniKljuc.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generirajTajniKljuc.Location = new System.Drawing.Point(21, 160);
            this.btn_generirajTajniKljuc.Name = "btn_generirajTajniKljuc";
            this.btn_generirajTajniKljuc.Size = new System.Drawing.Size(323, 85);
            this.btn_generirajTajniKljuc.TabIndex = 2;
            this.btn_generirajTajniKljuc.Text = "Generiraj ključeve";
            this.btn_generirajTajniKljuc.UseVisualStyleBackColor = false;
            this.btn_generirajTajniKljuc.Click += new System.EventHandler(this.btn_generirajTajniKljuc_Click);
            // 
            // btn_kriptirajTekst
            // 
            this.btn_kriptirajTekst.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_kriptirajTekst.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kriptirajTekst.Location = new System.Drawing.Point(21, 323);
            this.btn_kriptirajTekst.Name = "btn_kriptirajTekst";
            this.btn_kriptirajTekst.Size = new System.Drawing.Size(323, 85);
            this.btn_kriptirajTekst.TabIndex = 3;
            this.btn_kriptirajTekst.Text = "Kriptiraj tekst";
            this.btn_kriptirajTekst.UseVisualStyleBackColor = false;
            this.btn_kriptirajTekst.Click += new System.EventHandler(this.btn_kriptirajTekst_Click_1);
            // 
            // btn_dekriptirajTekst
            // 
            this.btn_dekriptirajTekst.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_dekriptirajTekst.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dekriptirajTekst.Location = new System.Drawing.Point(21, 486);
            this.btn_dekriptirajTekst.Name = "btn_dekriptirajTekst";
            this.btn_dekriptirajTekst.Size = new System.Drawing.Size(323, 85);
            this.btn_dekriptirajTekst.TabIndex = 4;
            this.btn_dekriptirajTekst.Text = "Dekriptiraj tekst";
            this.btn_dekriptirajTekst.UseVisualStyleBackColor = false;
            this.btn_dekriptirajTekst.Click += new System.EventHandler(this.btn_dekriptirajTekst_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(713, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dekriptirani tekst:";
            // 
            // tb_dekriptiraniTekst
            // 
            this.tb_dekriptiraniTekst.Enabled = false;
            this.tb_dekriptiraniTekst.Location = new System.Drawing.Point(716, 411);
            this.tb_dekriptiraniTekst.Multiline = true;
            this.tb_dekriptiraniTekst.Name = "tb_dekriptiraniTekst";
            this.tb_dekriptiraniTekst.Size = new System.Drawing.Size(300, 200);
            this.tb_dekriptiraniTekst.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kriptirani tekst:";
            // 
            // tb_kriptiraniTekst
            // 
            this.tb_kriptiraniTekst.Enabled = false;
            this.tb_kriptiraniTekst.Location = new System.Drawing.Point(397, 411);
            this.tb_kriptiraniTekst.Multiline = true;
            this.tb_kriptiraniTekst.Name = "tb_kriptiraniTekst";
            this.tb_kriptiraniTekst.Size = new System.Drawing.Size(300, 200);
            this.tb_kriptiraniTekst.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1032, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Inicijalizacijski vektor:";
            // 
            // tb_iv
            // 
            this.tb_iv.Enabled = false;
            this.tb_iv.Location = new System.Drawing.Point(1035, 160);
            this.tb_iv.Multiline = true;
            this.tb_iv.Name = "tb_iv";
            this.tb_iv.Size = new System.Drawing.Size(300, 200);
            this.tb_iv.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(711, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tajni ključ:";
            // 
            // tb_tajniKljuc
            // 
            this.tb_tajniKljuc.Enabled = false;
            this.tb_tajniKljuc.Location = new System.Drawing.Point(714, 160);
            this.tb_tajniKljuc.Multiline = true;
            this.tb_tajniKljuc.Name = "tb_tajniKljuc";
            this.tb_tajniKljuc.Size = new System.Drawing.Size(300, 200);
            this.tb_tajniKljuc.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Uneseni tekst:";
            // 
            // tb_uneseniTekst
            // 
            this.tb_uneseniTekst.Enabled = false;
            this.tb_uneseniTekst.Location = new System.Drawing.Point(395, 160);
            this.tb_uneseniTekst.Multiline = true;
            this.tb_uneseniTekst.Name = "tb_uneseniTekst";
            this.tb_uneseniTekst.Size = new System.Drawing.Size(300, 200);
            this.tb_uneseniTekst.TabIndex = 13;
            // 
            // tb_imeDatoteke
            // 
            this.tb_imeDatoteke.Enabled = false;
            this.tb_imeDatoteke.Location = new System.Drawing.Point(206, 49);
            this.tb_imeDatoteke.Name = "tb_imeDatoteke";
            this.tb_imeDatoteke.Size = new System.Drawing.Size(243, 22);
            this.tb_imeDatoteke.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Odaberi datoteku:";
            // 
            // btn_odaberiDatoteku
            // 
            this.btn_odaberiDatoteku.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_odaberiDatoteku.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odaberiDatoteku.Location = new System.Drawing.Point(482, 41);
            this.btn_odaberiDatoteku.Name = "btn_odaberiDatoteku";
            this.btn_odaberiDatoteku.Size = new System.Drawing.Size(215, 39);
            this.btn_odaberiDatoteku.TabIndex = 23;
            this.btn_odaberiDatoteku.Text = "Odaberi datoteku";
            this.btn_odaberiDatoteku.UseVisualStyleBackColor = false;
            this.btn_odaberiDatoteku.Click += new System.EventHandler(this.btn_odaberiDatoteku_Click);
            // 
            // SimetricnaKriptografija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 631);
            this.Controls.Add(this.tb_imeDatoteke);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_odaberiDatoteku);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_dekriptiraniTekst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_kriptiraniTekst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_iv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tajniKljuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_uneseniTekst);
            this.Controls.Add(this.btn_dekriptirajTekst);
            this.Controls.Add(this.btn_kriptirajTekst);
            this.Controls.Add(this.btn_generirajTajniKljuc);
            this.Name = "SimetricnaKriptografija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simetrična kriptografija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generirajTajniKljuc;
        private System.Windows.Forms.Button btn_kriptirajTekst;
        private System.Windows.Forms.Button btn_dekriptirajTekst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dekriptiraniTekst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_kriptiraniTekst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_iv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tajniKljuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_uneseniTekst;
        private System.Windows.Forms.TextBox tb_imeDatoteke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_odaberiDatoteku;
    }
}