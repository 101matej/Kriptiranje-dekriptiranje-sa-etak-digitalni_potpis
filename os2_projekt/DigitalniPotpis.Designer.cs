namespace os2_projekt
{
    partial class DigitalniPotpis
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
            this.btn_potpisiDatoteku = new System.Windows.Forms.Button();
            this.btn_provjeriPotpis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_digitalniPotpis = new System.Windows.Forms.TextBox();
            this.tb_imeDatoteke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_odaberiDatoteku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_potpisiDatoteku
            // 
            this.btn_potpisiDatoteku.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_potpisiDatoteku.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_potpisiDatoteku.Location = new System.Drawing.Point(42, 117);
            this.btn_potpisiDatoteku.Name = "btn_potpisiDatoteku";
            this.btn_potpisiDatoteku.Size = new System.Drawing.Size(323, 85);
            this.btn_potpisiDatoteku.TabIndex = 35;
            this.btn_potpisiDatoteku.Text = "Potpiši datoteku";
            this.btn_potpisiDatoteku.UseVisualStyleBackColor = false;
            this.btn_potpisiDatoteku.Click += new System.EventHandler(this.btn_potpisiDatoteku_Click);
            // 
            // btn_provjeriPotpis
            // 
            this.btn_provjeriPotpis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_provjeriPotpis.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_provjeriPotpis.Location = new System.Drawing.Point(428, 117);
            this.btn_provjeriPotpis.Name = "btn_provjeriPotpis";
            this.btn_provjeriPotpis.Size = new System.Drawing.Size(323, 85);
            this.btn_provjeriPotpis.TabIndex = 36;
            this.btn_provjeriPotpis.Text = "Provjeri potpis";
            this.btn_provjeriPotpis.UseVisualStyleBackColor = false;
            this.btn_provjeriPotpis.Click += new System.EventHandler(this.btn_provjeriPotpis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Digitalni potpis:";
            // 
            // tb_digitalniPotpis
            // 
            this.tb_digitalniPotpis.Enabled = false;
            this.tb_digitalniPotpis.Location = new System.Drawing.Point(42, 266);
            this.tb_digitalniPotpis.Multiline = true;
            this.tb_digitalniPotpis.Name = "tb_digitalniPotpis";
            this.tb_digitalniPotpis.Size = new System.Drawing.Size(300, 200);
            this.tb_digitalniPotpis.TabIndex = 37;
            // 
            // tb_imeDatoteke
            // 
            this.tb_imeDatoteke.Enabled = false;
            this.tb_imeDatoteke.Location = new System.Drawing.Point(226, 43);
            this.tb_imeDatoteke.Name = "tb_imeDatoteke";
            this.tb_imeDatoteke.Size = new System.Drawing.Size(243, 22);
            this.tb_imeDatoteke.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Odaberi datoteku:";
            // 
            // btn_odaberiDatoteku
            // 
            this.btn_odaberiDatoteku.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_odaberiDatoteku.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odaberiDatoteku.Location = new System.Drawing.Point(502, 35);
            this.btn_odaberiDatoteku.Name = "btn_odaberiDatoteku";
            this.btn_odaberiDatoteku.Size = new System.Drawing.Size(215, 39);
            this.btn_odaberiDatoteku.TabIndex = 39;
            this.btn_odaberiDatoteku.Text = "Odaberi datoteku";
            this.btn_odaberiDatoteku.UseVisualStyleBackColor = false;
            this.btn_odaberiDatoteku.Click += new System.EventHandler(this.btn_odaberiDatoteku_Click_1);
            // 
            // DigitalniPotpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 487);
            this.Controls.Add(this.tb_imeDatoteke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_odaberiDatoteku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_digitalniPotpis);
            this.Controls.Add(this.btn_provjeriPotpis);
            this.Controls.Add(this.btn_potpisiDatoteku);
            this.Name = "DigitalniPotpis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitalni potpis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_potpisiDatoteku;
        private System.Windows.Forms.Button btn_provjeriPotpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_digitalniPotpis;
        private System.Windows.Forms.TextBox tb_imeDatoteke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_odaberiDatoteku;
    }
}