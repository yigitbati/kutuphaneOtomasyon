using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kütüphaneOtomasyonuUygulaması
{
    public class sqlBaglantisi
    {
        /* Bu class sadece SQL bağlantısı için açıldı. Farklı bir bilgisayara kopyalandığında
        her şeyi tek tek yapmamak için düzenlendi. */
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=BATI;Initial Catalog=kütüphaneOtomasyon;Integrated Security=True");

            try
            {
                baglan.Open();
                // SQL dil ayarını Türkçe olarak ayarlıyoruz
                using (SqlCommand cmd = new SqlCommand("SET LANGUAGE Turkish", baglan))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Eğer bağlantı sırasında bir hata oluşursa bu kısmı yönetebilirsiniz
                Console.WriteLine("Bağlantı sırasında bir hata oluştu: " + ex.Message);
            }

            return baglan;
        }
    }
}
