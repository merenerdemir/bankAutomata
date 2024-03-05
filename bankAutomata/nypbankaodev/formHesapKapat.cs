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
    public partial class formHesapKapat : Form
    {
        public Musteri musteri_;

        public formHesapKapat(Musteri musteri_)
        {
            InitializeComponent();
            this.musteri_ = musteri_;

        }

        private void button1_Click(object sender, EventArgs e)
        {           
            musteri_.hesapKapama(Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Hesabınız başarıyla kapatılmıştır.");
            
        }

        private void formHesapKapat_Load(object sender, EventArgs e)
        {

        }
    }
}
