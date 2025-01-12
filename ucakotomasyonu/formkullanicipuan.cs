using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucakotomasyonu
{
    public partial class formkullanicipuan : Form
    {
        public formkullanicipuan()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yöneticigirbut_Click(object sender, EventArgs e)
        {
            formkullanici y1 = new formkullanici();
            this.Hide();
            y1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            formkullanicikişisel a1 = new formkullanicikişisel();
            this.Hide();
            a1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formkullaniciödeme a2 = new formkullaniciödeme();
            this.Hide();
            a2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formkullanicibilet a3 = new formkullanicibilet();
            this.Hide();
            a3.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            formkullanicipuan a4 = new formkullanicipuan();
            this.Hide();
            a4.Show();
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

        private void formkullanicipuan_Load(object sender, EventArgs e)
        {
            element1.Click += (s, ev) => NavigateToForm(new Form1());
            element2.Click += (s, ev) => NavigateToForm(new formseyahatbilgileri());
            element3.Click += (s, ev) => NavigateToForm(new formseyahatdeneyimi());
            element4.Click += (s, ev) => NavigateToForm(new formkurumsal());
            element5.Click += (s, ev) => NavigateToForm(new formkullanici());
            element6.Click += (s, ev) => NavigateToForm(new formkullanicikişisel());
            element7.Click += (s, ev) => NavigateToForm(new formkullaniciödeme());
            element8.Click += (s, ev) => NavigateToForm(new formkullanicibilet());
            element9.Click += (s, ev) => NavigateToForm(new formkullanicipuan());
            element23.Click += (s, ev) => NavigateToForm(new formyöneticigirisi());


        }
        private void NavigateToForm(Form targetForm)
        {
            this.Hide(); // Mevcut formu gizle
            targetForm.ShowDialog(); // Hedef formu aç
        }
    }
}
