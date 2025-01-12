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
using DevExpress.XtraEditors;

namespace ucakotomasyonu
{
    public partial class formseyahatdeneyimi : Form
    {
        public formseyahatdeneyimi()
        {
            InitializeComponent();
            LoadAnnouncements();
            LoadCampaigns();
        }
        private void LoadSeferler()
        {
            string query = "SELECT sefer_no FROM seferler";

            try
            {
                // Veritabanı bağlantısını al
                using (var connection = Veritabanı.Instance.GetConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Sefer_no değerini ComboBox'a ekle
                                comboBox1.Items.Add(reader["sefer_no"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                Veritabanı.Instance.CloseConnection();
            }
        }
        private void SaveDataToDatabase()
        {
            // Veritabanı bağlantısını al
            using (MySqlConnection connection = Veritabanı.Instance.GetConnection())
            {
                // Kullanıcıdan alınan değerleri değişkenlere ata
                string isim = textBox1.Text;
                string eposta = textBox2.Text;
                string deneyim = richTextBox1.Text;
                string sefer_no = comboBox1.Text;

                // SQL sorgusu
                string query1 = "INSERT INTO seferler(sefer_no) VALUES (sefer_no)";
                string query = "INSERT INTO KullaniciBilgileri (Isim, Eposta, Deneyim) VALUES (@isim, @eposta, @deneyim)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@isim", isim);
                        command.Parameters.AddWithValue("@eposta", eposta);
                        command.Parameters.AddWithValue("@deneyim", deneyim);
                        command.Parameters.AddWithValue("@sefer_no",sefer_no);

                        // Sorguyu çalıştır
                        command.ExecuteNonQuery();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    // Bağlantıyı kapatma
                    Veritabanı.Instance.CloseConnection();
                }
            }
        }
        private void LoadAnnouncements()
        {
            // Veritabanı bağlantısını al
            MySqlConnection connection = Veritabanı.Instance.GetConnection();

            // Duyuruları çekmek için SQL sorgusunu oluştur
            string query = "SELECT duyuru_id, baslik, icerik FROM Duyurular";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            // TileControl2'yi kullan (formda varsa)
            tileControl6.Groups.Clear();  // Tüm grupları temizle
            TileGroup tileGroup = new TileGroup();  // Yeni bir grup oluştur
            tileControl6.Groups.Add(tileGroup);      // TileControl2'ye grubu ekle

            // Veritabanından okunan her duyuru için TileItem ekleyin
            while (reader.Read())
            {
                string duyuruBaslik = reader["baslik"].ToString();
                string duyuruIcerik = reader["icerik"].ToString();

                // Yeni bir TileItem oluştur
                TileItem tileItem = new TileItem();
                tileItem.Appearance.BackColor = Color.Black;


                // Başlık için TileItemElement oluştur
                TileItemElement titleElement = new TileItemElement();
                titleElement.Text = duyuruBaslik;
                titleElement.TextAlignment = TileItemContentAlignment.TopCenter;  // Başlık üstte ortalanacak
                tileItem.Elements.Add(titleElement);

                // İçerik için TileItemElement oluştur
                TileItemElement contentElement = new TileItemElement();
                contentElement.Text = duyuruIcerik;
                contentElement.TextAlignment = TileItemContentAlignment.BottomCenter;  // İçerik altta ortalanacak
                tileItem.Elements.Add(contentElement);

                // TileItem'i TileGroup'a ekle
                tileGroup.Items.Add(tileItem);
            }

            // Veritabanı bağlantısını kapat
            reader.Close();
            Veritabanı.Instance.CloseConnection();
        }
        private void LoadCampaigns()
        {
            // Veritabanı bağlantısını al
            MySqlConnection connection = Veritabanı.Instance.GetConnection();

            // Kampanyaları çekmek için SQL sorgusunu oluştur
            string query = "SELECT kampanya_id, baslik, icerik FROM Kampanyalar";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            // TileControl1'i kullan (kampanyalar için)
            tileControl5.Groups.Clear();  // Tüm grupları temizle
            TileGroup tileGroup = new TileGroup();  // Yeni bir grup oluştur
            tileControl5.Groups.Add(tileGroup);     // TileControl1'e grubu ekle

            // Veritabanından okunan her kampanya için TileItem ekleyin
            while (reader.Read())
            {
                string kampanyaBaslik = reader["baslik"].ToString();
                string kampanyaIcerik = reader["icerik"].ToString();

                // Yeni bir TileItem oluştur
                TileItem tileItem = new TileItem();
                tileItem.Appearance.BackColor = Color.Black;


                // Başlık için TileItemElement oluştur
                TileItemElement titleElement = new TileItemElement();
                titleElement.Text = kampanyaBaslik;
                titleElement.TextAlignment = TileItemContentAlignment.TopCenter;  // Başlık üstte ortalanacak
                tileItem.Elements.Add(titleElement);

                // İçerik için TileItemElement oluştur
                TileItemElement contentElement = new TileItemElement();
                contentElement.Text = kampanyaIcerik;
                contentElement.TextAlignment = TileItemContentAlignment.BottomCenter;  // İçerik altta ortalanacak
                tileItem.Elements.Add(contentElement);

                // TileItem'i TileGroup'a ekle
                tileGroup.Items.Add(tileItem);
            }

            // Veritabanı bağlantısını kapat
            reader.Close();
            Veritabanı.Instance.CloseConnection();
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

        private void yöneticigirbut_Click(object sender, EventArgs e)
        {
            formkullanici y1 = new formkullanici();
            this.Close();
            y1.Show();
        }

        private void formseyahatdeneyimi_Load(object sender, EventArgs e)
        {
            LoadSeferler();

            element1.Click += (s, ev) => NavigateToForm(new Form1());
            element2.Click += (s, ev) => NavigateToForm(new formseyahatbilgileri());
            element3.Click += (s, ev) => NavigateToForm(new formseyahatdeneyimi());
            element4.Click += (s, ev) => NavigateToForm(new formkurumsal());
            element5.Click += (s, ev) => NavigateToForm(new formkullanici());
        }
        private void NavigateToForm(Form targetForm)
        {
            this.Hide(); // Mevcut formu gizle
            targetForm.ShowDialog(); // Hedef formu aç
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneyiminiz iletildi...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveDataToDatabase();
            MessageBox.Show("Deneyiminiz gönderildi..");
        }
    }
}
