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
    public partial class formdeneyimgoruntuleme : Form
    {
        public formdeneyimgoruntuleme()
        {
            InitializeComponent();
        }
        private void LoadDataToListBox()
        {
            // ListBox'ı temizle
            listBox1.Items.Clear();

            // Veritabanı bağlantısını al
            using (MySqlConnection connection = Veritabanı.Instance.GetConnection())
            {
                // SQL sorgusu
                string query = "SELECT Isim, Eposta, Deneyim FROM KullaniciBilgileri";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(query,connection))
                    {

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Verileri oku ve ListBox'a ekle
                            while (reader.Read())
                            {
                                string isim = reader.GetString("Isim");
                                string eposta = reader.GetString("Eposta");
                                string deneyim = reader.GetString("Deneyim");
                              

                                // ListBox'a veri ekleme
                                listBox1.Items.Add($"İsim:{isim}            E-Posta: {eposta}           Deneyim: {deneyim}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void formdeneyimgoruntuleme_Load(object sender, EventArgs e)
        {
            LoadDataToListBox();

            element1.Click += (s, ev) => NavigateToForm(new formduyuvekampanya());
            element2.Click += (s, ev) => NavigateToForm(new formseferpaneli());
            element3.Click += (s, ev) => NavigateToForm(new formdeneyimgoruntuleme());
            element4.Click += (s, ev) => NavigateToForm(new formrezervpaneli());
            element23.Click += (s, ev) => NavigateToForm(new formyöneticigirisi());


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
