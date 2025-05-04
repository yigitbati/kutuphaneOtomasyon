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
    public partial class calisanYonetimi : Form
    {
        
        public calisanYonetimi()
        {
            InitializeComponent();
            
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void button7_Click(object sender, EventArgs e)
        {
            
            formAnaMenu form1 = new formAnaMenu();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            //yeni form açıp, açık olan formu kapatma 
        }

        private void calisanYonetimi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonDataSet12.CalisanGonullu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanGonulluTableAdapter1.Fill(this.kütüphaneOtomasyonDataSet12.CalisanGonullu);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.calisanGonulluTableAdapter1.Fill(this.kütüphaneOtomasyonDataSet12.CalisanGonullu);
            //yenileme butonu için tabloyu tekrar açar

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into CalisanGonullu (Ad, Soyad, Email, Telefon, CalisanTuru, CalismaGunleri) values (@p2, @p3, @p4, @p5, @p6, @p7)", bgl.baglanti());
            // SQL sorgusunu oluiturur. Bu sorgu, CalisanGonullu tablosuna bir satır eklemek için kullanılır.
            // "bgl.baglanti()" metodu, SQL bağlantısını açar ve bağlantıyı komuta ekler. 
            komut.Parameters.AddWithValue("@p2", txtAd.Text); // "@p2" parametresine, txtAd isimli TextBox'taki (kullanıcı giriş kutusu) değeri atar.
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtCalisanTuru.Text);
            komut.Parameters.AddWithValue("@p7", txtCalismaGunleri.Text);
            komut.ExecuteNonQuery();// SQL sorgusunu çalıştırır. Bu durumda, tabloya yeni bir kayıt ekler.
            bgl.baglanti().Close(); // Açık olan SQL bağlantısını kapatır. Bağlantıyı kapatmak, kaynakları korumak ve güvenliği artırmak için önemlidir.
            MessageBox.Show("Kayıt Gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Kullanıcıya bir mesaj kutusu açar ve "Kayıt Gerçekleşmiştir" mesajını gösterir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM CalisanGonullu WHERE ID = @p1", bgl.baglanti());// SQL sorgusunu oluşturur. Bu sorgu, CalisanGonullu tablosundan ID'si belirtilen kaydı siler.
                                                                                                           // "bgl.baglanti()" metodu, SQL bağlantısını açar ve bu bağlantıyı komuta ekler.
            komut.Parameters.AddWithValue("@p1", txtID.Text);// "@p1" parametresine, txtID isimli TextBox'taki değeri atar.
                                                             // Kullanıcıdan silmek istediği kaydın ID'sini alır ve sorguya ekler.

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE CalisanGonullu SET Ad = @p2, Soyad = @p3, Email = @p4, Telefon = @p5, CalisanTuru = @p6, CalismaGunleri = @p7 WHERE ID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtCalisanTuru.Text);
            komut.Parameters.AddWithValue("@p7", txtCalismaGunleri.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //temizle butonu için her textboxtaki girdileri siler
            txtID.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtMail.Clear();
            txtTelefon.Clear();
            txtCalisanTuru.Clear();
            txtCalismaGunleri.Clear();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtID.Text)) // Eğer txtID TextBox'ına hiçbir değer girilmediyse veya boşluklardan oluşuyorsa...
            {
                MessageBox.Show("Lütfen Personel ID giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);// Kullanıcıya bir uyarı mesajı gösterilir.
                return;// Metod burada sonlandırılır. Devam etmez.
            }

            SqlCommand komut = new SqlCommand("SELECT * FROM CalisanGonullu WHERE ID = @p1", bgl.baglanti());// SQL sorgusunu hazırlar. Bu sorgu, CalisanGonullu tablosundan belirtilen ID'ye sahip kaydı getirir.
                                                                                                             // "bgl.baglanti()" metodu ile bir SQL bağlantısı açılır.
            komut.Parameters.AddWithValue("@p1", txtID.Text);// "@p1" parametresine, txtID TextBox'ındaki değeri atar.
                                                             // Kullanıcıdan girilen ID'ye göre arama yapılır.

            SqlDataReader dr = komut.ExecuteReader();// SQL sorgusu çalıştırılır ve sonuçları bir SqlDataReader nesnesine yüklenir.
                                                     // Bu nesne, sonuçları satır satır okumanıza olanak tanır.

            if (dr.Read()) // Eğer SQL sorgusu bir sonuç döndürüyorsa, yani ID'ye uygun bir kayıt bulunmuşsa...
            {

                txtAd.Text = dr["Ad"].ToString(); // Veri tabanındaki "Ad" sütunundan gelen değeri txtAd TextBox'ına yazdırır.
                txtSoyad.Text = dr["Soyad"].ToString();
                txtMail.Text = dr["Email"].ToString();
                txtTelefon.Text = dr["Telefon"].ToString();
                txtCalisanTuru.Text = dr["CalisanTuru"].ToString();
                txtCalismaGunleri.Text = dr["CalismaGunleri"].ToString();
                
            }
            else
            {   // Eğer ID'ye uygun bir kayıt bulunamamışsa...
                MessageBox.Show("Girilen Personel ID'si ile kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dr.Close();// Veri okuyucusunu kapatır. Kullanılmadığında kapatmak önemlidir.
            bgl.baglanti().Close();// Açık olan SQL bağlantısını kapatır. Bağlantıyı kapatmak kaynakları korur.
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

    }
}
