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
    public partial class formkurumsal : Form
    {
        public formkurumsal()
        {
            InitializeComponent();
            LoadAnnouncements();
            LoadCampaigns();
            timer1.Start();
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
            this.Hide();
            y1.Show();
        }

        private void seyahatdenbut_Click_1(object sender, EventArgs e)
        {
            formseyahatdeneyimi sd1 = new formseyahatdeneyimi();
            this.Hide();
            sd1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button6.Enabled = true;

            
            if (label1.Text==button5.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();

            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button6.Enabled = true;


            
            if (label1.Text == button4.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();

            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button6.Enabled = true;


            
            if (label1.Text == button3.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();

            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button6.Enabled = true;


            
            if (label1.Text == button2.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();

            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();


            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void formkurumsal_Load(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private int hareketMesafesi = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Label'ın X konumunu güncelle
            label10.Left += hareketMesafesi;

            // Label sağa ya da sola çarpıyorsa yönü değiştir
            if (label10.Left + label10.Width >= this.ClientSize.Width || label10.Left <= 0)
            {
                hareketMesafesi = -hareketMesafesi; // Yön değiştir
            }
        }

        private void button6_Click1(object sender ,EventArgs e){

            }

        private void button6_Click(object sender, EventArgs e)
        {
            soruno++;

            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button6.Enabled = false;

            
            label1.Text = soruno.ToString();
            
            if (soruno==1)
            {
                button6.Text = "SONRAKİ";
                richTextBox1.Text= "Uçakta emniyet kemeri takmanız neden önemlidir ? " ;
                button5.Text = "Yolculuk sırasında rahat etmek için";
                button4.Text = "Anonsları daha iyi duymak için";
                button3.Text = "Güvenlik için";
                button2.Text = "Daha kolay uyumak için";
                label1.Text = "Güvenlik için";


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "El bagajında taşınabilecek sıvı miktarı genellikle kaç mililitre ile sınırlıdır? ";
                button5.Text = "50ml";
                button4.Text = "100ml";
                button3.Text = "200ml";
                button2.Text = "500ml";
                label1.Text= "100ml";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Uçuş sırasında hangi koltuklar genellikle daha fazla bacak alanı sunar? ";
                button5.Text = "Koridor Koltukları";
                button4.Text = "Acil Çıkış Koltukları";
                button3.Text = "Arka Sıra Koltukları";
                button2.Text = "Pencere Kenarı Koltukları";
                label1.Text = "Acil Çıkış Koltukları";

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Uçuş sırasında basınç değişikliği hangi rahatsızlığa neden olabilir? ";
                button5.Text = "Kulak Tıkanıklığı";
                button4.Text = "Mide Bulantısı";
                button3.Text ="Baş Dönmesi";
                button2.Text = "Göz Kuruluğu";
                label1.Text = "Kulak Tıkanıklığı";

            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Uzun uçuşlarda bol su içmek neden önemlidir? ";
                button5.Text = "Vücut susuz kalmasın diye";
                button4.Text = " Daha rahat uyumak için";
                button3.Text = "Uçak içi sıcaklığı dengelemek için";
                button2.Text = "Sindirimi kolaylaştırmak için";
                label1.Text = "Vücut susuz kalmasın diye";

                button6.Text = "SONUÇLAR";

            }
            if (soruno==6)
            {
                button5.Enabled = false;
                button4.Enabled = false;
                button4.Enabled = false;
                button2.Enabled = false;
                button6.Enabled = false;


                if (dogru==1 || dogru==2)
                {
                    MessageBox.Show("TEBRİKLER 50 PUAN KAZANDINIZ!");
                }
                if (dogru == 3 || dogru == 4)
                {
                    MessageBox.Show("TEBRİKLER 100 PUAN KAZANDINIZ!");
                }
                if (dogru == 5)
                {
                    MessageBox.Show("TEBRİKLER 200 PUAN KAZANDINIZ!");
                }
                if (dogru == 0)
                {
                    MessageBox.Show("Puan Kazanamadınız...");
                }



            }

        }
    }
}
