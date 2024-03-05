using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypbankaodev
{
    public class Musteri
    {
        public Hesap hesap { get; set; }

        public Musteri()
        {
            BireyselHesaplar = new List<MüsteriBireyselHesap>();
            TicariHesaplar = new List<MüsteriTicariHesap>();
        }       

        public List<Hesap> hesaplar { get; set; } = new List<Hesap>();


        public void HesapOluştur(bool bireyselMi)
        {
            Random rnd = new Random();

            if (bireyselMi)
            {

                MüsteriBireyselHesap hesap = new MüsteriBireyselHesap();
                BireyselHesaplar.Add(hesap);
                hesaplar.Add(hesap);
                hesap.HesapNo = rnd.Next(100, 999);
                hesap.HesapAdi = "Bireysel Hesap" + (BireyselHesaplar.Count );
            }
            else
            {

                MüsteriTicariHesap hesap = new MüsteriTicariHesap();
                TicariHesaplar.Add(hesap);
                hesaplar.Add(hesap);
                hesap.HesapNo = rnd.Next(100, 999);
                hesap.HesapAdi = "Ticari Hesap" + (TicariHesaplar.Count );
            }

        }

        public void hesapKapama(int silinecekNo)
        {          
            
            int silinecekHesapNo = silinecekNo;
            

            for (int i = 0; i < hesaplar.Count; i++)
            {
                if (hesaplar[i].HesapNo == silinecekHesapNo )
                {
                    if (hesaplar[i].HesapBakiyesi == 0)
                    { 
                    hesaplar.Remove(hesaplar[i]);
                    }                 
                }
            }
        }

        public List<MüsteriBireyselHesap> BireyselHesaplar { get; set; }

        public List<MüsteriTicariHesap> TicariHesaplar { get; set; }

        public string TCKimlikNo { get; set; }

        public string AdSoyad { get; set; }

        public int MüşteriNo { get; set; }
    }
}
