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
    public partial class iadeIslemleri : Form
    {
        public iadeIslemleri()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void iadeIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonDataSet8.oduncTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oduncTblTableAdapter.Fill(this.kütüphaneOtomasyonDataSet8.oduncTbl);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            formAnaMenu form1 = new formAnaMenu(); 
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            //yeni form ekranı açıp açılı olanı kapatma 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.oduncTblTableAdapter.Fill(this.kütüphaneOtomasyonDataSet8.oduncTbl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into oduncTbl (OduncID, UyeID, KitapID, OduncTarihi, SonTeslimYarihi) values (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());//sql sorgusunu oluşturur

            komut.Parameters.AddWithValue("@p1", txtOduncID.Text);// "@p1" parametresine, txtOduncID isimli TextBox'taki değeri atar.
                                                                  // Bu değer, ödünç kaydı için benzersiz bir kimlik (ID) olarak kullanılır.
            komut.Parameters.AddWithValue("@p2", txtUyeID.Text);
            komut.Parameters.AddWithValue("@p3", txtKitapID.Text);
            komut.Parameters.AddWithValue("@p4", txtOduncTarih.Text);
            komut.Parameters.AddWithValue("@p5", txtSonTeslimTarih.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM oduncTbl WHERE OduncID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtOduncID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE oduncTbl SET UyeID = @p2, KitapID = @p3, OduncTarihi = @p4, SonTeslimTarihi = @p5 WHERE OduncID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtOduncID.Text);
            komut.Parameters.AddWithValue("@p2", txtUyeID.Text);
            komut.Parameters.AddWithValue("@p3", txtKitapID.Text);
            komut.Parameters.AddWithValue("@p4", txtOduncTarih.Text);
            komut.Parameters.AddWithValue("@p5", txtSonTeslimTarih.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOduncID.Clear();
            txtUyeID.Clear();
            txtKitapID.Clear();
            txtOduncTarih.Clear();
            txtSonTeslimTarih.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOduncID.Text))
            {
                MessageBox.Show("Lütfen Personel ID giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand komut = new SqlCommand("SELECT * FROM oduncTbl WHERE OduncID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtOduncID.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())// Eğer SQL sorgusundan bir sonuç dönerse (bir kayıt bulunursa)...
            {

                txtOduncID.Text = dr["OduncID"].ToString();// "OduncID" sütunundaki veriyi txtOduncID TextBox'ına yazdırır.
                txtUyeID.Text = dr["UyeID"].ToString();
                txtKitapID.Text = dr["KitapID"].ToString();
                txtOduncTarih.Text = dr["OduncTarihi"].ToString();
                txtSonTeslimTarih.Text = dr["SonTeslimTarihi"].ToString();

                // Tarih kontrolü
                try
                {
                    DateTime bugununTarihi = DateTime.Now;// Bugünün tarihini alır ve bir DateTime nesnesine atar.

                    // txtSonTeslimTarih'i bir DateTime'e dönüştürüyoruz
                    DateTime sonTeslimTarihi;
                    if (DateTime.TryParse(txtSonTeslimTarih.Text, out sonTeslimTarihi))
                    {
                        if (sonTeslimTarihi < bugununTarihi)
                        {
                            // Gecikti
                            lblDurum.Text = "Gecikti";
                            lblDurum.ForeColor = Color.Red; // Kırmızı renk
                        }
                        else
                        {
                            // Gecikmedi
                            lblDurum.Text = "Gecikmedi";
                            lblDurum.ForeColor = Color.Green; // Yeşil renk
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir tarih giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);// Kullanıcıya bir hata mesajı gösterilir.
                        lblDurum.Text = "";// lblDurum etiketi boş olarak ayarlanır.
                    }
                }
                catch (Exception ex)
                {   // Eğer herhangi bir hata oluşursa...
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);// Hata mesajını kullanıcıya gösterir.
                    lblDurum.Text = "";// lblDurum etiketi boş olarak ayarlanır.
                }
            }
            else
            {   // Eğer SQL sorgusundan sonuç dönmezse (kayıt bulunamazsa)...
                MessageBox.Show("Girilen Personel ID'si ile kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);// Kullanıcıya bir hata mesajı gösterilir.
            }

            dr.Close();
            bgl.baglanti().Close();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
