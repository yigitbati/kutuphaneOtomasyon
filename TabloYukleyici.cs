using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace kütüphaneOtomasyonuUygulaması
{
    public class TabloYukleyici
    {
        sqlBaglantisi bgl = new sqlBaglantisi();
        private string connectionString;

        //Veritabanı bağlantı bilgilerini alır
        public TabloYukleyici(string connString)
        {
            this.connectionString = connString;
        }

        //Tablo yüklemek için kullanılan kodlar
        public virtual void TabloyuYukle(DataGridView gridView, string tabloAdi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM {tabloAdi}", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Tablo Yükleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    //Kitaplar tablosunu yüklemek için Polimorfizm Örneği
    public class KitapTabloYukleyici : TabloYukleyici
    {
        public KitapTabloYukleyici(string connString) : base(connString) { }

        public override void TabloyuYukle(DataGridView gridView, string tabloAdi = "kitapTbl")
        {
            base.TabloyuYukle(gridView, tabloAdi);
        }
    }

    //Üyeler tablosunu yüklemek için Polimorfizm Örneği
    public class UyelerTabloYukleyici : TabloYukleyici
    {
        public UyelerTabloYukleyici(string connString) : base(connString) { }

        public override void TabloyuYukle(DataGridView gridView, string tabloAdi = "Uyeler")
        {
            base.TabloyuYukle(gridView, tabloAdi);
        }
    }

    //Ödünç tablosunu yükleme için Polimorfizm Örneği
    public class OduncTabloYukleyici : TabloYukleyici
    {
        public OduncTabloYukleyici(string connString) : base(connString) { }

        public override void TabloyuYukle(DataGridView gridView, string tabloAdi = "oduncTbl")
        {
            base.TabloyuYukle(gridView, tabloAdi);
        }
    }
}
