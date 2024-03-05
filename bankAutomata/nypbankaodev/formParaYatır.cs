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
    public partial class formParaYatır : Form
    {
        public Musteri musteri_;

        public List<Hesap> hesaps;

        public formParaYatır(Musteri musteri_,List<Hesap> hesaplar)
        {
            InitializeComponent();
            this.musteri_ = musteri_;
            hesaps= hesaplar;
        }

        

        private void formParaYatır_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            int hesapnosu = Convert.ToInt32(textBox3.Text);

            for (int i=0; i < hesaps.Count; i++)
            {
                if (hesapnosu == hesaps[i].HesapNo)
                {
                    textBox1.Text = Convert.ToString(hesaps[i].HesapBakiyesi);
                    hesaps[i].HesapBakiyesi = Convert.ToDecimal(textBox2.Text);
                    textBox1.Clear();
                    textBox1.Text += Convert.ToString(hesaps[i].HesapBakiyesi);
                    hesaps[i].IslemTarihi = DateTime.Now;

                    textBox2.Clear();
                    textBox3.Clear();
                    break;
                }             
            }
        }
    }
}
