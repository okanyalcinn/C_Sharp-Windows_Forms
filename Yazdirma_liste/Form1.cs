using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Yazdirma_liste
{
    public partial class Form1 : Form
    {
        int yazdirilan_no = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnSayfaYapisi_Click(object sender, EventArgs e)
        {
            _pageAyar.PageSettings = _printSayfa.DefaultPageSettings;
            if (_pageAyar.ShowDialog() == DialogResult.OK)
            {
                _printSayfa.DefaultPageSettings = _pageAyar.PageSettings;
            }
        }

        private void _btnEkle_Click(object sender, EventArgs e)
        {
            _listOgrenci.Items.Add(_txtOgrenci.Text);
            _listSinav.Items.Add(_txtSinav.Text);
            int not = int.Parse(_txtSinav.Text);
            if (not > 50)
            {
                _listSonuc.Items.Add("Geçti");
            }
            else
            {
                _listSonuc.Items.Add("Kaldı");
            }
        }

        private void _btnYazdir_Click(object sender, EventArgs e)
        {
            _printSayfa.Print();
        }

        private void _printSayfa_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x;
            int y;
            PageSettings p;
            int satir_yuksekligi;
            int sayfa_yuksekligi;
            int sayfa_genisligi;
            p = _printSayfa.DefaultPageSettings;//varsayılan ayarı uygula
            sayfa_yuksekligi = p.PaperSize.Height - p.Margins.Top - p.Margins.Bottom;
            sayfa_genisligi = p.PaperSize.Width - p.Margins.Left - p.Margins.Right;
            x = p.Margins.Left + 2;
            y = p.Margins.Top;
            StringFormat ortala = new StringFormat();
            ortala.Alignment = StringAlignment.Center; // konumlandırma
            StringFormat saga_yasla = new StringFormat();
            saga_yasla.Alignment = StringAlignment.Far;

            Font ustBaslik = new Font("Thoma", 20, FontStyle.Regular);
            Font anaBaslik = new Font("Thoma", 12, FontStyle.Regular);
            e.Graphics.DrawString(_textRaporBaslik.Text, ustBaslik, new SolidBrush(Color.Red), p.PaperSize.Width / 2, y, ortala);
            satir_yuksekligi = (int)e.Graphics.MeasureString("x", ustBaslik).Height;
            y += satir_yuksekligi + 2;
            Pen kalem = new Pen(Color.Red, 1);
            e.Graphics.DrawLine(kalem, p.Margins.Left, y, p.PaperSize.Width - p.Margins.Right, y); //çizgi oluşturma
            //sola yasla yazdır
            e.Graphics.DrawString("Öğrenci Adi", anaBaslik, new SolidBrush(Color.Red), x, y);
            //sayfa genişliği 3 te bir oranında ortada yazdır
            e.Graphics.DrawString("Sınav Notu", anaBaslik, new SolidBrush(Color.Red), x + sayfa_genisligi / 3, y);
            //sayfa genişliği soluna yazdır
            e.Graphics.DrawString("Sonuc", anaBaslik, new SolidBrush(Color.Red), x + 2 * sayfa_genisligi / 3, y);

            y += satir_yuksekligi + 2; //bi alt satıra geçsin diye
            e.Graphics.DrawLine(kalem, p.Margins.Left, y, p.PaperSize.Width - p.Margins.Right, y);//çizgi oluşturma


            //--- liste elemanlarını yazdırma
            Font liste_fontu = new Font("Thoma", 12, FontStyle.Regular);
            satir_yuksekligi = (int)e.Graphics.MeasureString("x", liste_fontu).Height; //satır yüksekliği atama
            int tablo_baslangic = 0;
            while (yazdirilan_no < _listOgrenci.Items.Count)
            {
                e.Graphics.DrawString(_listOgrenci.Items[yazdirilan_no].ToString(), liste_fontu, new SolidBrush(Color.Red), x, y);
                // sayfa genişliği 3 te bir oranında ortada yazdır
                e.Graphics.DrawString(_listOgrenci.Items[yazdirilan_no].ToString(), anaBaslik, new SolidBrush(Color.Red), x + sayfa_genisligi / 3, y);
                //sayfa genişliği soluna yazdır
                e.Graphics.DrawString(_listOgrenci.Items[yazdirilan_no].ToString(), anaBaslik, new SolidBrush(Color.Red), x + 2 * sayfa_genisligi / 3, y);
                y += satir_yuksekligi + 2; //bi alt satıra geçsin diye

                tablo_baslangic = y;

                e.Graphics.DrawLine(kalem, p.Margins.Left, y, p.PaperSize.Width - p.Margins.Right, y); //çizgi oluşturma
                yazdirilan_no += 1;

                //sonraki sayfa kontorlü, değer basarken sayfanın üst ve alt boşluklarını baz alarak bir sonraki sayfaya geçiş sağlıyor
                if ((y+satir_yuksekligi)>(p.PaperSize.Height-p.Margins.Bottom))
                {
                    e.HasMorePages = true;
                    break;
                }
            }
            if (yazdirilan_no >= _listOgrenci.Items.Count)
            {
                e.HasMorePages = false;
                yazdirilan_no = 0;//bir sonraki sayfa 
            }
            //sol çizgi
            e.Graphics.DrawLine(kalem, p.Margins.Left, tablo_baslangic, p.Margins.Left, y);
            //2.çizgi
            e.Graphics.DrawLine(kalem, p.Margins.Left+sayfa_genisligi/3-2, tablo_baslangic, p.Margins.Left+sayfa_genisligi /3-2, y);
            //3. çizgi
            e.Graphics.DrawLine(kalem, p.Margins.Left + 2 * sayfa_genisligi / 3 - 2, tablo_baslangic, p.Margins.Left + 2 * sayfa_genisligi / 3 - 2, y);
            //sağ dik çizgi
            e.Graphics.DrawLine(kalem, p.PaperSize.Width - p.Margins.Right, tablo_baslangic, p.PaperSize.Width - p.Margins.Right, y);
        }

        private void _btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            _printOnizleme.Document = _printSayfa;// print sayfadaki verileri önizleme
            _printOnizleme.ShowDialog();
        }

        private void _btnRandomSayi_Click(object sender, EventArgs e)
        {
            int i;
            string[] isimler = { "Ali", "Okan", "Veli" };
            int sinav;
            Random random = new Random();
            _listSonuc.Items.Clear();
            _listOgrenci.Items.Clear();
            _listSinav.Items.Clear();
            for ( i = 0; i < isimler.Length; i++)
            {                
                _listOgrenci.Items.Add(isimler[random.Next(isimler.Length)]);
                sinav = random.Next(100);
                _listSinav.Items.Add(sinav);
                if (sinav >=50)
                {
                    _listSonuc.Items.Add("Geçti");
                }
                else
                {
                    _listSonuc.Items.Add("Kaldı");
                }
            }
        }
    }
}
