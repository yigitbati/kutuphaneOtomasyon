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
    public partial class formGiris : Form
    {
        public formGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Kullanıcı girişi sadece adminler tarafından olacağı için kayıt eklenmedi. 
            Kullanıcı isimleri değiştirilebilir sql kullanılarak yapılabilirdi 
            kayıt eklenmediği için yapılmadı*/
            if (txtKullaniciAdi.Text == "Admin01" && txtSifre.Text == "12345" ||
                txtKullaniciAdi.Text == "Admin02" && txtSifre.Text == "1234567" ||
                txtKullaniciAdi.Text == "Admin03" && txtSifre.Text == "232323" ||
                txtKullaniciAdi.Text == "a" && txtSifre.Text == "1")
            {
                //ana menünün açılması için kullanılan kod
                formAnaMenu form2 = new formAnaMenu();
                form2.Show();
                this.Hide(); //hide ile giriş formu sadece saklanıyor arkada açık kalıyor
                form2.FormClosed += (s, args) => this.Close(); //bu kod ile kapatılıyor bilgisayara fazla yüklenme olmaması için saklanan formu kapatıyoruz

            }
            else
            {

                MessageBox.Show("Geçersiz şifre veya kullanıcı adı.");

            }
        }
    }
}
