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
    public partial class formAnasayfa : Form
    {

        private Musteri musteri_;
        public formAnasayfa(Musteri musteri)
        {
            InitializeComponent();
            musteri_ = musteri;
        }

        private void formAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < musteri_.hesaplar.Count; i++)
            {

                listBox1.Items.Add("Hesap Adi: " + musteri_.hesaplar[i].HesapAdi);
                listBox1.Items.Add("Ad Soyad : " + musteri_.AdSoyad);
                listBox1.Items.Add("Müşteri Numaranız: " + musteri_.MüşteriNo);
                listBox1.Items.Add("Hesap Numaranız: " + musteri_.hesaplar[i].HesapNo);
                listBox1.Items.Add("Hesap Bakiyesi: " + musteri_.hesaplar[i].HesapBakiyesi);
                DateTime simdikiZaman = DateTime.Now;
                listBox1.Items.Add($"{simdikiZaman.ToLongTimeString()}   {simdikiZaman.ToLongDateString()}");
                listBox1.Items.Add("----------------------------------------------------------------------------------------------------------");
            }
        }

        private void paraYatırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formParaYatır formParaYatır = new formParaYatır(musteri_, musteri_.hesaplar);
            formParaYatır.Show();

        }

        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formParaÇek formParaÇek = new formParaÇek(musteri_, musteri_.hesaplar);
            formParaÇek.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                musteri_.HesapOluştur(true);
                radioButton1.Checked = false;
                MessageBox.Show("Hesabınız başarıyla oluşturuldu");
            }
            else if (radioButton2.Checked == true)
            {
                musteri_.HesapOluştur(false);
                radioButton2.Checked = false;
                MessageBox.Show("Hesabınız başarıyla oluşturuldu");
            }
            else
            {
                MessageBox.Show("Lütfen bir hesap türü seçiniz!");
            }
        }

        private void hesapKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            formHesapKapat formHesapKapat = new formHesapKapat(musteri_);
            formHesapKapat.Show();
        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMüşteriSil formMüşteriSil = new formMüşteriSil();
            formMüşteriSil.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void havaleYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formHavaleYap formHavaleYap = new formHavaleYap(musteri_, musteri_.BireyselHesaplar, musteri_.TicariHesaplar);
            formHavaleYap.Show();
        }

        private void hesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formHesapÖzeti formHesapÖzeti = new formHesapÖzeti(musteri_, musteri_.hesaplar);
            formHesapÖzeti.Show();
        }

        private void bankaRaporuGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBankaRaporGoster formBankaRaporGoster = new formBankaRaporGoster(musteri_.hesaplar);
            formBankaRaporGoster.Show();
        }
    }
}
