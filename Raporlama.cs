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
    public partial class Raporlama : Form
    {
        private TabloYukleyici tabloYukleyici;
        sqlBaglantisi bgl = new sqlBaglantisi();

        public Raporlama()
        {
            InitializeComponent();
            string connString = "Data Source=BATI;Initial Catalog=kütüphaneOtomasyon;Integrated Security=True";
            tabloYukleyici = new TabloYukleyici(connString);
            Raporla raporlama = new Raporla(); 

            // ComboBox'a tablo adlarını ekle
            
            comboBox1.Items.Add("kitapTbl");
            comboBox1.Items.Add("Uyeler");
            comboBox1.Items.Add("oduncTbl");
            comboBox1.SelectedIndex = 0; // Varsayılan seçim
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            formAnaMenu form1 = new formAnaMenu();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenTablo = comboBox1.SelectedItem.ToString();
            tabloYukleyici.TabloyuYukle(dataGridView1, secilenTablo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUyeID.Text))// Kullanıcının 'UyeID' alanını boş bırakıp bırakmadığını kontrol ediyoruz
            {
                MessageBox.Show("Lütfen Personel ID giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);// Eğer boşsa uyarı mesajı gösteriyoruz
                return;// İşlem burada sonlanır, fonksiyon çalışmaya devam etmez
            }

            // İlk sorgu: CalisanGonullu tablosundan veri çek
            using (SqlConnection conn = bgl.baglanti())// Veritabanı bağlantısını açıyoruz
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM Uyeler WHERE UyeID = @p1", conn);// 'Uyeler' tablosundan 'UyeID' ile veri çekme sorgusu
                komut.Parameters.AddWithValue("@p1", txtUyeID.Text);// Parametre olarak girilen 'UyeID' değerini sorguya ekliyoruz

                using (SqlDataReader dr = komut.ExecuteReader())// Sorguyu çalıştırıyoruz ve verileri okuyabilmek için SqlDataReader kullanıyoruz
                {
                    if (dr.Read())// Eğer sorgudan veri dönerse
                    {
                        txtAd.Text = dr["Ad"].ToString(); // 'Ad' sütunundaki değeri 'txtAd' textbox'ına yazıyoruz
                        txtSoyad.Text = dr["Soyad"].ToString();
                        txtMail.Text = dr["Email"].ToString();
                        txtTelefon.Text = dr["Telefon"].ToString();
                        
                    }
                    else// Eğer 'UyeID' ile eşleşen kayıt bulunamazsa
                    {
                        MessageBox.Show("Girilen Personel ID'si ile kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);// Hata mesajı gösteriyoruz
                        return; // işlemi bitir
                    }
                }
            }

            // İkinci sorgu: oduncTbl tablosundan UyeID'ye göre veri çek
            using (SqlConnection conn = bgl.baglanti())// Veritabanı bağlantısı açılır
            {
                SqlCommand komut2 = new SqlCommand("SELECT * FROM oduncTbl WHERE UyeID = @p1", conn);// 'oduncTbl' tablosundan 'UyeID' ile veri çekme sorgusu
                komut2.Parameters.AddWithValue("@p1", txtUyeID.Text); // txtID'yi UyeID ile eşleştiriyoruz

                using (SqlDataReader dr2 = komut2.ExecuteReader())// Sorgu çalıştırılır ve veri okuyabilmek için 'SqlDataReader' kullanılır
                {
                    if (dr2.Read())// Eğer sorgudan veri dönerse
                    {
                        txtKitapID.Text = dr2["KitapID"].ToString(); // 'KitapID' sütunundaki değeri 'txtKitapID' textbox'ına yazıyoruz
                        txtOduncTarih.Text = dr2["OduncTarihi"].ToString();
                        txtSonTeslimTarih.Text = dr2["SonTeslimTarihi"].ToString();
                    }
                    else// Eğer 'UyeID' ile eşleşen ödünç kaydı bulunamazsa
                    {
                        MessageBox.Show("Girilen Uye ID'si ile ödünç kaydı bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }


        }
    }
}
