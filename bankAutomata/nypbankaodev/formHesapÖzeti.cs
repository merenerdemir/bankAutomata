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
    public partial class formHesapÖzeti : Form
    {
        public Musteri musteri_;
        public List<Hesap> hesaps;
        public formHesapÖzeti(Musteri musteri,List<Hesap> hesaplar)
        {
            InitializeComponent();
            musteri_ = musteri;
            hesaps = hesaplar;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formHesapÖzeti_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < hesaps.Count; i++)
            { 
                listBox1.Items.Add("  Hesap No: " + hesaps[i].HesapNo + " ---> " + $"{hesaps[i].IslemTarihi:dd/MM/yyyy} ---> {hesaps[i].HesapBakiyesi:C}");
            }

            
        }
    }
}
