using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphaneOtomasyonuUygulaması
{
    
    public class Kitap
    {
        sqlBaglantisi bgl = new sqlBaglantisi(); // sqlBaglantisi sınıfından bgl adında bir nesne oluşturulur, bu nesne veri tabanı bağlantısı için kullanılabilir.
        public int KitapID {  get; set; }// Kitapların benzersiz kimlik numarasını tutan bir özellik tanımlar. Bu özellik int türünde.
        public string KitapAdi { get; set; }// Kitabın adını tutan bir özellik tanımlar. Bu özellik string türünde.
        public string Yazar {  get; set; }  
        public string Yayinevi { get; set; }
        public int YayinYili {  get; set; }
        public string Kategori {  get; set; }
        public int SayfaSayisi {  get; set; }
        public string Dil { get;set; }
        public void Kaydet() // Kitap bilgilerini veri tabanına kaydetmek için kullanılan bir metot.
        {
            sqlBaglantisi bgl = new sqlBaglantisi();
            using (SqlConnection connection = bgl.baglanti())// Veri tabanı bağlantısını açmak için SqlConnection kullanılır. 'using' bloğu bağlantıyı otomatik kapatır
            {
                string query = "INSERT INTO kitapTbl (KitapAd, Yazar, Yayinevi, YayinYili, Kategori, SayfaSayisi, Dil) " + // Veri tabanına eklenecek SQL sorgusu.
                               "VALUES (@KitapAdi, @Yazar, @Yayinevi, @YayinYili, @Kategori, @SayfaSayisi, @Dil)"; // Parametreler ile sorgu hazırlanır.
                using (SqlCommand command = new SqlCommand(query, connection)) // SQL komutunu çalıştırmak için SqlCommand nesnesi oluşturulur.
                {   // SQL komutuna parametreler eklenir, bunlar metottan alınan değerlerle bağlanacaktır.
                    command.Parameters.AddWithValue("@KitapAd", KitapAdi); // @KitapAdi parametresine KitapAdi değeri atanır.
                    command.Parameters.AddWithValue("@Yazar", Yazar);
                    command.Parameters.AddWithValue("@Yayinevi", Yayinevi);
                    command.Parameters.AddWithValue("@YayinYili", YayinYili);
                    command.Parameters.AddWithValue("@Kategori", Kategori);
                    command.Parameters.AddWithValue("@SayfaSayisi", SayfaSayisi);
                    command.Parameters.AddWithValue("@Dil", Dil);

                    command.ExecuteNonQuery(); // Sorguyu çalıştırır ve veri tabanına ekler. (Veri ekleme işlemi yapılır)
                }
            }

        }

        public void Sil()  // Kitap kaydını veri tabanından silmek için kullanılan bir metot.
        {
            sqlBaglantisi bgl = new sqlBaglantisi();
            using (SqlConnection connection = bgl.baglanti()) // Veri tabanı bağlantısını açmak için SqlConnection kullanılır. 'using' bloğu bağlantıyı otomatik kapatır.
            {
                string query = "DELETE FROM kitapTbl WHERE KitapID = @KitapID";// KitapID'ye göre kitap kaydını silmek için SQL sorgusu
                using (SqlCommand command = new SqlCommand(query, connection))// SQL komutunu çalıştırmak için SqlCommand nesnesi oluşturulur.
                {
                    command.Parameters.AddWithValue("@KitapID", KitapID); // @KitapID parametresine KitapID değeri atanır, bu değer metodun dışındaki sınıf özelliğinden alınır.
                    command.ExecuteNonQuery();// Sorguyu çalıştırır ve belirtilen KitapID'ye sahip kaydı veri tabanından siler.
                }
            }
        }

        public void Guncelle() // Kitap bilgisini güncellemek için kullanılan bir metot.
        {
            sqlBaglantisi bgl = new sqlBaglantisi();
            using (SqlConnection connection = bgl.baglanti())// SQL sorgusu, kitap bilgilerini güncellemek için yazılır. KitapID'ye göre bir kitabın bilgileri güncellenir.

            {
                string query = "UPDATE kitapTbl SET KitapAd = @KitapAd, Yazar = @Yazar, Yayinevi = @Yayinevi, " +
                               "YayinYili = @YayinYili, Kategori = @Kategori, SayfaSayisi = @SayfaSayisi, Dil = @Dil " +
                               "WHERE KitapID = @KitapID"; // WHERE koşulu ile sadece belirli KitapID'ye sahip kayıt güncellenir.
                using (SqlCommand command = new SqlCommand(query, connection))// SqlCommand nesnesi oluşturulur ve SQL sorgusu, bağlantı nesnesi ile ilişkilendirilir.
                {   // SQL sorgusundaki parametrelere değerler atanır. Bu parametreler kullanıcıdan alınan verilere bağlanır.
                    command.Parameters.AddWithValue("@KitapAd", KitapAdi);// @KitapAd parametresine KitapAdi değeri atanır.
                    command.Parameters.AddWithValue("@Yazar", Yazar);
                    command.Parameters.AddWithValue("@Yayinevi", Yayinevi);
                    command.Parameters.AddWithValue("@YayinYili", YayinYili);
                    command.Parameters.AddWithValue("@Kategori", Kategori);
                    command.Parameters.AddWithValue("@SayfaSayisi", SayfaSayisi);
                    command.Parameters.AddWithValue("@Dil", Dil);
                    command.Parameters.AddWithValue("@KitapID", KitapID);

                    command.ExecuteNonQuery();// Sorgu çalıştırılır, belirlenen KitapID'ye sahip kitap kaydını günceller.
                }
            }
        }

        public static Kitap Getir(int kitapID)// Parametre olarak kitapID alır ve bu ID'ye göre kitap bilgilerini getirir.
        {
            sqlBaglantisi bgl = new sqlBaglantisi();
            using (SqlConnection connection = bgl.baglanti()) // SqlConnection nesnesi, 'bgl.baglanti()' ile veri tabanına bağlanılır.
            {
                string query = "SELECT * FROM kitapTbl WHERE KitapID = @KitapID";// KitapID'ye göre kitap bilgilerini seçen SQL sorgusu.
                using (SqlCommand command = new SqlCommand(query, connection))// SqlCommand nesnesi oluşturulur ve SQL sorgusu, bağlantı nesnesi ile ilişkilendirilir.
                {
                    command.Parameters.AddWithValue("@KitapID", kitapID);// KitapID parametresi sorguya eklenir, kullanıcının girdiği ID ile sorgu yapılır.

                    using (SqlDataReader reader = command.ExecuteReader()) // SqlDataReader kullanılarak sorgu çalıştırılır ve sonuçları okuyabilmek için bir okuma işlemi başlatılır.
                    {
                        if (reader.Read()) // Eğer sorgu sonucunda en az bir satır varsa (kitap bulunduysa) okuma yapılır.
                        {    // Kitap bilgileri SqlDataReader ile okunur ve yeni bir Kitap nesnesi oluşturulur.
                            return new Kitap // Yeni bir Kitap nesnesi döndürülür ve kitap bilgileri bu nesneye atanır.
                            {
                                KitapID = reader.GetInt32(reader.GetOrdinal("KitapID")),// KitapID değeri okunur ve Kitap nesnesinin KitapID özelliğine atanır.
                                KitapAdi = reader.GetString(reader.GetOrdinal("KitapAd")),
                                Yazar = reader.GetString(reader.GetOrdinal("Yazar")),
                                Yayinevi = reader.GetString(reader.GetOrdinal("Yayinevi")),
                                YayinYili = reader.GetInt32(reader.GetOrdinal("YayinYili")),
                                Kategori = reader.GetString(reader.GetOrdinal("Kategori")),
                                SayfaSayisi = reader.GetInt32(reader.GetOrdinal("SayfaSayisi")),
                                Dil = reader.GetString(reader.GetOrdinal("Dil"))
                            };
                        }
                    }
                }
            }

            return null;
            
        }

    }
}
