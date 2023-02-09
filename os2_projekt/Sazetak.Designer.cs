namespace os2_projekt
{
    partial class Sazetak
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
            this.btn_odaberiDatoteku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_imeDatoteke = new System.Windows.Forms.TextBox();
            this.btn_izracunajSazetak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sazetak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_odaberiDatoteku
            // 
            this.btn_odaberiDatoteku.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_odaberiDatoteku.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odaberiDatoteku.Location = new System.Drawing.Point(484, 30);
            this.btn_odaberiDatoteku.Name = "btn_odaberiDatoteku";
            this.btn_odaberiDatoteku.Size = new System.Drawing.Size(215, 39);
            this.btn_odaberiDatoteku.TabIndex = 0;
            this.btn_odaberiDatoteku.Text = "Odaberi datoteku";
            this.btn_odaberiDatoteku.UseVisualStyleBackColor = false;
            this.btn_odaberiDatoteku.Click += new System.EventHandler(this.btn_odaberiDatoteku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Odaberi datoteku:";
            // 
            // tb_imeDatoteke
            // 
            this.tb_imeDatoteke.Enabled = false;
            this.tb_imeDatoteke.Location = new System.Drawing.Point(208, 38);
            this.tb_imeDatoteke.Name = "tb_imeDatoteke";
            this.tb_imeDatoteke.Size = new System.Drawing.Size(243, 22);
            this.tb_imeDatoteke.TabIndex = 16;
            // 
            // btn_izracunajSazetak
            // 
            this.btn_izracunajSazetak.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_izracunajSazetak.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izracunajSazetak.Location = new System.Drawing.Point(176, 131);
            this.btn_izracunajSazetak.Name = "btn_izracunajSazetak";
            this.btn_izracunajSazetak.Size = new System.Drawing.Size(316, 64);
            this.btn_izracunajSazetak.TabIndex = 17;
            this.btn_izracunajSazetak.Text = "Izračunaj sažetak";
            this.btn_izracunajSazetak.UseVisualStyleBackColor = false;
            this.btn_izracunajSazetak.Click += new System.EventHandler(this.btn_izracunajSazetak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sažetak:";
            // 
            // tb_sazetak
            // 
            this.tb_sazetak.Enabled = false;
            this.tb_sazetak.Location = new System.Drawing.Point(176, 276);
            this.tb_sazetak.Multiline = true;
            this.tb_sazetak.Name = "tb_sazetak";
            this.tb_sazetak.Size = new System.Drawing.Size(300, 200);
            this.tb_sazetak.TabIndex = 18;
            // 
            // Sazetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_sazetak);
            this.Controls.Add(this.btn_izracunajSazetak);
            this.Controls.Add(this.tb_imeDatoteke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_odaberiDatoteku);
            this.Name = "Sazetak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sažetak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_odaberiDatoteku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_imeDatoteke;
        private System.Windows.Forms.Button btn_izracunajSazetak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sazetak;
    }
}