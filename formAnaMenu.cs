using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kütüphaneOtomasyonuUygulaması
{
    public partial class formAnaMenu : Form
    {   
        private TabloYukleyici tabloYukleyici; //tablo yükleyici tanımlıyoruz

        public formAnaMenu()//sql bağlantısını sağlamak için 
        {
            InitializeComponent();
            string connString = "Data Source=BATI;Initial Catalog=kütüphaneOtomasyon;Integrated Security=True";
            tabloYukleyici = new TabloYukleyici(connString); 
        }

        // sqlBaglantisi nesnesi
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void button9_Click(object sender, EventArgs e)
        {
            formGiris form1 = new formGiris(); 
            form1.Show(); //yeni formu açma 
            this.Hide(); //şu anki formu gizleme 
            form1.FormClosed += (s, args) => this.Close(); //gizlenen formu kapatma 
            //yeni form açıp, açık olan formu kapatma  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            tabloYukleyici.TabloyuYukle(dataGridView1, "kitapTbl"); //kitaplar tablosunu çağırmak için
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabloYukleyici.TabloyuYukle(dataGridView1, "Uyeler"); //üyeler tablosunu çağırmak için
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabloYukleyici.TabloyuYukle(dataGridView1, "oduncTbl"); // odünç tablosunu çağırmak için
        }

        private void formAnaMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formKitapYonetim form1 = new formKitapYonetim();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            //yeni form açıp, açık olan formu kapatma 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeYonetim form1 = new uyeYonetim();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            //yeni form açıp, açık olan formu kapatma 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calisanYonetimi form1 = new calisanYonetimi();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            //yeni form açıp, açık olan formu kapatma 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oduncIslemleri form1 = new oduncIslemleri();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            //yeni form açıp, açık olan formu kapatma 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            iadeIslemleri form1 = new iadeIslemleri();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            //yeni form açıp, açık olan formu kapatma 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Raporlama form1 = new Raporlama();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            //yeni form açıp, açık olan formu kapatma 
        }
    }
}
