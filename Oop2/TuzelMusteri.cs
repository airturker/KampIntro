using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //coorporate (tüzel müşteri)
    class TuzelMusteri:Musteri //miras - inheritance (tüzelmüşteri bir müşteridir)(müşteri de olan özellikler burda da geçerli)
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
