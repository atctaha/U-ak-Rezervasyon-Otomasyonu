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
    public partial class formduyuvekampanya : Form
    {
        public formduyuvekampanya()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baslik = textBox1.Text;
            string icerik = textBox2.Text;
            DuyuruEkle(baslik, icerik);

            // Güncelleme işlemleri
            textBox7.Text = GetNextDuyuruId().ToString();  // Yeni ID'yi doldur
            DuyurulariComboBoxaEkle(comboBox1);            // ComboBox'ı güncelle
            DuyurulariListele(listBox1);                   // ListBox'ı güncelle
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            formyönetici y1 = new formyönetici();
            this.Close();
            y1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formduyuvekampanya_Load(object sender, EventArgs e)
        {
            element1.Click += (s, ev) => NavigateToForm(new formduyuvekampanya());
            element2.Click += (s, ev) => NavigateToForm(new formseferpaneli());
            element3.Click += (s, ev) => NavigateToForm(new formdeneyimgoruntuleme());
            element4.Click += (s, ev) => NavigateToForm(new formrezervpaneli());
            element23.Click += (s, ev) => NavigateToForm(new formyöneticigirisi());



            // Duyuru ID'yi otomatik doldur
            textBox7.Text = GetNextDuyuruId().ToString();

                // Duyuruları listele ve ComboBox'ı doldur
                DuyurulariComboBoxaEkle(comboBox1);
                DuyurulariListele(listBox1);

            
                textBox3.Text = GetNextKampanyaId().ToString();  // Kampanya ID otomatik doldur
                KampanyalariComboBoxaEkle(comboBox2);           // ComboBox doldur
                KampanyalariListele(listBox2);                  // ListBox doldur
            



        }
        private void NavigateToForm(Form targetForm)
        {
            this.Hide(); // Mevcut formu gizle
            targetForm.ShowDialog(); // Hedef formu aç
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formyöneticigirisi a1 = new formyöneticigirisi();
            this.Hide();
            a1.Show();
        }


        public void DuyuruEkle(string baslik, string icerik)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "INSERT INTO duyurular (baslik, icerik) VALUES (@baslik, @icerik)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@baslik", baslik);
                    cmd.Parameters.AddWithValue("@icerik", icerik);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DuyuruSil(int duyuruId)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "DELETE FROM duyurular WHERE duyuru_id = @duyuruId";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@duyuruId", duyuruId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DuyurulariListele(ListBox listBox)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "SELECT duyuru_id, baslik FROM duyurular";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        listBox.Items.Clear();
                        while (reader.Read())
                        {
                            string duyuru = $"ID: {reader["duyuru_id"]}, Başlık: {reader["baslik"]}";
                            listBox.Items.Add(duyuru);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int duyuruId = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                DuyuruSil(duyuruId);

                // Güncelleme işlemleri
                textBox7.Text = GetNextDuyuruId().ToString();  // Yeni ID'yi doldur
                DuyurulariComboBoxaEkle(comboBox1);            // ComboBox'ı güncelle
                DuyurulariListele(listBox1);                   // ListBox'ı güncelle
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir duyuru seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void DuyurulariComboBoxaEkle(ComboBox comboBox)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "SELECT duyuru_id FROM duyurular";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        comboBox.Items.Clear();
                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader["duyuru_id"].ToString());
                        }
                    }
                }
            }
        }
        public int GetNextDuyuruId()
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "SELECT MAX(duyuru_id) FROM duyurular";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;
                }
            }
        }
        public void KampanyaEkle(string baslik, string icerik)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "INSERT INTO kampanyalar (baslik, icerik) VALUES (@baslik, @icerik)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@baslik", baslik);
                    cmd.Parameters.AddWithValue("@icerik", icerik);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void KampanyaSil(int kampanyaId)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "DELETE FROM kampanyalar WHERE kampanya_id = @id";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", kampanyaId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int GetNextKampanyaId()
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "SELECT MAX(kampanya_id) FROM kampanyalar";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;
                }
            }
        }
        public void KampanyalariComboBoxaEkle(ComboBox comboBox)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "SELECT kampanya_id FROM kampanyalar";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        comboBox.Items.Clear();
                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader["kampanya_id"].ToString());
                        }
                    }
                }
            }
        }

        public void KampanyalariListele(ListBox listBox)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "SELECT * FROM kampanyalar";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        listBox.Items.Clear();
                        while (reader.Read())
                        {
                            string kampanya = $"ID: {reader["kampanya_id"]} | Başlık: {reader["baslik"]} | İçerik: {reader["icerik"]}";
                            listBox.Items.Add(kampanya);
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string baslik = textBox6.Text;
            string icerik = textBox5.Text;
            KampanyaEkle(baslik, icerik);

            // Güncelleme işlemleri
            textBox3.Text = GetNextKampanyaId().ToString();  // Yeni ID'yi doldur
            KampanyalariComboBoxaEkle(comboBox2);            // ComboBox'ı güncelle
            KampanyalariListele(listBox2);                   // ListBox'ı güncelle
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                int kampanyaId = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                KampanyaSil(kampanyaId);

                // Güncelleme işlemleri
                textBox3.Text = GetNextKampanyaId().ToString();  // Yeni ID'yi doldur
                KampanyalariComboBoxaEkle(comboBox2);            // ComboBox'ı güncelle
                KampanyalariListele(listBox2);                   // ListBox'ı güncelle
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kampanya seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
