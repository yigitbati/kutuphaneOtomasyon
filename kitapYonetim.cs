using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneOtomasyonuUygulaması
{
    public partial class formKitapYonetim : Form
    {
        private KitapYonetimi kitapYonetimi;
        public formKitapYonetim()
        {
            InitializeComponent();
            kitapYonetimi = new KitapYonetimi();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void formKitapYonetim_Load(object sender, EventArgs e)
        {
            kitapYonetimi.Yenile(dataGridView1);// 'kitapYonetimi' nesnesi üzerinden 'Yenile' metodunu çağırıyor ve 'dataGridView1' üzerinde veri güncelleniyor

        }

        private void button7_Click(object sender, EventArgs e)
        {
            formAnaMenu form1 = new formAnaMenu();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            //form değiştirme butonu
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapYonetimi.Yenile(dataGridView1); // 'kitapYonetimi' nesnesi üzerinden 'Yenile' metodunu çağırarak 'dataGridView1' üzerinde veri güncelleniyor
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap yeniKitap = new Kitap // Kitap nesnesi oluşturuluyor ve metin kutularındaki verilere göre özellikler atanıyor.
                {
                    KitapAdi = txtKitapAdi.Text,// Kitap adı kullanıcıdan alınıyor
                    Yazar = txtYazar.Text,// Yazar adı kullanıcıdan alınıyor
                    Yayinevi = txtYayinevi.Text,
                    YayinYili = int.Parse(txtYayinYili.Text),// Yayımlanma yılı, metin kutusundan int'e dönüştürülerek alınıyor
                    Kategori = cmboxKategori.SelectedItem.ToString(),// Kategori seçilen öğe olarak alınıyor
                    SayfaSayisi = int.Parse(txtSayfaSayisi.Text),
                    Dil = txtDil.Text// Kitap dili kullanıcıdan alınıyor
                };
                // Kitap nesnesi 'kitapYonetimi' sınıfının Kaydet metoduna iletilerek veritabanına kaydediliyor.
                kitapYonetimi.Kaydet(yeniKitap);
                // Başarılı kaydetme durumunda kullanıcıya bilgi mesajı gösteriliyor.
                MessageBox.Show("Kitap başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {   // Kullanıcının girdiği kitap ID'si metin kutusundan alınır ve integer'a dönüştürülür.
                int kitapID = int.Parse(txtKitapID.Text);
                // kitapYonetimi sınıfındaki Sil metoduna kitap ID'si gönderilerek kitap silme işlemi yapılır.
                kitapYonetimi.Sil(kitapID); // Kitap silme işlemi
                // Kitap başarılı bir şekilde silindiyse, kullanıcıya bilgi mesajı gösterilir.
                MessageBox.Show("Kitap başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {   // Kullanıcının girdiği kitap bilgileri alınarak bir Kitap nesnesi oluşturuluyor.
                Kitap kitap = new Kitap
                {
                    KitapID = int.Parse(txtKitapID.Text),// KitapID, txtKitapID metin kutusundan alınarak integer'a dönüştürülür.
                    KitapAdi = txtKitapAdi.Text,
                    Yazar = txtYazar.Text,
                    Yayinevi = txtYayinevi.Text,
                    YayinYili = int.Parse(txtYayinYili.Text),
                    Kategori = cmboxKategori.SelectedItem.ToString(),// Kategori, combobox'tan seçilen değer alınır.
                    SayfaSayisi = int.Parse(txtSayfaSayisi.Text),
                    Dil = txtDil.Text
                };
                // kitapYonetimi sınıfındaki Guncelle metoduna Kitap nesnesi gönderilir.
                kitapYonetimi.Guncelle(kitap); // Kitap güncelleme işlemi
                MessageBox.Show("Kitap başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {   // txtKitapID metin kutusundan kitap ID'si alınır ve int türüne dönüştürülür.
                int kitapID = int.Parse(txtKitapID.Text);
                // kitapYonetimi sınıfındaki Aktar metoduna kitapID ve form elemanları (textboxes, combobox) gönderilir.
                kitapYonetimi.Aktar(kitapID, txtKitapID, txtKitapAdi, txtYazar, txtYayinevi, txtYayinYili, cmboxKategori, txtSayfaSayisi, txtDil);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //text boxları ve comboboxları temizler
            txtKitapID.Clear();
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayinevi.Clear();
            txtYayinYili.Clear();
            txtSayfaSayisi.Clear();
            txtDil.Clear();
            cmboxKategori.SelectedIndex = -1;
        }
    }
}
