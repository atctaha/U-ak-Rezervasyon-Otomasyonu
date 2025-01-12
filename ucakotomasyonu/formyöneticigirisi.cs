using MySqlConnector;
using System;
using System.Windows.Forms;
using System.Drawing;  // Bu satırı ekleyin


namespace ucakotomasyonu
{
    public partial class formyöneticigirisi : Form
    {
        public formyöneticigirisi()
        {
            InitializeComponent();
        }

        private void anasayfabut_Click(object sender, EventArgs e)
        {
            
        }

        private void seyahatbilbut_Click(object sender, EventArgs e)
        {
          
        }

        private void seyahatdenbut_Click(object sender, EventArgs e)
        {
            
        }

        private void kurumsalbut_Click(object sender, EventArgs e)
        {
            formkurumsal k1 = new formkurumsal();
            this.Hide();
            k1.Show();
        }

        private void yöneticigirbut_Click(object sender, EventArgs e)
        {
            formyöneticigirisi y1 = new formyöneticigirisi();
            this.Hide();
            y1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bu butonun kullanımı gereksiz, dolayısıyla boş bırakılabilir.
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Bu butonun kullanımı gereksiz, dolayısıyla boş bırakılabilir.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.AutoSize = true;
        }

        private void textEdit1_Enter(object sender, EventArgs e)
        {
            if (textEdit1.Text == "Şifre")
            {
                textEdit1.Text = "";
                textEdit1.ForeColor = Color.Black;
            }
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
            if (textEdit1.Text == "")
            {
                textEdit1.Text = "ŞİFRE";
                textEdit1.ForeColor = Color.Gray;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textEdit1.Text;

            // Veritabanı bağlantısını oluştur
            var dbConnection = Veritabanı.Instance.GetConnection();

            try
            {
                // Kullanıcı adı ve şifreyi doğrulamak için sorgu
                string query = "SELECT * FROM kayitpaneli WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", sifre);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())  // Kullanıcı bulunduysa
                {
                    string gorev = reader["Gorev"].ToString();

                    if (gorev == "Yönetici")
                    {
                        // Yönetici formuna geçiş
                        formyönetici yntc1 = new formyönetici();
                        this.Hide();
                        yntc1.Show();
                    }
                    else if (gorev == "Kullanıcı")
                    {
                        // Kullanıcı formuna geçiş
                        formkullanici klnc1 = new formkullanici();
                        this.Hide();
                        klnc1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz görev.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                Veritabanı.Instance.CloseConnection();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            formyöneticikayit kk11 = new formyöneticikayit();
            this.Hide();
            kk11.Show();
        }

        private void panelanasayfa_Paint(object sender, PaintEventArgs e)
        {
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // Bu butonun kullanımı gereksiz, dolayısıyla boş bırakılabilir.
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Bu butonun kullanımı gereksiz, dolayısıyla boş bırakılabilir.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Şifreyi göster/gizle butonu işlevi
            if (textEdit1.Properties.PasswordChar == '\0') // Şifre görünürse
            {
                textEdit1.Properties.PasswordChar = '*'; // Şifreyi gizle
                button1.Text = "Göster"; // Buton metnini "Göster" yap
            }
            else // Şifre gizli ise
            {
                textEdit1.Properties.PasswordChar = '\0'; // Şifreyi görünür yap
                button1.Text = "Gizle"; // Buton metnini "Gizle" yap
            }
        }

        private void formyöneticigirisi_Load(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            // Burada yapılacak işlemleri yazabilirsiniz
        }

    }
}
