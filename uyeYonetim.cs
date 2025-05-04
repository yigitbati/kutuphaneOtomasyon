using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneOtomasyonuUygulaması
{
    public partial class uyeYonetim : Form
    {
        public uyeYonetim()
        {
            InitializeComponent();
        }

        private void uyeYonetim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonDataSet3.Uyeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyelerTableAdapter.Fill(this.kütüphaneOtomasyonDataSet3.Uyeler);

        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void button7_Click(object sender, EventArgs e)
        {
            formAnaMenu form1 = new formAnaMenu();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeYonetimi uyeYonetimi = new UyeYonetimi();
            uyeYonetimi.Yenile(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtMail.Text,
                Adres = txtAdres.Text,
                KayitTarihi = DateTime.Now, // KayitTarihi olarak şu anki tarihi kullanıyoruz
                DogumTarihi = DateTime.Parse(txtDogumTarih.Text) // DogumTarihi'ni TextBox'tan alıyoruz
            };

            // UyeYonetimi sınıfındaki Kaydet metodunu çağırıyoruz
            UyeYonetimi uyeYonetimi = new UyeYonetimi();
            uyeYonetimi.Kaydet(uye);

            // Kaydetme işleminden sonra DataGridView'ı yenile
            uyeYonetimi.Yenile(dataGridView1);

            MessageBox.Show("Üye başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Uyeler WHERE UyeID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUyeID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Uyeler SET Ad = @p2, Soyad = @p3, Telefon = @p4, Email = @p5, Adres = @p6, KayitTarihi = @p7, DogumTarihi = @p8 WHERE UyeID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUyeID.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", txtAdres.Text);
            komut.Parameters.AddWithValue("@p7", DateTime.Parse(txtKayitTarih.Text));
            komut.Parameters.AddWithValue("@p8", DateTime.Parse(txtDogumTarih.Text));

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UyeYonetimi uyeYonetimi = new UyeYonetimi();

            // Temizle fonksiyonunu çağırıyoruz
            uyeYonetimi.Temizle(txtUyeID, txtAd, txtSoyad, txtTelefon, txtMail, txtAdres, txtKayitTarih, txtDogumTarih);

            // Kullanıcıya formun temizlendiğini bildiren mesaj
            MessageBox.Show("Form temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UyeYonetimi uyeYonetimi = new UyeYonetimi();

            // UyeID'yi alıyoruz (örneğin, txtUyeID TextBox'ından)
            if (int.TryParse(txtUyeID.Text, out int uyeID))
            {
                // Aktar fonksiyonunu çağırıyoruz
                uyeYonetimi.Aktar(uyeID, txtUyeID, txtAd, txtSoyad, txtTelefon, txtMail, txtAdres, txtKayitTarih, txtDogumTarih);
            }
            else
            {
                // Geçersiz UyeID girildiğinde kullanıcıyı uyarıyoruz
                MessageBox.Show("Geçerli bir UyeID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
