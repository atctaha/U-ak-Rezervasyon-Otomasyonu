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
using DevExpress.XtraEditors;  // TileControl ve TileItem için gerekli





namespace ucakotomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAnnouncements();
            LoadCampaigns();
            LoadComboBoxData();
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
        private void LoadComboBoxData()
        {// Veritabanı bağlantısını al
            MySqlConnection connection = Veritabanı.Instance.GetConnection();

            // Nereden ve Nereye verilerini çekecek sorgular
            string queryNereden = "SELECT DISTINCT nereden FROM Seferler";
            string queryNereye = "SELECT DISTINCT nereye FROM Seferler";

            // Nereden ComboBoxEdit'i doldur
            MySqlCommand cmdNereden = new MySqlCommand(queryNereden, connection);
            MySqlDataReader readerNereden = cmdNereden.ExecuteReader();
            while (readerNereden.Read())
            {
                comboBoxNereden.Properties.Items.Add(readerNereden["nereden"].ToString());
            }
            readerNereden.Close();

            // Nereye ComboBoxEdit'i doldur
            MySqlCommand cmdNereye = new MySqlCommand(queryNereye, connection);
            MySqlDataReader readerNereye = cmdNereye.ExecuteReader();
            while (readerNereye.Read())
            {
                comboBoxNereye.Properties.Items.Add(readerNereye["nereye"].ToString());
            }
            readerNereye.Close();

            // Veritabanı bağlantısını kapat
            Veritabanı.Instance.CloseConnection();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
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
        }

        private void yöneticigirbut_Click(object sender, EventArgs e)
        {
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            form1devami f1 = new form1devami();
            this.Hide();
            f1.Show();

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            dateEditdönüs.Enabled = !checkBoxtekyon.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Seçilen değerleri al
            string nereden = comboBoxNereden.SelectedItem?.ToString();
            string nereye = comboBoxNereye.SelectedItem?.ToString();
            DateTime? gidisTarihi = dateEditgidis.EditValue as DateTime?;
            DateTime? donusTarihi = dateEditdönüs.EditValue as DateTime?;
            bool isTekYon = checkBoxtekyon.Checked; // Tek Yön seçimi CheckBox üzerinden kontrol ediliyor

            // Alanları kontrol et
            if (string.IsNullOrEmpty(nereden) || string.IsNullOrEmpty(nereye) || !gidisTarihi.HasValue ||
                (!isTekYon && !donusTarihi.HasValue)) // Gidiş-Dönüş ise dönüş tarihi kontrol edilir
            {
                MessageBox.Show("Lütfen tüm gerekli alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Eğer Tek Yön ise dönüş tarihi sıfırlanır
            if (isTekYon)
            {
                donusTarihi = null;
            }

            // Veritabanı bağlantısını al
            MySqlConnection connection = Veritabanı.Instance.GetConnection();

            // SQL Sorgusunu oluştur
            string query = "SELECT sefer_no, nereden, nereye, gidis_tarihi, donus_tarihi, ekonomi_fiyat FROM Seferler " +
                           "WHERE nereden = @nereden AND nereye = @nereye AND gidis_tarihi = @gidisTarihi";

            if (!isTekYon) // Gidiş-Dönüş ise dönüş tarihi sorguya dahil edilir
            {
                query += " AND donus_tarihi = @donusTarihi";
            }

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@nereden", nereden);
            command.Parameters.AddWithValue("@nereye", nereye);
            command.Parameters.AddWithValue("@gidisTarihi", gidisTarihi.Value.ToString("yyyy-MM-dd"));

            if (!isTekYon)
            {
                command.Parameters.AddWithValue("@donusTarihi", donusTarihi.Value.ToString("yyyy-MM-dd"));
            }

            // Seferleri CheckedListBox'a ekle
            MySqlDataReader reader = command.ExecuteReader();
            checkedListBoxSeferler.Items.Clear(); // Önceki sonuçları temizle

            while (reader.Read())
            {
                string seferBilgisi = $"Sefer No: {reader["sefer_no"]}, Gidiş: {reader["gidis_tarihi"]}, Fiyat: {reader["ekonomi_fiyat"]}₺";
                if (!isTekYon)
                {
                    seferBilgisi += $", Dönüş: {reader["donus_tarihi"]}";
                }
                checkedListBoxSeferler.Items.Add(seferBilgisi);
            }

            if (checkedListBoxSeferler.Items.Count == 0)
            {
                MessageBox.Show("Seçimlerinize uygun bir sefer bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Veritabanı bağlantısını kapat
            reader.Close();
            Veritabanı.Instance.CloseConnection();
        }
        private void comboBoxTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eğer Tek Yön seçildiyse dönüş tarihi pasif hale gelir
            if (checkBoxtekyon.Checked)
            {
                dateEditdönüs.Enabled = false;
                dateEditdönüs.EditValue = null; // Dönüş tarihini temizle
            }
            else
            {
                dateEditdönüs.Enabled = true;
            }
        }

        private void tileControl2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            // ComboBox'lardan seçilen değerleri al
            int value1 = Convert.ToInt32(comboBox4.SelectedItem);
            int value2 = Convert.ToInt32(comboBox5.SelectedItem);
            int value3 = Convert.ToInt32(comboBox6.SelectedItem);

            // Değerleri topla
            int total = value1 + value2 + value3;

            // Çarpan belirle
            int multiplier = 0;
            if (radioButton1.Checked)
            {
                multiplier = 50;
            }
            else if (radioButton2.Checked)
            {
                multiplier = 100;
            }
            else if (radioButton3.Checked)
            {
                multiplier = 200;
            }
            else
            {
                // Hiçbir RadioButton seçili değilse uyarı ver
                MessageBox.Show("Lütfen bir çarpan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Toplam fiyatı hesapla
            int totalPrice = total * multiplier;

            // Yeni formu aç ve fiyatı göster
            form1devami resultForm = new form1devami(totalPrice,total);
            
            
            resultForm.Show();
            this.Hide();


        }

    }
}
