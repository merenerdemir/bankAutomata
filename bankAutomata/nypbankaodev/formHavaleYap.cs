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
    public partial class formHavaleYap : Form
    {
        public Musteri musteri_;
        public List<Hesap> hesaps;
        List<MüsteriBireyselHesap> bireyselHesaps = new List<MüsteriBireyselHesap>();
        List<MüsteriTicariHesap> ticariHesaps = new List<MüsteriTicariHesap>();

        public formHavaleYap(Musteri musteri, List<MüsteriBireyselHesap> bireyselHesaps, List<MüsteriTicariHesap> ticariHesaps)
        {
            InitializeComponent();
            this.musteri_ = musteri;
            this.bireyselHesaps = bireyselHesaps;
            this.ticariHesaps = ticariHesaps;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bireyselHesaps.Count; i++)
            {
                if (bireyselHesaps[i].HesapNo == Convert.ToInt32(textBox3.Text))
                {
                    bireyselHesaps[i].HavaleYap((Convert.ToDecimal(textBox5.Text)) / 2);
                    bireyselHesaps[i].IslemTarihi = Convert.ToDateTime(textBox4.Text);
                    

                }
                if (bireyselHesaps[i].HesapNo == Convert.ToInt32(textBox2.Text))
                {
                    bireyselHesaps[i].HesapBakiyesi += Convert.ToDecimal(textBox5.Text);
                    bireyselHesaps[i].IslemTarihi = Convert.ToDateTime(textBox4.Text);
                    

                }
            }
            for (int i = 0; i < ticariHesaps.Count; i++)
            {
                if (ticariHesaps[i].HesapNo == Convert.ToInt32(textBox3.Text))
                {
                    ticariHesaps[i].HavaleYap(Convert.ToDecimal(textBox5.Text));
                    ticariHesaps[i].IslemTarihi = (Convert.ToDateTime(textBox4.Text));
                  //  textBox3.Clear();

                }
                if (ticariHesaps[i].HesapNo == Convert.ToInt32(textBox2.Text))
                {
                    ticariHesaps[i].HesapBakiyesi += Convert.ToDecimal(textBox5.Text);
                    ticariHesaps[i].IslemTarihi = (Convert.ToDateTime(textBox4.Text));
                   // textBox2.Clear();
                }
            }
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formHavaleYap_Load(object sender, EventArgs e)
        {

        }
    }
}
