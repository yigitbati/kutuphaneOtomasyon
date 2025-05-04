using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphaneOtomasyonuUygulaması
{
    public class Odunc
    {
        public int OduncID { get; set; }
        public int UyeID { get; set; }
        public int KitapID { get; set; }
        public DateTime OduncTarihi { get; set; }
        public DateTime SonTeslimTarihi { get; set; }

        public void Kaydet()
        {
            // Veritabanına kaydetme işlemi
        }

        public void Iade()
        {
            // İade işlemi
        }

        public static Odunc Getir(int oduncID)
        {
            // Veritabanından ödünç bilgilerini getirir
            return new Odunc();
        }

    }
}
