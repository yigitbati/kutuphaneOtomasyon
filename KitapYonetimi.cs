using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneOtomasyonuUygulaması
{
    public class KitapYonetimi //kitap yönetimi classı açılıyor
    {
        public void Yenile(DataGridView dataGridView)// DataGridView'e veri yüklemek için metodu tanımlarız.
        {
            sqlBaglantisi bgl = new sqlBaglantisi();
            try
            {   // SqlCommand nesnesi oluşturulup, 'kitapTbl' tablosundaki tüm veriler seçilir.
                SqlCommand komut = new SqlCommand("SELECT * FROM kitapTbl", bgl.baglanti());
                SqlDataAdapter da = new SqlDataAdapter(komut); // SqlDataAdapter, SqlCommand ile çalışarak veri tabanından verileri alır ve DataTable'a doldurur.
                DataTable dt = new DataTable();// Yeni bir DataTable nesnesi oluşturulur.
                da.Fill(dt);// Veri tabanından alınan veriler DataTable'a doldurulur.
                dataGridView.DataSource = dt;// DataTable, DataGridView'in DataSource özelliğine atanır, böylece veriler gridde görüntülenir.
                bgl.baglanti().Close(); // Veri tabanı bağlantısı kapatılır.
            }
            catch (Exception ex)// Eğer bir hata oluşursa, hata mesajı gösterilir.
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Kaydet(Kitap kitap)
        {
            kitap.Kaydet(); // Kitap nesnesinin Kaydet metodunu çağırır
        }

        public void Sil(int kitapID)
        {
            Kitap kitap = Kitap.Getir(kitapID); // KitapID'ye göre Kitap nesnesini getir
            kitap.Sil(); // Kitap nesnesinin Sil metodunu çağırarak kitabı sil
        }

        public void Guncelle(Kitap kitap)
        {
            kitap.Guncelle();
        }

        public void Aktar(int kitapID, TextBox txtKitapID, TextBox txtKitapAdi, TextBox txtYazar,
            TextBox txtYayinevi, TextBox txtYayinYili, ComboBox cmbKategori, TextBox txtSayfaSayisi,
            TextBox txtDil)
        {
            Kitap kitap = Kitap.Getir(kitapID); // KitapID'ye göre kitabı veritabanından getir
            txtKitapID.Text = kitap.KitapID.ToString(); // KitapID'yi TextBox'a aktar
            txtKitapAdi.Text = kitap.KitapAdi;
            txtYazar.Text = kitap.Yazar;
            txtYayinevi.Text = kitap.Yayinevi;
            txtYayinYili.Text = kitap.YayinYili.ToString();
            cmbKategori.SelectedItem = kitap.Kategori;
            txtSayfaSayisi.Text = kitap.SayfaSayisi.ToString();
            txtDil.Text = kitap.Dil;
        }
    }
}
