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
    public partial class formkullaniciödeme : Form
    {
        public formkullaniciödeme()
        {
            InitializeComponent();
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
            formkullanicikişisel a1 = new formkullanicikişisel();
            this.Hide();
            a1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
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

        private void formkullaniciödeme_Load(object sender, EventArgs e)
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
        public bool KartEkle(string kartNo, string isim, string cvc)
        {
            try
            {
                using (MySqlConnection conn = Veritabanı.Instance.GetConnection())
                {
                    string query = "INSERT INTO kartlar (kart_no, isim, cvc) VALUES (@kartNo, @isim, @cvc)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kartNo", kartNo);
                        cmd.Parameters.AddWithValue("@isim", isim);
                        cmd.Parameters.AddWithValue("@cvc", cvc);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true; // Başarılı
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return false; // Başarısız
            }
        }
        public void KartlariComboBoxaDoldur()
        {
            try
            {
                comboBox1.Items.Clear(); // Önce ComboBox'ı temizle

                using (MySqlConnection conn = Veritabanı.Instance.GetConnection())
                {
                    string query = "SELECT kart_id, kart_no FROM kartlar"; // kart_id ve kart_no'yu çekiyoruz

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Kart ID'si ve Kart Numarasını ComboBox'a ekle
                            comboBox1.Items.Add(new
                            {
                                KartID = reader["kart_id"],
                                KartNo = reader["kart_no"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void comboBoxKartID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var secilenKart = (dynamic)comboBox1.SelectedItem; // Seçilen kartı al

                int kartID = secilenKart.KartID;
                string kartNo = secilenKart.KartNo;

                // Kart bilgilerini al
                using (MySqlConnection conn = Veritabanı.Instance.GetConnection())
                {
                    string query = "SELECT * FROM kartlar WHERE kart_id = @kartID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kartID", kartID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Formdaki alanları doldur
                                textBox1.Text = reader["kart_id"].ToString();
                                textBox2.Text = reader["kart_no"].ToString();
                                textBox3.Text = reader["isim"].ToString();
                                textBox4.Text = reader["cvc"].ToString();

                                // Kart ID alanını disabled yap
                                textBox1.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        public bool KartSil(int kartID)
        {
            try
            {
                using (MySqlConnection conn = Veritabanı.Instance.GetConnection())
                {
                    string query = "DELETE FROM kartlar WHERE kart_id = @kartID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kartID", kartID);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true; // Başarılı
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return false; // Başarısız
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
               var secilenKart = (dynamic)comboBox1.SelectedItem;

                if (secilenKart != null)
                {
                    int kartID = secilenKart.KartID;
                    bool sonuc = KartSil(kartID);

                    if (sonuc)
                    {
                        MessageBox.Show("Kart başarıyla silindi.");
                        KartlariComboBoxaDoldur(); // Kartlar güncellenir
                    }
                    else
                    {
                        MessageBox.Show("Kart silinirken bir hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Silinecek kartı seçiniz.");
                }
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgileri al
            string kartNo = textBox2.Text;
            string isim = textBox3.Text;
            string cvc = textBox4.Text;

            // Eğer herhangi bir alan boşsa uyarı göster
            if (string.IsNullOrWhiteSpace(kartNo) || string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(cvc))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Kart bilgilerini veritabanına ekle
            bool sonuc = KartEkle(kartNo, isim, cvc);

            if (sonuc)
            {
                MessageBox.Show("Kart başarıyla kaydedildi.");
                KartlariComboBoxaDoldur();  // Kartları ComboBox'a yeniden doldur
            }
            else
            {
                MessageBox.Show("Kart eklenirken bir hata oluştu.");
            }
        }
    }
}
