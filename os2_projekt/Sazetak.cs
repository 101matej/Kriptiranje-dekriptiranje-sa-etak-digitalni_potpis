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
    public partial class Sazetak : Form
    {
        OpenFileDialog ucitajDatoteku = new OpenFileDialog();

        public Sazetak()
        {
            InitializeComponent();
        }

        private void btn_odaberiDatoteku_Click(object sender, EventArgs e)
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

        private void btn_izracunajSazetak_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_imeDatoteke.Text != "")
                {
                    string putanjaDatoteke = ucitajDatoteku.FileName;

                    using (var sha256 = SHA256.Create())
                    {
                        using (var fileStream = File.OpenRead(putanjaDatoteke))
                        {
                            var sazetak = sha256.ComputeHash(fileStream);
                            string sazetakString = Convert.ToBase64String(sazetak);

                            File.WriteAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\sazetak.txt", sazetakString);

                            tb_sazetak.Text = sazetakString;

                            MessageBox.Show("Sažetak je uspješno izračunat!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Datoteka nije odabrana!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
