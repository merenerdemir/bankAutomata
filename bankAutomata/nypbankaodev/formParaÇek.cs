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
    public partial class formParaÇek : Form
    {
        public Musteri musteri_;
        public List<Hesap> hesaps;
        public formParaÇek(Musteri musteri_, List<Hesap> hesaplar)
        {
            InitializeComponent();
            this.musteri_ = musteri_;
            this.hesaps = hesaplar;
        }

        private void formParaÇek_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal çekilen = 0;
            çekilen = Convert.ToDecimal(textBox2.Text);

            if (çekilen <= 750)
            {
                int çekilenHesapNo = Convert.ToInt32(textBox3.Text);

                for (int i = 0; i < hesaps.Count; i++)
                {
                    textBox1.Text = Convert.ToString(hesaps[i].HesapBakiyesi);

                    if (çekilenHesapNo == hesaps[i].HesapNo)
                    {
                        hesaps[i].HesapBakiyesi -= çekilen;
                        textBox1.Text = Convert.ToString(hesaps[i].HesapBakiyesi);
                        textBox2.Clear();
                        break;
                    }
                }
                çekilen += çekilen;
            }
            else
            {
                MessageBox.Show("Günlük çekebileceğiniz tutar maksimum 750 TL'dir. Çekebileceğiniz tuatar: " + Convert.ToString(750 -çekilen));
            }

        }
    }
}
