using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os2_projekt
{
    public partial class DigitalniPotpis : Form
    {
        OpenFileDialog ucitajDatoteku = new OpenFileDialog();

        public DigitalniPotpis()
        {
            InitializeComponent();
        }

        private void btn_odaberiDatoteku_Click_1(object sender, EventArgs e)
        {
            try
            {
                ucitajDatoteku.ShowDialog();

                string putanjaDatoteke = ucitajDatoteku.FileName;
                string imeDatoteke = Path.GetFileName(putanjaDatoteke);

                tb_imeDatoteke.Text = imeDatoteke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_potpisiDatoteku_Click(object sender, EventArgs e)
        {
            try
            {
                using (RSACryptoServiceProvider RSAcsp = new RSACryptoServiceProvider())
                {
                    string privatniKljuc = File.ReadAllText("privatniKljuc.txt");
                    RSAcsp.FromXmlString(privatniKljuc);

                    string sazetak = File.ReadAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\sazetak.txt");
                    byte[] sazetakBajtovi = Convert.FromBase64String(sazetak);

                    byte[] digitalniPotpisBajtovi = RSAcsp.SignHash(sazetakBajtovi, CryptoConfig.MapNameToOID("SHA256"));

                    File.WriteAllText("digitalniPotpis.txt", Convert.ToBase64String(digitalniPotpisBajtovi));
                    tb_digitalniPotpis.Text = Convert.ToBase64String(digitalniPotpisBajtovi);
                }
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_provjeriPotpis_Click(object sender, EventArgs e)
        {
            try
            {
                using (RSACryptoServiceProvider RSAcsp = new RSACryptoServiceProvider())
                {
                    string javniKljuc = File.ReadAllText("javniKljuc.txt");
                    RSAcsp.FromXmlString(javniKljuc);

                    string digitalniPotpis = File.ReadAllText("digitalniPotpis.txt");
                    byte[] digitalniPotpisBajtovi = Convert.FromBase64String(digitalniPotpis);

                    string izracunatiSazetak = IzracunajSazetak();
                    byte[] izracunatiSazetakBajtovi = Convert.FromBase64String(izracunatiSazetak);

                    bool digitalniPotpisIspravan = RSAcsp.VerifyHash(izracunatiSazetakBajtovi, CryptoConfig.MapNameToOID("SHA256"), digitalniPotpisBajtovi);

                    if (digitalniPotpisIspravan == true)
                    {
                        MessageBox.Show("Digitalni potpis je ispravan!");
                    }
                    else
                    {
                        MessageBox.Show("Digitalni potpis nije ispravan!");
                    }
                }
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string IzracunajSazetak()
        {
            string sazetakString = "";

            if (tb_imeDatoteke.Text != "")
            {
                string putanjaDatoteke = ucitajDatoteku.FileName;

                using (var sha256 = SHA256.Create())
                {
                    using (var fileStream = File.OpenRead(putanjaDatoteke))
                    {
                        var sazetak = sha256.ComputeHash(fileStream);
                        sazetakString = Convert.ToBase64String(sazetak);
                    }
                }
                return sazetakString;
            }
            else
            {
                MessageBox.Show("Datoteka nije odabrana!");
                return null;
            }
        }
    }
}

