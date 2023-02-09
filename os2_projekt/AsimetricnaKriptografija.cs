using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace os2_projekt
{
    public partial class AsimetricnaKriptografija : Form
    {
        OpenFileDialog ucitajDatoteku = new OpenFileDialog();

        public AsimetricnaKriptografija()
        {
            InitializeComponent();
        }
        
        private void btn_odaberiDatoteku_Click(object sender, EventArgs e)
        {
            try
            {
                tb_uneseniTekst.Clear();
                tb_javniKljuc.Clear();
                tb_privatniKljuc.Clear();
                tb_kriptiraniTekst.Clear();
                tb_dekriptiraniTekst.Clear();

                ucitajDatoteku.ShowDialog();

                string putanjaDatoteke = ucitajDatoteku.FileName;
                string imeDatoteke = Path.GetFileName(putanjaDatoteke);

                tb_imeDatoteke.Text = imeDatoteke;
                tb_uneseniTekst.Text = File.ReadAllText(Path.GetFileName(putanjaDatoteke));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_generirajKljuceve_Click(object sender, EventArgs e)
        {
            using(RSACryptoServiceProvider RSAcsp = new RSACryptoServiceProvider())
            {
                try
                {
                    //javni kljuc
                    StreamWriter streamWriter = new StreamWriter(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\javniKljuc.txt");
                    streamWriter.WriteLine(RSAcsp.ToXmlString(false));
                    streamWriter.Close();

                    string javniKljuc = File.ReadAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\javniKljuc.txt");
                    tb_javniKljuc.Text = javniKljuc;

                    //privatni kljuc
                    streamWriter = new StreamWriter(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\privatniKljuc.txt");
                    streamWriter.WriteLine(RSAcsp.ToXmlString(true));
                    streamWriter.Close();

                    string privatniKljuc = File.ReadAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\privatniKljuc.txt");
                    tb_privatniKljuc.Text = privatniKljuc;

                    MessageBox.Show("Uspješno generirani ključevi!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_kriptirajTekst_Click(object sender, EventArgs e)
        {
            try
            {
                string javniKljuc = File.ReadAllText("javniKljuc.txt");

                string putanjaDoUnesenogTeksta = ucitajDatoteku.FileName;
                string uneseniTekst = File.ReadAllText(putanjaDoUnesenogTeksta);
                
                using(RSACryptoServiceProvider RSAcsp = new RSACryptoServiceProvider())
                {
                    RSAcsp.FromXmlString(javniKljuc);
                    byte[] privrmeniBajtovi = System.Text.Encoding.UTF8.GetBytes(uneseniTekst);
                    string uneseniTekst64 = Convert.ToBase64String(privrmeniBajtovi);

                    byte[] uneseniTekstBajtovi = Convert.FromBase64String(uneseniTekst64);
                    byte[] kriptiraniTekstBajtovi = RSAcsp.Encrypt(uneseniTekstBajtovi, true);
                    
                    StreamWriter streamWriter = new StreamWriter(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\kriptiraniTekst.txt");
                    streamWriter.WriteLine(Convert.ToBase64String(kriptiraniTekstBajtovi));
                    streamWriter.Close();

                    string kriptiraniTekst = File.ReadAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\kriptiraniTekst.txt");
                    tb_kriptiraniTekst.Text = kriptiraniTekst;

                    MessageBox.Show("Tekst je uspješno kriptiran!");
                }
            }
            catch(CryptographicException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDekriptirajTekst_Click(object sender, EventArgs e)
        {
            try
            {
                string privatniKljuc = File.ReadAllText("privatniKljuc.txt");
                string kriptiraniTekst = File.ReadAllText("kriptiraniTekst.txt");

                byte[] kriptiraniTekstBajtovi = Convert.FromBase64String(kriptiraniTekst);

                using (RSACryptoServiceProvider RSAcsp = new RSACryptoServiceProvider())
                {
                    RSAcsp.FromXmlString(privatniKljuc);

                    byte[] dekriptiraniTekstBajtovi = RSAcsp.Decrypt(kriptiraniTekstBajtovi, true);
                    string dekriptiraniTekst64 = Convert.ToBase64String(dekriptiraniTekstBajtovi);
                    byte[] privremeniBajtovi = Convert.FromBase64String(dekriptiraniTekst64);
                    string dekriptiraniTekst = System.Text.Encoding.UTF8.GetString(privremeniBajtovi);
                    
                    StreamWriter streamWriter = new StreamWriter(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\dekriptiraniTekst.txt");
                    streamWriter.WriteLine(dekriptiraniTekst);
                    streamWriter.Close();

                    tb_dekriptiraniTekst.Text = dekriptiraniTekst;

                    MessageBox.Show("Tekst je uspješno dekriptiran!");
                }
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
