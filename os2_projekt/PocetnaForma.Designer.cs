namespace os2_projekt
{
    partial class PocetnaForma
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
            this.btn_simetricnaKriptografija = new System.Windows.Forms.Button();
            this.btn_asimetricnaKriptografija = new System.Windows.Forms.Button();
            this.btn_sazetak = new System.Windows.Forms.Button();
            this.btn_digitalniPotpis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_simetricnaKriptografija
            // 
            this.btn_simetricnaKriptografija.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_simetricnaKriptografija.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simetricnaKriptografija.Location = new System.Drawing.Point(25, 129);
            this.btn_simetricnaKriptografija.Name = "btn_simetricnaKriptografija";
            this.btn_simetricnaKriptografija.Size = new System.Drawing.Size(209, 76);
            this.btn_simetricnaKriptografija.TabIndex = 0;
            this.btn_simetricnaKriptografija.Text = "Simetrična kriptografija";
            this.btn_simetricnaKriptografija.UseVisualStyleBackColor = false;
            this.btn_simetricnaKriptografija.Click += new System.EventHandler(this.btn_simetricnaKriptografija_Click);
            // 
            // btn_asimetricnaKriptografija
            // 
            this.btn_asimetricnaKriptografija.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_asimetricnaKriptografija.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asimetricnaKriptografija.Location = new System.Drawing.Point(273, 129);
            this.btn_asimetricnaKriptografija.Name = "btn_asimetricnaKriptografija";
            this.btn_asimetricnaKriptografija.Size = new System.Drawing.Size(209, 76);
            this.btn_asimetricnaKriptografija.TabIndex = 1;
            this.btn_asimetricnaKriptografija.Text = "Asimetrična kriptografija";
            this.btn_asimetricnaKriptografija.UseVisualStyleBackColor = false;
            this.btn_asimetricnaKriptografija.Click += new System.EventHandler(this.btn_asimetricnaKriptografija_Click_1);
            // 
            // btn_sazetak
            // 
            this.btn_sazetak.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_sazetak.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sazetak.Location = new System.Drawing.Point(526, 129);
            this.btn_sazetak.Name = "btn_sazetak";
            this.btn_sazetak.Size = new System.Drawing.Size(209, 76);
            this.btn_sazetak.TabIndex = 2;
            this.btn_sazetak.Text = "Sažetak";
            this.btn_sazetak.UseVisualStyleBackColor = false;
            this.btn_sazetak.Click += new System.EventHandler(this.btn_sazetak_Click);
            // 
            // btn_digitalniPotpis
            // 
            this.btn_digitalniPotpis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_digitalniPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_digitalniPotpis.Location = new System.Drawing.Point(775, 129);
            this.btn_digitalniPotpis.Name = "btn_digitalniPotpis";
            this.btn_digitalniPotpis.Size = new System.Drawing.Size(209, 76);
            this.btn_digitalniPotpis.TabIndex = 3;
            this.btn_digitalniPotpis.Text = "Digitalni potpis";
            this.btn_digitalniPotpis.UseVisualStyleBackColor = false;
            this.btn_digitalniPotpis.Click += new System.EventHandler(this.btn_digitalniPotpis_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::os2_projekt.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(1029, 345);
            this.Controls.Add(this.btn_digitalniPotpis);
            this.Controls.Add(this.btn_sazetak);
            this.Controls.Add(this.btn_asimetricnaKriptografija);
            this.Controls.Add(this.btn_simetricnaKriptografija);
            this.Name = "PocetnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna forma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_simetricnaKriptografija;
        private System.Windows.Forms.Button btn_asimetricnaKriptografija;
        private System.Windows.Forms.Button btn_sazetak;
        private System.Windows.Forms.Button btn_digitalniPotpis;
    }
}

