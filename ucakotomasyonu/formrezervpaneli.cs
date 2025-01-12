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
    public partial class formrezervpaneli : Form
    {
        public formrezervpaneli()
        {
            InitializeComponent();
        }
        private void formrezervpaneli_Load(object sender, EventArgs e)
        {
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


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void accordionControl2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            formyöneticigirisi a1 = new formyöneticigirisi();
            this.Hide();
            a1.Show();
        }
    }
}
