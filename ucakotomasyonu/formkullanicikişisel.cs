using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ucakotomasyonu
{
    public partial class formkullanicikişisel : Form
    {
        public formkullanicikişisel()
        {
            InitializeComponent();
        }
        public class Kullanici
        {
            public int Id { get; set; }
            public string Cinsiyet { get; set; }
            public string Isim { get; set; }
            public string Soyisim { get; set; }
            public string TcNo { get; set; }
            public DateTime DogumTarihi { get; set; }
            public string Eposta { get; set; }
            public string TelefonNo { get; set; }
        }


        private void yöneticigirbut_Click(object sender, EventArgs e)
        {
            formkullanici y1 = new formkullanici();
            this.Hide();
            y1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Boş alanları kontrol et
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }

            // Kullanıcıyı ekle
            bool sonuc = KullaniciEkle(
                comboBox1.Text,
                textBox1.Text,
                textBox7.Text,
                textBox6.Text,
                dateTimePicker1.Value,
                textBox4.Text,
                textBox3.Text
            );

            // Sonuca göre mesaj göster
            if (sonuc)
            {
                MessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı kaydı sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     

            if (sonuc)
            {
                MessageBox.Show("Kullanıcı başarıyla kaydedildi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı kaydı sırasında bir hata oluştu.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formkullaniciödeme a2 = new formkullaniciödeme();
            this.Hide();
            a2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formkullanicibilet a3 = new formkullanicibilet();
            this.Hide();
            a3.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            formkullanicipuan a4 = new formkullanicipuan();
            this.Hide();
            a4.Show();
        }
        private void anasayfabut_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }

        private void seyahatbilbut_Click(object sender, EventArgs e)
        {
            formseyahatbilgileri seyahatbilgiform = new formseyahatbilgileri();
            this.Hide();
            seyahatbilgiform.Show();

        }

        private void seyahatdenbut_Click(object sender, EventArgs e)
        {
            formseyahatdeneyimi sd1 = new formseyahatdeneyimi();
            this.Hide();
            sd1.Show();
        }

        private void kurumsalbut_Click(object sender, EventArgs e)
        {
            formkurumsal k1 = new formkurumsal();
            this.Hide();
            k1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formkullanicikişisel_Load(object sender, EventArgs e)
        {
            element1.Click += (s, ev) => NavigateToForm(new Form1());
            element2.Click += (s, ev) => NavigateToForm(new formseyahatbilgileri());
            element3.Click += (s, ev) => NavigateToForm(new formseyahatdeneyimi());
            element4.Click += (s, ev) => NavigateToForm(new formkurumsal());
            element5.Click += (s, ev) => NavigateToForm(new formkullanici());
            element6.Click += (s, ev) => NavigateToForm(new formkullanicikişisel());
            element7.Click += (s, ev) => NavigateToForm(new formkullaniciödeme());
            element8.Click += (s, ev) => NavigateToForm(new formkullanicibilet());
            element9.Click += (s, ev) => NavigateToForm(new formkullanicipuan());
            element23.Click += (s, ev) => NavigateToForm(new formyöneticigirisi());

        }
        private void NavigateToForm(Form targetForm)
        {
            this.Hide(); // Mevcut formu gizle
            targetForm.ShowDialog(); // Hedef formu aç
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
        public bool KullaniciEkle(string cinsiyet, string isim, string soyisim, string tcNo, DateTime dogumTarihi, string eposta, string telefonNo)
        {
            try
            {
                using (MySqlConnection conn = Veritabanı.Instance.GetConnection())
                {
                    string query = "INSERT INTO kullanicilar (cinsiyet, isim, soyisim, tc_no, dogum_tarihi, eposta, telefon_no) " +
                                   "VALUES (@cinsiyet, @isim, @soyisim, @tcNo, @dogumTarihi, @eposta, @telefonNo)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        cmd.Parameters.AddWithValue("@isim", isim);
                        cmd.Parameters.AddWithValue("@soyisim", soyisim);
                        cmd.Parameters.AddWithValue("@tcNo", tcNo);
                        cmd.Parameters.AddWithValue("@dogumTarihi", dogumTarihi.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@eposta", eposta);
                        cmd.Parameters.AddWithValue("@telefonNo", telefonNo);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true; // Başarılı
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Başarısız
            }
        }

        public List<string[]> KullaniciBilgileriniGetir()
        {
            List<string[]> kullaniciListesi = new List<string[]>();

            try
            {
                using (MySqlConnection conn = Veritabanı.Instance.GetConnection())
                {
                    string query = "SELECT cinsiyet, isim, soyisim, tc_no, dogum_tarihi, eposta, telefon_no FROM kullanicilar";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string[] kullanici = new string[]
                            {
                        reader["cinsiyet"].ToString(),
                        reader["isim"].ToString(),
                        reader["soyisim"].ToString(),
                        reader["tc_no"].ToString(),
                        reader["dogum_tarihi"].ToString(),
                        reader["eposta"].ToString(),
                        reader["telefon_no"].ToString()
                            };

                            kullaniciListesi.Add(kullanici);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            return kullaniciListesi;
        }
        private void FormYuklendiginde()
        {
            var kullaniciBilgileri = KullaniciBilgileriniGetir();

            if (kullaniciBilgileri.Count > 0)
            {
                // Örneğin ilk kullanıcıyı göstermek istiyorsan:
                comboBox1.Text = kullaniciBilgileri[0][0];
                textBox1.Text = kullaniciBilgileri[0][1];
                textBox7.Text = kullaniciBilgileri[0][2];
                textBox6.Text = kullaniciBilgileri[0][3];
                dateTimePicker1.Value = DateTime.Parse(kullaniciBilgileri[0][4]);
                textBox4.Text = kullaniciBilgileri[0][5];
                textBox3.Text = kullaniciBilgileri[0][6];
            }
            else
            {
                MessageBox.Show("Henüz kayıtlı kullanıcı yok.");
            }
        }




    }
}
