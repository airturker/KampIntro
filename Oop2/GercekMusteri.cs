using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //individual (gerçek müşteri)
    class GercekMusteri: Musteri //miras - inheritance (tüzelmüşteri bir müşteridir)(müşteri de olan özellikler burda da geçerli)
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
