using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os2_projekt
{
    public partial class SimetricnaKriptografija : Form
    {
        private byte[] secretKey;
        private byte[] iv;

        OpenFileDialog ucitajDatoteku = new OpenFileDialog();

        public SimetricnaKriptografija()
        {
            InitializeComponent();
        }

        private void btn_odaberiDatoteku_Click(object sender, EventArgs e)
        {
            try
            {
                tb_uneseniTekst.Clear();
                tb_tajniKljuc.Clear();
                tb_iv.Clear();
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

        private void btn_generirajTajniKljuc_Click(object sender, EventArgs e)
        {
            try
            {
                //tajni ključ
                secretKey = new byte[32];

                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(secretKey);
                }

                File.WriteAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\tajniKljuc.txt", Convert.ToBase64String(secretKey));
                string tajniKljuc = File.ReadAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\tajniKljuc.txt");
                tb_tajniKljuc.Text = tajniKljuc;

                //iv
                iv = new byte[16];

                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(iv);
                }

                File.WriteAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\iv.txt", Convert.ToBase64String(iv));
                string vector = File.ReadAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\iv.txt");
                tb_iv.Text = vector;


                MessageBox.Show("Uspješno generirani ključevi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_kriptirajTekst_Click_1(object sender, EventArgs e)
        {
            try
            {
                string putanjaDoUnesenogTeksta = ucitajDatoteku.FileName;
                string uneseniTekst = File.ReadAllText(putanjaDoUnesenogTeksta);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = secretKey;
                    aes.IV = iv;

                    byte[] uneseniTekstBajtovi = Encoding.UTF8.GetBytes(uneseniTekst);
                    byte[] kriptiraniTekstBajtovi = null;
                    using (var encryptor = aes.CreateEncryptor())
                    {
                        kriptiraniTekstBajtovi = encryptor.TransformFinalBlock(uneseniTekstBajtovi, 0, uneseniTekstBajtovi.Length);
                    }
                    
                    StreamWriter streamWriter = new StreamWriter(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\kriptiraniTekst.txt");
                    streamWriter.WriteLine(Convert.ToBase64String(kriptiraniTekstBajtovi));
                    streamWriter.Close();

                    string kriptiraniTekst = File.ReadAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\kriptiraniTekst.txt");
                    tb_kriptiraniTekst.Text = kriptiraniTekst;

                    MessageBox.Show("Tekst je uspješno kriptiran!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_dekriptirajTekst_Click_1(object sender, EventArgs e)
        {
            try
            {
                String putanjaDoTajnogKljuca = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "tajniKljuc.txt");
                byte[] secretKey = Convert.FromBase64String(File.ReadAllText(putanjaDoTajnogKljuca));
                
                String putanjaDoIV = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "iv.txt");
                byte[] iv = Convert.FromBase64String(File.ReadAllText(putanjaDoIV));

                String putanjaDoKriptiranogTeksta = Path.Combine(new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "kriptiraniTekst.txt");
                byte[] kriptiraniTekstBajtovi = Convert.FromBase64String(File.ReadAllText(putanjaDoKriptiranogTeksta));

                using (Aes aes = Aes.Create())
                {
                    aes.Key = secretKey;
                    aes.IV = iv;

                    byte[] dekriptiraniTekstBajtovi = null;
                    using (var decryptor = aes.CreateDecryptor())
                    {
                        dekriptiraniTekstBajtovi = decryptor.TransformFinalBlock(kriptiraniTekstBajtovi, 0, kriptiraniTekstBajtovi.Length);
                    }

                    File.WriteAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\dekriptiraniTekst.txt", Encoding.UTF8.GetString(dekriptiraniTekstBajtovi));

                    string dekriptiraniTekst = File.ReadAllText(@"C:\Users\Matej\source\repos\os2_projekt\os2_projekt\bin\Debug\dekriptiraniTekst.txt");
                    tb_dekriptiraniTekst.Text = dekriptiraniTekst;

                    MessageBox.Show("Tekst je uspješno dekriptiran!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

