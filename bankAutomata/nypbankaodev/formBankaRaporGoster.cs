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
    public partial class formBankaRaporGoster : Form
    {
        List<Hesap> hesaps= new List<Hesap>();
        public formBankaRaporGoster(List<Hesap> hesaplar)
        {
            InitializeComponent();
            hesaps= hesaplar;
        }

        private void formBankaRaporGoster_Load(object sender, EventArgs e)
        {
            decimal toplamPara = 0;
            decimal toplamHavale = 0;
            for(int i = 0; i<hesaps.Count; i++)
            {
                toplamPara += hesaps[i].HesapBakiyesi;
                toplamHavale += hesaps[i].HavaleÜcreti;
            }
            dataGridView1.Rows.Add(toplamPara, toplamHavale);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
