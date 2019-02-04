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
                //kendi oluşturduğumuz giris ismindeki settings sınıfımıza ulaşmak için bu yazım kullanılır
                Giris.Default["KullaniciAdi"] = _txtKullanici.Text;
                Giris.Default["Sifre"] = _txtSifre.Text;

                //projenin otomatik oluşturduğu properties klasörü altındadaki settings sınıfına ulaşmak için bu yazım kullanılır bakınız: http://akillimum.blogspot.com/2015/07/c-windows-forms-beni-hatrla-secenegi.html
                //Properties.Settings.Default["KullaniciAdi"] = _txtKullanici.Text;
                //Properties.Settings.Default["Sifre"] = _txtSifre.Text;
            }
            else
            {
                Giris.Default["KullaniciAdi"] = "";
                Giris.Default["Sifre"] = "";
                //Properties.Settings.Default["KullaniciAdi"] = "";
                //Properties.Settings.Default["Sifre"] = "";
            }
            if (_txtKullanici.Text == "admin" && _txtSifre.Text == "1234")
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız", "Giriş Hatası", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            Giris.Default.Save(); //kullanıcı ayarlarını kaydetmek için kullanılır. Program kapatılıp açıldığında kullanıcı adı  ve şifremizi hatırlar
            // bakınız: https://docs.microsoft.com/tr-tr/dotnet/framework/winforms/advanced/how-to-write-user-settings-at-run-time-with-csharp
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _txtKullanici.Focus();
            _txtKullanici.Text = Giris.Default["KullaniciAdi"].ToString();
            _txtSifre.Text = Giris.Default["Sifre"].ToString();
            //_txtKullanici.Text = Properties.Settings.Default["KullaniciAdi"].ToString();
            //_txtSifre.Text = Properties.Settings.Default["Sifre"].ToString();
            if (_txtKullanici.Text.Count() >1)
            {
                _chkHatirla.Checked = true;
            }
        }
    }
}
