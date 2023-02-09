using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os2_projekt
{
    public partial class PocetnaForma : Form
    {
        private byte[] iv;
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void btn_asimetricnaKriptografija_Click_1(object sender, EventArgs e)
        {
            AsimetricnaKriptografija asimetricnaKriptografija = new AsimetricnaKriptografija();
            this.Hide();
            asimetricnaKriptografija.ShowDialog();
            this.Show();
        }

        private void btn_simetricnaKriptografija_Click(object sender, EventArgs e)
        {
            SimetricnaKriptografija simetricnaKriptografija = new SimetricnaKriptografija();
            this.Hide();
            simetricnaKriptografija.ShowDialog();
            this.Show();
        }

        private void btn_sazetak_Click(object sender, EventArgs e)
        {
            Sazetak sazetak = new Sazetak();
            this.Hide();
            sazetak.ShowDialog();
            this.Show();
        }

        private void btn_digitalniPotpis_Click(object sender, EventArgs e)
        {
            DigitalniPotpis digitalniPotpis = new DigitalniPotpis();
            this.Hide();
            digitalniPotpis.ShowDialog();
            this.Show();
        }
    }
}
