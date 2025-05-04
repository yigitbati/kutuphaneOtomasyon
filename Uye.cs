using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneOtomasyonuUygulaması
{
    public class Uye
    {
        public int UyeID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime DogumTarihi { get; set; }

        public void Kaydet()
        {
            sqlBaglantisi bgl = new sqlBaglantisi();
            try
            {
                SqlCommand komut = new SqlCommand("INSERT INTO Uyeler (Ad, Soyad, Telefon, Email, Adres, KayitTarihi, DogumTarihi) " +
                                                 "VALUES (@Ad, @Soyad, @Telefon, @Email, @Adres, @KayitTarihi, @DogumTarihi)", bgl.baglanti());
                komut.Parameters.AddWithValue("@Ad", Ad);
                komut.Parameters.AddWithValue("@Soyad", Soyad);
                komut.Parameters.AddWithValue("@Telefon", Telefon);
                komut.Parameters.AddWithValue("@Email", Email);
                komut.Parameters.AddWithValue("@Adres", Adres);
                komut.Parameters.AddWithValue("@KayitTarihi", KayitTarihi);
                komut.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Sil()
        {
            sqlBaglantisi bgl = new sqlBaglantisi();
            using (SqlConnection connection = bgl.baglanti())
            {
                string query = "DELETE FROM Uyeler WHERE UyeID = @UyeID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeID", UyeID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Guncelle()
        {
            sqlBaglantisi bgl = new sqlBaglantisi();
            using (SqlConnection connection = bgl.baglanti())
            {
                string query = "UPDATE Uyeler SET Ad = @Ad, Soyad = @Soyad, Email = @Email, " +
                               "DogumTarihi = @DogumTarihi WHERE UyeID = @UyeID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeAd", Ad);
                    command.Parameters.AddWithValue("@UyeSoyad", Soyad);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
                    command.Parameters.AddWithValue("@UyeID", UyeID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static Uye Getir(int uyeID)
        {
            sqlBaglantisi bgl = new sqlBaglantisi();
            Uye uye = null;
            try
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM Uyeler WHERE UyeID = @UyeID", bgl.baglanti());
                komut.Parameters.AddWithValue("@UyeID", uyeID);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    uye = new Uye
                    {
                        UyeID = Convert.ToInt32(dr["UyeID"]),
                        Ad = dr["Ad"].ToString(),
                        Soyad = dr["Soyad"].ToString(),
                        Telefon = dr["Telefon"].ToString(),
                        Email = dr["Email"].ToString(),
                        Adres = dr["Adres"].ToString(),
                        KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"]),
                        DogumTarihi = Convert.ToDateTime(dr["DogumTarihi"])
                    };
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return uye;
        }

    }
}
