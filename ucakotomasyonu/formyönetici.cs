using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation; // AccordionControl ile ilgili sınıflar için gerekli

namespace ucakotomasyonu
{
    public partial class formyönetici : Form
    {
        public formyönetici()
        {
            InitializeComponent();
        }

        private void formyönetici_Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formyöneticigirisi a1 = new formyöneticigirisi();
            this.Hide();
            a1.Show();

        }



        private void label2_Click(object sender, EventArgs e)
        {
           
        }
        

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {
            
        }



    }
}
