using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HesapAyarlari hAyar = new HesapAyarlari();

        private void Form1_Load(object sender, EventArgs e)
        {
            _txtKullaniciAdi.Focus();
            _txtKullaniciAdi.Text = hAyar.KullaniciAdi;
            _txtSifre.Text = hAyar.Sifre;
            if (_txtKullaniciAdi.Text.Count() > 1)
            {
                _chckHatirla.Checked = true;
            }
            //if (_txtKullaniciAdi.Text == hesapAyarlari.KullaniciAdi && _txtSifre.Text == hesapAyarlari.Sifre)
            //{
            //    _chckHatirla.Checked = true;
            //}
            //else
            //{
            //    _txtKullaniciAdi.Text = "Kullanıcı adı gir...";
            //    _txtSifre.Text = "Şifre gir...";
            //}


            //_txtKullaniciAdi.GotFocus += SilText1;
            ////_txtKullaniciAdi.GotFocus += MesajEkle;

            //_txtKullaniciAdi.GotFocus += SilText2;
            ////_txtKullaniciAdi.GotFocus += MesajEkle;

            //_txtKullaniciAdi.Text = hesapAyarlari.KullaniciAdi;
            //_txtSifre.Text = hesapAyarlari.Sifre;

        }

        private void _btnGiris_Click(object sender, EventArgs e)
        {
            if (_txtKullaniciAdi.Text == "admin" && _txtSifre.Text == "1234")
            {
                OgrenciKaydi ogrenciKaydi = new OgrenciKaydi();
                ogrenciKaydi.Show();
                this.Hide();                
            }
            else
            {
                MessageBox.Show("Hatalı giriş!");
            }
            if (_chckHatirla.Checked == true)
            {
                hAyar.KullaniciAdi = _txtKullaniciAdi.Text;
                hAyar.Sifre = _txtSifre.Text;
                
            }
            else
            {
                hAyar.KullaniciAdi = "";
                hAyar.Sifre = "";
            }
hAyar.Save();

        }

        //public void SilText1(object sender, EventArgs e)
        //{
        //    _txtKullaniciAdi.Text = "";
        //}

        //public void SilText2(object sender, EventArgs e)
        //{
        //    _txtSifre.Text = "";
        //}

        //public void MesajText(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(_txtKullaniciAdi.Text))
        //    {
        //        _txtKullaniciAdi.Text = "Kullanıcı adı gir...";
        //    }

        //    if (string.IsNullOrWhiteSpace(_txtSifre.Text))
        //    {
        //        _txtSifre.Text = "Şifre gir...";
        //    }
        //}

    }
}
