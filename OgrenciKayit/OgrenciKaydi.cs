using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //
using System.Configuration; //

namespace OgrenciKayit
{
    public partial class OgrenciKaydi : Form
    {
        public OgrenciKaydi()
        {
            InitializeComponent();
        }
        OgrenciAyarlari oAyar = new OgrenciAyarlari();
        private void OgrenciKaydi_Load(object sender, EventArgs e)
        {
            

            #region ogrenciAyarlari.settings üzerinden son eklenen kaydı ekrana getirmek için
            _txtOAd.Text = oAyar.ad;
            _txtOSoyad.Text = oAyar.soyad;
            _cmbBolum.SelectedItem = oAyar.bolum;
            _txtDers.Text= oAyar.ders;
            #endregion
        }

        SqlConnection _baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString); //baglanti ConnectionString i hafızada tutuyor
        SqlCommand _komut;
        SqlDataAdapter _sqlDtadptr;
        private void _btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string _sorgu = "INSERT INTO [dbo].[Ogrenciler]([Ad],[Soyad],[Bolum],[Ders]) VALUES(@ad,@soyad,@bolum,@ders )";

                SqlCommand _sqlcmd = new SqlCommand(_sorgu, _baglanti);
                _sqlcmd.Parameters.AddWithValue("@ad", _txtOAd.Text); //parametreli olarak çıktı ver
                _sqlcmd.Parameters.AddWithValue("@soyad", _txtOSoyad.Text);
                _sqlcmd.Parameters.AddWithValue("@bolum", _cmbBolum.SelectedItem.ToString());
                _sqlcmd.Parameters.AddWithValue("@ders", _txtDers.Text);
                _baglanti.Open();

                _sqlcmd.ExecuteNonQuery(); //sorgu çıkışı
                _baglanti.Close();
                MessageBox.Show("Kayıt Yapıldı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Hatası"+ex);
                throw;
            }

            #region ogreniAyarlari.settings e kayıt almak için
            oAyar.ad = _txtOAd.Text;
            oAyar.soyad = _txtOSoyad.Text;
            oAyar.bolum = _cmbBolum.SelectedItem.ToString();
            oAyar.ders = _txtDers.Text;
            oAyar.Save();
            #endregion
        }

        private void _btnListele_Click(object sender, EventArgs e)
        {
            OgrenciListele _ogrenciListele = new OgrenciListele();
            _ogrenciListele.Show();
            this.Hide();
        }
    }
}
