using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneOtomasyonuUygulaması
{
    public class UyeYonetimi
    {
        public void Yenile(DataGridView dataGridView)
        {
            sqlBaglantisi bgl = new sqlBaglantisi();
            try
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM Uyeler", bgl.baglanti());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Kaydet(Uye uye)
        {
            uye.Kaydet();
        }

        public void Sil(int uyeID)
        {
            Uye uye = Uye.Getir(uyeID); // UyeID'yi kullanarak üye bilgilerini getir
            uye.Sil();
        }

        public void Guncelle(Uye uye)
        {
            uye.Guncelle();
        }

        public void Aktar(int uyeID, TextBox txtUyeID, TextBox txtAd, TextBox txtSoyad, TextBox txtTelefon,
            TextBox txtMail, TextBox txtAdres, TextBox txtKayitTarih, TextBox txtDogumTarih)
        {
            Uye uye = Uye.Getir(uyeID);
            if (uye != null)
            {
                txtUyeID.Text = uye.UyeID.ToString();
                txtAd.Text = uye.Ad;
                txtSoyad.Text = uye.Soyad;
                txtTelefon.Text = uye.Telefon;
                txtMail.Text = uye.Email;
                txtAdres.Text = uye.Adres;
                txtKayitTarih.Text = uye.KayitTarihi.ToString();
                txtDogumTarih.Text = uye.DogumTarihi.ToString();
            }
        }
        public void Temizle(TextBox txtUyeID, TextBox txtAd, TextBox txtSoyad, TextBox txtTelefon,
       TextBox txtMail, TextBox txtAdres, TextBox txtKayitTarih, TextBox txtDogumTarih)
        {
            // TextBox'ların içeriğini temizler
            txtUyeID.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtMail.Clear();
            txtAdres.Clear();
            txtKayitTarih.Clear();
            txtDogumTarih.Clear();
        }


    }
}
