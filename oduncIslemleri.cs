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
    public partial class oduncIslemleri : Form
    {
        public oduncIslemleri()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void oduncIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneOtomasyonDataSet7.Uyeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyelerTableAdapter.Fill(this.kütüphaneOtomasyonDataSet7.Uyeler);
            // TODO: Bu kod satırı 'kütüphaneOtomasyonDataSet6.kitapTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitapTblTableAdapter.Fill(this.kütüphaneOtomasyonDataSet6.kitapTbl);
            // TODO: Bu kod satırı 'kütüphaneOtomasyonDataSet5.oduncTbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oduncTblTableAdapter.Fill(this.kütüphaneOtomasyonDataSet5.oduncTbl);

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
            this.oduncTblTableAdapter.Fill(this.kütüphaneOtomasyonDataSet5.oduncTbl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into oduncTbl (UyeID, KitapID, OduncTarihi, SonTeslimTarihi) values (@p2, @p3, @p4, @p5)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p2", txtUyeID.Text);
            komut.Parameters.AddWithValue("@p3", txtKitapID.Text);
            komut.Parameters.AddWithValue("@p4", txtOduncTarih.Text);
            komut.Parameters.AddWithValue("@p5", txtTeslimTarih.Text);
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

            komut.Parameters.AddWithValue("@p1", txtOduncID.Text); // Güncellenecek kaydın ID'si
            komut.Parameters.AddWithValue("@p2", txtUyeID.Text);
            komut.Parameters.AddWithValue("@p3", txtKitapID.Text);
            komut.Parameters.AddWithValue("@p4", DateTime.Parse(txtOduncTarih.Text)); // Tarih formatını dönüştür
            komut.Parameters.AddWithValue("@p5", DateTime.Parse(txtTeslimTarih.Text)); // Tarih formatını dönüştür

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt başarıyla güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOduncID.Clear();
            txtUyeID.Clear();
            txtKitapID.Clear();
            txtOduncTarih.Clear();
            txtTeslimTarih.Clear();
            txtOduncID.Clear();
            
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

            if (dr.Read())
            {

                txtOduncID.Text = dr["OduncID"].ToString();
                txtUyeID.Text = dr["UyeID"].ToString();
                txtKitapID.Text = dr["KitapID"].ToString();
                txtOduncTarih.Text = dr["OduncTarihi"].ToString();
                txtTeslimTarih.Text = dr["SonTeslimTarihi"].ToString();
                

            }
            else
            {
                MessageBox.Show("Girilen Personel ID'si ile kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dr.Close();
            bgl.baglanti().Close();
        }
    }
}
