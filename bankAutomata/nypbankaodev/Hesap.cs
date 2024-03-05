using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypbankaodev
{
    public class Hesap
    {
        public Hesap()
        {
         
        }

        public string HesapBilgi { get; set; }

        public Hesap hesap { get; set; }

        public virtual void HavaleYap(decimal GonderilecekTutar )
        {           
            HesapBakiyesi = HesapBakiyesi - GonderilecekTutar;
        }

        public int HesapNo { get; set; }

        public string HesapAdi { get; set; }

        public decimal HesapBakiyesi { get; set; } = 0;

        public decimal HavaleÜcreti { get; set; } = 0;

        public decimal havaleOrani { get; set; } = 0.02M;

        public DateTime IslemTarihi { get; set; }
    }
}