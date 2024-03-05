using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypbankaodev
{
    public class MüsteriTicariHesap:Hesap
    {
        Hesap hesap1 = new Hesap();
        public override void HavaleYap(decimal Tutar)
        {
            base.HavaleYap(Tutar);
           
        }
    }
}
