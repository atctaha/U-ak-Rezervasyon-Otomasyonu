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
    public partial class formseferpaneli : Form
    {
        public formseferpaneli()
        {
            InitializeComponent();
        }

        private void NavigateToForm(Form targetForm)
        {
            this.Hide(); // Mevcut formu gizle
            targetForm.ShowDialog(); // Hedef formu aç
        }




        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void formseferpaneli_Load(object sender, EventArgs e)
        {
            element1.Click += (s, ev) => NavigateToForm(new formduyuvekampanya());
            element2.Click += (s, ev) => NavigateToForm(new formseferpaneli());
            element3.Click += (s, ev) => NavigateToForm(new formdeneyimgoruntuleme());
            element4.Click += (s, ev) => NavigateToForm(new formrezervpaneli());
            element23.Click += (s, ev) => NavigateToForm(new formyöneticigirisi());


            SeferleriListele();
            ComboBoxuGuncelle();
        }

        private void accordionControl2_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            formyöneticigirisi a1 = new formyöneticigirisi();
            this.Hide();
            a1.Show();
        }
        public void SeferEkle()
        {
            try
            {
                MySqlConnection conn = Veritabanı.Instance.GetConnection();

                string query = "INSERT INTO seferler (nereden, nereye, tur, gidis_tarihi, donus_tarihi, ekonomi_fiyat, orta_fiyat, business_fiyat) " +
                               "VALUES (@nereden, @nereye, @tur, @gidis_tarihi, @donus_tarihi, @ekonomi_fiyat, @orta_fiyat, @business_fiyat)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nereden", textBox1.Text);
                cmd.Parameters.AddWithValue("@nereye", textBox2.Text);
                cmd.Parameters.AddWithValue("@tur", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@gidis_tarihi", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                if (comboBox1.SelectedItem.ToString() == "Tek Yön")
                {
                    cmd.Parameters.AddWithValue("@donus_tarihi", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@donus_tarihi", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                }

                // Sabit fiyatlar
                cmd.Parameters.AddWithValue("@ekonomi_fiyat", 50);
                cmd.Parameters.AddWithValue("@orta_fiyat", 100);
                cmd.Parameters.AddWithValue("@business_fiyat", 200);

                cmd.ExecuteNonQuery();

                // Yeni eklenen ID'yi al
                string lastIdQuery = "SELECT LAST_INSERT_ID()";
                MySqlCommand lastIdCmd = new MySqlCommand(lastIdQuery, conn);
                int lastInsertedId = Convert.ToInt32(lastIdCmd.ExecuteScalar());

                textBox7.Text = lastInsertedId.ToString();

                MessageBox.Show("Sefer başarıyla eklendi!");

                SeferleriListele();
                ComboBoxuGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                Veritabanı.Instance.CloseConnection();
            }
        }
        public void SeferleriListele()
        {
            try
            {
                

                MySqlConnection conn = Veritabanı.Instance.GetConnection();
                string query = "SELECT sefer_no, nereden, nereye, tur, gidis_tarihi, donus_tarihi, ekonomi_fiyat, orta_fiyat, business_fiyat FROM seferler";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                listBox1.Items.Clear();

                while (reader.Read())
                {
                    string seferBilgi = $"Sefer No: {reader["sefer_no"]} | Nereden: {reader["nereden"]} | Nereye: {reader["nereye"]} | Tür: {reader["tur"]} | " +
                                        $"Ekonomi: {reader["ekonomi_fiyat"]} TL | Orta: {reader["orta_fiyat"]} TL | Business: {reader["business_fiyat"]} TL";

                    listBox1.Items.Add(seferBilgi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                Veritabanı.Instance.CloseConnection();
            }
        }

        public void ComboBoxuGuncelle()
        {
            try
            {
                comboBox2.Items.Clear();

                MySqlConnection conn = Veritabanı.Instance.GetConnection();
                string query = "SELECT sefer_no FROM seferler";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["sefer_no"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                Veritabanı.Instance.CloseConnection();
            }
        }

        public void SeferSil()
        {
            try
            {
                if (comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz seferi seçin.");
                    return;
                }

                MySqlConnection conn = Veritabanı.Instance.GetConnection();
                string query = "DELETE FROM seferler WHERE sefer_no = @sefer_no";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@sefer_no", comboBox2.SelectedItem.ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sefer başarıyla silindi!");

                // Listeyi güncelle
                SeferleriListele();
                ComboBoxuGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                Veritabanı.Instance.CloseConnection();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tür 'Tek Yön' ise dönüş tarihi pasif olsun
            if (comboBox1.SelectedItem.ToString() == "Tek Yön")
            {
                dateTimePicker2.Enabled = false;
                dateTimePicker2.Value = dateTimePicker1.Value; // Gidiş tarihini eşitle
            }
            else
            {
                dateTimePicker2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeferEkle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeferSil();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
