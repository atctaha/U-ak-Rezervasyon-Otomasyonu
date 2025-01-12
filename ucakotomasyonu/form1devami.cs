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
    public partial class form1devami : Form
    {
        private int selectionLimit;
        private int selectedCount = 0;

        public form1devami(int totalPrice,int total)
        {
            InitializeComponent();
            LoadAnnouncements();
            LoadCampaigns();
            textBox5.Text = totalPrice.ToString();

            selectionLimit = total;
            
            
        }
        private int sum;
        private int currentSelection = 0;
        public form1devami()
        {
            InitializeComponent();
            
        }
        public void SetTextBoxValue(string value)
        {
            textBox2.Text = value;
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
            tileControl2.Groups.Clear();  // Tüm grupları temizle
            TileGroup tileGroup = new TileGroup();  // Yeni bir grup oluştur
            tileControl2.Groups.Add(tileGroup);      // TileControl2'ye grubu ekle

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
            tileControl1.Groups.Clear();  // Tüm grupları temizle
            TileGroup tileGroup = new TileGroup();  // Yeni bir grup oluştur
            tileControl1.Groups.Add(tileGroup);     // TileControl1'e grubu ekle

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void form1devami_Load(object sender, EventArgs e)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // Eğer mevcut seçim sınırı aşmadıysa
                if (currentSelection < sum)
                {
                    // ListBox'a butonun metnini ekle
                    listBox3.Items.Add(clickedButton.Text);

                    // Butonun rengini kırmızı yap
                    clickedButton.BackColor = Color.Red;

                    // Butonun tekrar seçilmesini engelle
                    clickedButton.Enabled = false;

                    // Seçim sayısını artır
                    currentSelection++;
                }
                else
                {
                    // Kullanıcı sınırı aştıysa uyarı göster
                    MessageBox.Show("Seçim hakkınız doldu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            listBox3.Refresh();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            formrezervpaneli f1 = new formrezervpaneli();
            Form1 ff1 = new Form1();
            formodemepaneli a1 = new formodemepaneli();

            this.Hide();
            a1.Show();
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            
            formodemepaneli a1 = new formodemepaneli();
            this.Hide();
            a1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            Button clickedButton = sender as Button;

            if (clickedButton != null && clickedButton.BackColor != Color.Red)
            {
                if (selectedCount < selectionLimit)
                {
                    clickedButton.BackColor = Color.Red;
                    selectedCount++;

                    // Eğer buton daha önce ListBox'a eklenmediyse ekle
                    if (!listBox3.Items.Contains(clickedButton.Text))
                    {
                        listBox3.Items.Add(clickedButton.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Maksimum seçim hakkınız doldu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
