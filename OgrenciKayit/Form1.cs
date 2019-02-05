using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; //
using System.Data.SqlClient; //

namespace OgrenciKayit
{
    /*
     * iki tür bağlantı mevcuttur
     * 
     *  connected : SqlCommand 
     *          veri tabanı ile sürekli bağlantı halindedir
     *  
     *  Disconnected : SqlDataAdapter
     *          veri tananı hafizaya alır işlem yapar
     *  
     *  
     * */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HesapAyarlari hAyar = new HesapAyarlari();

        private void Form1_Load(object sender, EventArgs e)
        {
            #region ayar.setting üzerinden kullanıcı adı şifre girişi
            //_txtKullaniciAdi.Focus();
            //_txtKullaniciAdi.Text = hAyar.KullaniciAdi;
            //_txtSifre.Text = hAyar.Sifre;
            //if (_txtKullaniciAdi.Text.Count() > 1)
            //{
            //    _chckHatirla.Checked = true;
            //}
            #endregion
            #region text box içerisinde kullanıcı adı gir kısmı gelmesi için -- dünzenlemelisin
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
            #endregion
        }

        private void _btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection _baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString); //baglanti ConnectionString i hafızada tutuyor

            _baglan.Open();

            DataSet _dataSet = new DataSet();
            if (string.IsNullOrEmpty(_txtKullaniciAdi.Text)||string.IsNullOrEmpty(_txtSifre.Text))
            {
                MessageBox.Show("Hatalı giriş !");
            }
            else
            {
                SqlParameter _kullaniciSqlP = new SqlParameter("@kullanici_adi", _txtKullaniciAdi.Text);
                SqlParameter _sifreSqlP = new SqlParameter("@sifre", _txtSifre.Text);

                //sql sorgu cimlesi
                string _sorgu = "SELECT [ID],[Adi],[Sifre],[Rol] FROM[dbo].[Kullanicilar] where Adi=@kullanici_adi and Sifre=@Sifre "; //select * from kullanıcılar diyerek te işlem yapılabilir

                //sql sorgu çektik
                SqlCommand _sqlCommand = new SqlCommand(_sorgu,_baglan);
                //tanmlamalar atandı
                _sqlCommand.Parameters.Add(_kullaniciSqlP);
                _sqlCommand.Parameters.Add(_sifreSqlP);

                //olayı database e gönderme
                SqlDataReader _sqlDr = _sqlCommand.ExecuteReader(); //okuma

                if (_sqlDr.Read())
                {
                    this.Hide();
                    MessageBox.Show("Giriş başarılı");
                    OgrenciKaydi _ogrenciKaydi = new OgrenciKaydi();
                    _ogrenciKaydi.Show();
                                       
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yapıldı !");
                }
                _baglan.Close();
            }
            #region ayar.setting üzerinden kullanıcı adı şifre girişi
            //if (_txtKullaniciAdi.Text == "admin" && _txtSifre.Text == "1234")
            //{
            //    OgrenciKaydi ogrenciKaydi = new OgrenciKaydi();
            //    ogrenciKaydi.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Hatalı giriş!");
            //}
            //if (_chckHatirla.Checked == true)
            //{
            //    hAyar.KullaniciAdi = _txtKullaniciAdi.Text;
            //    hAyar.Sifre = _txtSifre.Text;

            //}
            //else
            //{
            //    hAyar.KullaniciAdi = "";
            //    hAyar.Sifre = "";
            //}
            //hAyar.Save();
            #endregion
        }
        #region methodlar text box içerisinde kullanıcı adı gir kısmı gelmesi için -- dünzenlemelisin
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
        #endregion

    }
}
