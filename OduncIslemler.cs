using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneOtomasyonuUygulaması
{
    public class OduncIslemler
    {
        public void Yenile(DataGridView dataGridView)
        {
            // Tabloyu yenilemek için gerekli işlemi yapar
        }

        public void Kaydet(Odunc odunc)
        {
            odunc.Kaydet();
        }

        public void Iade(Odunc odunc)
        {
            odunc.Iade();
        }

        public void Aktar(int oduncID, TextBox txtOduncID, TextBox txtUyeID, TextBox txtKitapID, TextBox txtOduncTarih, TextBox txtTeslimTarih)
        {
            Odunc odunc = Odunc.Getir(oduncID);
            txtOduncID.Text = odunc.OduncID.ToString();
            txtUyeID.Text = odunc.UyeID.ToString();
            txtKitapID.Text = odunc.KitapID.ToString();
            txtOduncTarih.Text = odunc.OduncTarihi.ToString();
            txtTeslimTarih.Text = odunc.SonTeslimTarihi.ToString();
        }
    }
}
