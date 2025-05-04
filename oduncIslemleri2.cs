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
    public partial class oduncIslemleri2 : Form
    {
        public oduncIslemleri2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formAnaMenu form1 = new formAnaMenu();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
        }
    }
}
