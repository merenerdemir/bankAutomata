using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypbankaodev
{
    public class MüsteriBireyselHesap:Hesap
    {
        public override void HavaleYap(decimal Tutar)
        {
            base.HavaleYap(Tutar);

            HavaleÜcreti = Tutar * havaleOrani;
            HesapBakiyesi = HesapBakiyesi - (Tutar + HavaleÜcreti);

        }
    }
}
