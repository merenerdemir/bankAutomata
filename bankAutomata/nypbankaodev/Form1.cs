using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypbankaodev
{
    public partial class Form1 : Form
    {

        public Musteri müş1 = new Musteri();
        List<Musteri> musteriler = new List<Musteri>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public Random rnd = new Random();

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            List<Musteri> musteriler = new List<Musteri>();

            müş1.AdSoyad = txt_adSoyad.Text;
            müş1.TCKimlikNo = txt_tcNo.Text;
            müş1.MüşteriNo = 1;


            if (radioButton1.Checked == true)
            {
                müş1.HesapOluştur(true);
                müş1.MüşteriNo = rnd.Next(10000, 20000);
                MessageBox.Show("Müşteri Numaranız: " + Convert.ToString(müş1.MüşteriNo));
                txt_adSoyad.Clear();
                txt_tcNo.Clear();
                radioButton1.Checked = false;
            }
            else if (radioButton2.Checked == true)
            {
                müş1.HesapOluştur(false);
                müş1.MüşteriNo = rnd.Next(10000, 20000);
                MessageBox.Show("Müşteri Numaranız: " + Convert.ToString(müş1.MüşteriNo));
                txt_adSoyad.Clear();
                txt_tcNo.Clear();
                radioButton2.Checked = false;
            }
            else
            {
                MessageBox.Show("Lütfen bir hesap türü seçiniz!");
            }
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {

            if (müş1.MüşteriNo == Convert.ToInt32(txt_müşNo.Text))
            {
                formAnasayfa formAnasayfa = new formAnasayfa(müş1);
                formAnasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Müşteri numaranız doğru değil.");  
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
