using MySqlConnector; 
using System;
using System.Windows.Forms;

namespace ucakotomasyonu
{
    public partial class formyöneticikayit : Form
    {
        public formyöneticikayit()
        {
            InitializeComponent();
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // Buraya çizim veya görünümle ilgili kodlar yazabilirsiniz
        }


        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textEdit1.Text) ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısını oluştur
            try
            {
                // Singleton üzerinden veritabanı bağlantısını alıyoruz
                using (MySqlConnection conn = Veritabanı.Instance.GetConnection())
                {
                    // Kullanıcı adı kontrolü
                    string checkQuery = "SELECT COUNT(*) FROM kayitpaneli WHERE KullaniciAdi = @KullaniciAdi";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@KullaniciAdi", textBox3.Text);
                        int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userExists > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten alınmış. Lütfen farklı bir kullanıcı adı seçiniz.",
                                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Yeni kullanıcı ekleme sorgusu
                    string insertQuery = "INSERT INTO kayitpaneli (KullaniciAdi, Sifre, Gorev) VALUES (@KullaniciAdi, @Sifre, @Gorev)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Sifre", textEdit1.Text);
                        cmd.Parameters.AddWithValue("@Gorev", comboBox1.SelectedItem.ToString());

                        cmd.ExecuteNonQuery(); // Sorguyu çalıştır

                        MessageBox.Show("Kayıt başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Formu temizle
                        textBox3.Clear();
                        textEdit1.Text = "";
                        comboBox1.SelectedIndex = -1;

                        // Yönetici giriş formuna yönlendir
                        formyöneticigirisi girisFormu = new formyöneticigirisi();
                        this.Hide();
                        girisFormu.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                Veritabanı.Instance.CloseConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Şifreyi göster/gizle butonu işlevi
            if (textEdit1.Properties.PasswordChar == '\0') // Şifre görünürse
            {
                textEdit1.Properties.PasswordChar = '*'; // Şifreyi gizle
                button2.Text = "Göster"; // Buton metnini "Göster" yap
            }
            else // Şifre gizli ise
            {
                textEdit1.Properties.PasswordChar = '\0'; // Şifreyi görünür yap
                button2.Text = "Gizle"; // Buton metnini "Gizle" yap
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            formyöneticigirisi a1 = new formyöneticigirisi();
            this.Hide();
            a1.Show();
        }

        private void formyöneticikayit_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
