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
    public partial class formseyahatbilgileri : Form
    {
        public formseyahatbilgileri()
        {
            InitializeComponent();
            LoadAnnouncements();
            LoadCampaigns();
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
            tileControl1.Groups.Clear();  // Tüm grupları temizle
            TileGroup tileGroup = new TileGroup();  // Yeni bir grup oluştur
            tileControl1.Groups.Add(tileGroup);      // TileControl2'ye grubu ekle

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
            tileControl2.Groups.Clear();  // Tüm grupları temizle
            TileGroup tileGroup = new TileGroup();  // Yeni bir grup oluştur
            tileControl2.Groups.Add(tileGroup);     // TileControl1'e grubu ekle

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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void formseyahatbilgileri_Load(object sender, EventArgs e)
        {
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

        private void label13_Click(object sender, EventArgs e)
        {

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
            this.Hide();
            y1.Show();

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
