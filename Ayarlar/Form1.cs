using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection; //
using System.Diagnostics; //
namespace Ayarlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void _btnGiris_Click(object sender, EventArgs e)
        {
            if (_chkHatirla.Checked==true)
            {
                Properties.Settings.Default["KullaniciAdi"] = _txtKullanici;
                Properties.Settings.Default["Sifre"] = _txtSifre.Text;
            }
            else
            {
                Properties.Settings.Default[""] = _txtKullanici;
                Properties.Settings.Default[""] = _txtSifre.Text;
            }
            if (_txtKullanici.Text == "Admin" && _txtSifre.Text == "1234")
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız", "Giriş Hatası", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _txtKullanici.Focus();
            _txtKullanici.Text = Properties.Settings.Default["KullaniciAdi"].ToString();
            _txtSifre.Text = Properties.Settings.Default["Sifre"].ToString();
            if (_txtKullanici.Text.Count() >1)
            {
                _chkHatirla.Checked = true;
            }
        }
    }
}
