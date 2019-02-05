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
    public partial class OgrenciKaydi : Form
    {
        public OgrenciKaydi()
        {
            InitializeComponent();
        }
        OgrenciAyarlari oAyar = new OgrenciAyarlari();
        private void OgrenciKaydi_Load(object sender, EventArgs e)
        {
            _cmbBolum.Items.Add("Bilişim");
            _cmbBolum.Items.Add("Fen");
            _txtAd.Text = oAyar.ad;
            _txtSoyad.Text = oAyar.soyad;
            _cmbBolum.SelectedItem = oAyar.bolum;
            _txtDers.Text= oAyar.ders;
        }

        private void _btnEkle_Click(object sender, EventArgs e)
        {
            oAyar.ad = _txtAd.Text;
            oAyar.soyad = _txtSoyad.Text;
            oAyar.bolum = _cmbBolum.SelectedItem.ToString();
            oAyar.ders = _txtDers.Text;
            oAyar.Save();
        }
    }
}
